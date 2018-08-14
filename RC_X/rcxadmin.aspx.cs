using System;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace RC_X
{
    public partial class rcxadmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                aspxLogger.Items.Clear(); ASPxLblStatus.Text = "";

                string adminUser = Session["UserEmail"].ToString();  //|| adminUser.Equals("bala@ehr-llc.com")
                if (adminUser != string.Empty && (adminUser.Equals("fcruz@ehr-llc.com") || adminUser.Equals("bcardone@ehr-llc.com") || adminUser.Equals("mohanbabunugala276@gmail.com") || adminUser.Equals("bala@ehr-llc.com")))
                {
                    ASPxCBDB.Items.Add("<--Select Database-->");
                    ASPxCBDB.Items.Add("Blank Enterprise");
                    ASPxCBDB.Items.Add("MITA Assessment");
                    ASPxCBDB.SelectedIndex = 0;
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('You are not an admin to access this page.Please ask the admin');window.location.href ='rc_project/userhome.aspx' ", true);
                    ASPxTxtEnterprise.Enabled = false;
                    ASPxCBDB.Enabled = false;
                    ASPxBtnSubmit.Enabled = false;
                }
            }
        }

        protected void ASPxBtnSubmit_Click(object sender, EventArgs e)
        {
            int retry = -1;
            string enterpriseName = "", databaseName = "", dbCreateQry = "";
            string _connStr = "";
            enterpriseName = "state_of_" + ASPxTxtEnterprise.Text.Trim();
            //Validating the Combobox
            if (ASPxCBDB.SelectedIndex != 0 && ASPxCBDB.SelectedItem.Value.ToString() != string.Empty)
            {
                databaseName = ASPxCBDB.SelectedItem.ToString().Trim();
                // Query to create a databse for "BlankMITA"
                if (ASPxCBDB.SelectedIndex == 1 || ASPxCBDB.SelectedItem.Value.ToString() == "Blank Enterprise")
                {
                    dbCreateQry = "CREATE DATABASE [" + enterpriseName + "] AS COPY OF _blanktemplate";
                }
                //// Query to create a databse for "MITA Assesment"
                else if (ASPxCBDB.SelectedIndex == 2 || ASPxCBDB.SelectedItem.Value.ToString() == "MITA Assessment")
                {
                    dbCreateQry = "CREATE DATABASE [" + enterpriseName + "] AS COPY OF _blankmita";
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "popup", "alert('PLease select the database from the dropdown menu.')", true);
                ASPxCBDB.Focus();
                goto end;
            }
            start_db_again:
            // Creating the database in Azure     olderOne: rcx.database.windows.net
            //_connStr = "Server=tcp:rcx.database.windows.net;Integrated security=SSPI;database=master;User ID=RCXadmin;Password=Rcx12!@ freddy sql;Trusted_Connection=False;Encrypt = True; ";
            _connStr = "Server=tcp:rcxsqldev.database.usgovcloudapi.net;Integrated security=SSPI;database=master;User ID=rcxadmindev;Password=Rcx12!@ freddy sql gov dev;Trusted_Connection=False;Encrypt = True; ";

            // check if database exist in the server
            string dbCheckQry = "select count(*) from sys.databases WHERE name='" + enterpriseName + "'";
            if (CheckUser(_connStr, dbCheckQry))
            {
                ASPxLblStatus.Text = "Database already exist in the server, try with another name."; ASPxTxtEnterprise.Focus();
                aspxLogger.Items.Add("Database already exist in the server, try with another name.");
                goto finish;
            }
            // create database
            if (dbInsert(_connStr, dbCreateQry, 180))
            {
                aspxLogger.Items.Add("New Database created");
            }
            else
            {
                aspxLogger.Items.Add("Failed to create new Database.");
                ASPxLblStatus.Text = "Failed to create new Database.";
                goto end;
            }
            // make the database "read-write" since to avoid "Failed to update database because the database is read-only" exception..
            //string DbUpdateQry = "ALTER DATABASE " + enterpriseName + " SET READ_WRITE WITH NO_WAIT ";
            //if (ExecuteNonQry(_connStr, DbUpdateQry))
            //{ aspxLogger.Items.Add("Successfully alterred the database read-write permissions."); }
            //else
            //{
            //    aspxLogger.Items.Add("Failed to alter the database read-write permissions.");
            //    ASPxLblStatus.Text = "Failed to alter the database read-write permissions.";
            //    goto end;
            //}

            //Checking the connection to the new database 
            //bool dbConnStatus = true;
            if (CheckUser(_connStr, dbCheckQry))
            {
                if (dbConnectivity(common_services.BuildConnString(enterpriseName)))
                    aspxLogger.Items.Add("Connection to new Database verified");
                else
                {
                    aspxLogger.Items.Add("Failed to establish connection to new Database.");
                    ASPxLblStatus.Text = "Failed to establish connection to new Database.";
                    goto end;//dbConnStatus = false; 
                }
            }
            else
            {
                aspxLogger.Items.Add("Database created successfully, but didn't find on rcxsqldev server programatically, please restart the appliation and try it.");
                ASPxLblStatus.Text = "Database created successfully, but didn't find on rcxsqldev server programatically, please restart the appliation and try it.";
                goto end;
            }
            // Create Enterprise record in the table called rc_enterprise in the rcxidentity database.
            insert_again:
            string insert_qry = "insert into rc_enterprise (en_name,en_connstring) values ('" + enterpriseName + "','" + enterpriseName + "')";
            if (dbInsert(common_services.BuildConnString("RCXidentity", true), insert_qry))
                aspxLogger.Items.Add("Added new tribe values into rc_enterprise table..");
            else
            {
                aspxLogger.Items.Add("Failed to add new tribe values into rc_enterprise table..");
                ASPxLblStatus.Text = "Failed to add new tribe values into rc_enterprise table..";
                goto end;
            }

            int userCnt = -1, count = -1;
            createUser_again:
            //getting newly created enterprise ID from rc_enterprise table in rcxidentity DB for newly created DB..
            string select_qry_enid = "select en_id from rc_enterprise where en_name='" + enterpriseName + "'";
            Guid enterprise_id = dbSelectQry(common_services.BuildConnString("RCXidentity", true), select_qry_enid);

            //getting the project ID from rc_projects table that created recently..
            string select_qry_prjid = "select pro_id from rc_projects where pro_name='Sandbox'";
            Guid prj_id = dbSelectQry(common_services.BuildConnString(enterpriseName), select_qry_prjid);

            string status = rc_services.NewUser_enterprise(enterpriseName + "@ehr-llc.com", enterpriseName + "@ehr-llc.com", enterprise_id, prj_id, "", enterpriseName);

            if (status.Equals(string.Empty))
            {
                string chkUserQry = "select count(*) from AspNetUsers where Email='" + enterpriseName + "@ehr-llc.com' and connstring='" + enterpriseName + "'";
                if (CheckUser(common_services.BuildConnString("RCXidentity", true), chkUserQry))  //checks the created user in [AspNetUsers] table of [rcxidentity] database.
                {
                    string deleteuser = "delete from AspNetUsers where Email = '" + enterpriseName + "@ehr-llc.com' and connstring = '" + enterpriseName + "'";
                    if (ExecuteNonQry(common_services.BuildConnString("RCXidentity", true), deleteuser))
                    { count += 1; if (count < 3) { goto createUser_again; } }
                }
                aspxLogger.Items.Add("Failed to create the User..");
                ASPxLblStatus.Text = "Failed to create the User..";
                goto end;
            }
            else
            {
                string chkUserQry = "select count(*) from AspNetUsers where Email='" + enterpriseName + "@ehr-llc.com' and connstring='" + enterpriseName + "'";
                if (CheckUser(common_services.BuildConnString("RCXidentity", true), chkUserQry))  //checks the created user in [AspNetUsers] table of [rcxidentity] database.
                {
                    ASPxLblStatus.Text = "New user created successfully.";
                    ASPxTxtEnterpriseUserName.Text = status.Split(',')[0].ToString().Split(':')[1].ToString().Trim();
                    ASPxTxtEnterpriseUserPwd.Text = status.Split(',')[1].ToString().Split(':')[1].ToString().Trim();
                    aspxLogger.Items.Add(status.Split(',')[0] + " " + status.Split(',')[1]);
                }
                else
                {
                    // if no user created, then do following
                    // 1. check for new databse in server
                    if (CheckUser(_connStr, dbCheckQry))
                    { }
                    else
                    {
                        retry += 1;
                        if (retry < 2) { goto start_db_again; }
                        else { aspxLogger.Items.Add("Failed to create new db, please debug manually.."); ASPxLblStatus.Text = "Failed to create new db, please debug manually.."; }// again starting to create the database..
                    }
                    // 2. check for the inserted row in [rc_enterprise] table of [rcxidentity] database for new database.
                    string chkqry = "select count(*) from rc_enterprise where en_name='" + enterpriseName + "'";
                    if (CheckUser(common_services.BuildConnString("RCXidentity", true), chkqry))
                    { }
                    else
                    {
                        retry += 1;
                        if (retry < 2) { goto insert_again; }
                        else { aspxLogger.Items.Add("Failed to insert new db details in [rc_enterprise] table of [rcxidentity] database, please debug manually.."); ASPxLblStatus.Text = "Failed to insert new db details in [rc_enterprise] table of [rcxidentity] database, please debug manually.."; }// again starting to create the database..
                    }
                    // 3. create new user..
                    if (userCnt < 2)
                    {
                        userCnt += 1;
                        goto createUser_again;
                    }
                    else
                    {
                        ASPxLblStatus.Text = "Failed to create new admin details, please do manually.."; ASPxLblStatus.Text = "Failed to create new admin details, please do manually.."; goto end;
                    }
                }
            }

            //if (dbConnStatus == false && CheckUser(_connStr, dbCheckQry))
            //{
            //    if (dbConnectivity(common_services.BuildConnString(enterpriseName)))
            //        aspxLogger.Items.Add("Connection to new Database verified");
            //    else
            //    {
            //        aspxLogger.Items.Add("Failed to establish connection to new Database.");
            //        ASPxLblStatus.Text = "Failed to establish connection to new Database.";
            //        goto end;
            //    }
            //}

            Guid userid = new Guid(status.Split(',')[2].Split(':')[1].ToString());
            //getting the enterprise role ID from rc_security_enterprise_roles table from the newly created database..
            string select_qry_roleid = "select roles_id from rc_security_enterprise_roles";
            Guid role_id = dbSelectQry(common_services.BuildConnString(enterpriseName), select_qry_roleid);

            // Adding grant select, insert, update, delete permissions to table [rc_security_user_roles_enterprise]
            //string grantQry = "GRANT SELECT, DELETE, INSERT, UPDATE ON rc_security_user_roles_enterprise TO guest";
            //if(ExecuteNonQry(common_services.BuildConnString(enterpriseName), grantQry))
            //{ aspxLogger.Items.Add("Successfully granted permissions to rc_security_user_roles_enterprise table.."); }
            //else
            //{
            //    aspxLogger.Items.Add("Failed to execute grant query");
            //    ASPxLblStatus.Text = "Failed to execute grant query.";
            //    //goto end;
            //}

            int retry_1 = -1;
            role_1:
            //inserting enterprise admin roles in the rc_security_user_roles_enterprise table from the newly created database..
            string insert_qry1 = "insert into rc_security_user_roles_enterprise (entrole_user,entrole_roleID) values ('" + userid + "','" + role_id + "')";
            if (dbInsert(common_services.BuildConnString(enterpriseName), insert_qry1))
            { aspxLogger.Items.Add("Successfully added the roles to the created user.."); ASPxLblStatus.Text = "Successfully created the New Enterprise Admin.."; goto finish; }
            else
            {
                retry_1 += 1; Thread.Sleep(1000);
                if (retry_1 < 3) { aspxLogger.Items.Add("Trying to add roles number:" + retry_1.ToString()); goto role_1; }
                //aspxLogger.Items.Add("The insert query is:" + insert_qry1);
                //aspxLogger.Items.Add("Failed to add the roles to the created user..");
                //ASPxLblStatus.Text = "Failed to add the roles to the created user..";
                goto end1;
            }
            end:
            DeleteActivity(enterpriseName, _connStr); goto finish;
            end1:
            if (TryInsertRoles(enterpriseName))
            { aspxLogger.Items.Add("Successfully added the roles to the created user.."); ASPxLblStatus.Text = "Successfully created the New Enterprise Admin.."; }
            else { DeleteActivity(enterpriseName, _connStr); }
            finish:
            string s = "";
        }

        //Database activities.. 

        // #1 Checking the database connectivity- tries for 10 iterations to avoid annoying exceptions

        public bool dbConnectivity(string connectionStr)
        {
            bool status = false;
            int _count = 0;
            try
            {
                SqlConnection connection = new SqlConnection(connectionStr);
                retry:
                try
                {
                    connection.Open();
                    status = true;
                }
                catch (Exception ex)
                {
                    _count += 1;
                    if (_count < 10)
                    { Thread.Sleep(1000); goto retry; }
                    else
                    {
                        status = false;
                        aspxLogger.Items.Add(ex.Message);
                    }
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }

            }
            catch (Exception ex)
            {
                status = false;
            }
            return status;
        }

        // #2 inserting data into the table  (also used for deleting the database)

        public bool dbInsert(string connectionStr, string queryString, int cmdExecTimeout = 10)
        {
            bool status = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.Text;
                            command.CommandTimeout = cmdExecTimeout;
                            connection.Open();
                            command.ExecuteNonQuery();
                            status = true;
                        }
                        catch (Exception ex)
                        {
                            status = false;
                            aspxLogger.Items.Add(ex.Message);
                            ASPxLblStatus.Text = ex.Message;
                            // throw;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                status = false;
            }
            return status;
        }

        // #3 select query 

        public Guid dbSelectQry(string connection, string queryStr)
        {
            Guid guid = Guid.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    using (SqlCommand command = new SqlCommand(queryStr, conn))
                    {
                        try
                        {
                            command.CommandType = CommandType.Text;
                            conn.Open();
                            SqlDataReader dr = command.ExecuteReader();
                            if (dr.HasRows && dr.Read())
                            {
                                guid = (Guid)dr[0];
                            }
                        }
                        catch (Exception ex)
                        {
                            aspxLogger.Items.Add(ex.Message);
                            ASPxLblStatus.Text = ex.Message;
                        }
                        finally
                        {
                            if (conn.State == ConnectionState.Open)
                                conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //throw;
            }
            return guid;
        }

        // #4 User existence check using select query

        public bool CheckUser(string connection, string queryStr)
        {
            bool status = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    using (SqlCommand command = new SqlCommand(queryStr, conn))
                    {
                        try
                        {
                            command.CommandType = CommandType.Text;
                            conn.Open();
                            int count = (int)command.ExecuteScalar();
                            if (count > 0)
                                status = true;
                        }
                        catch (Exception ex)
                        {
                            aspxLogger.Items.Add(ex.Message);
                            ASPxLblStatus.Text = ex.Message;
                        }
                        finally
                        {
                            if (conn.State == ConnectionState.Open)
                                conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //throw;
            }
            return status;
        }

        //#5 Delete query (for database and rows in any tables)

        public bool dbDelete(string connection, string queryStr)
        {
            bool status = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    using (SqlCommand command = new SqlCommand(queryStr, conn))
                    {
                        try
                        {
                            command.CommandType = CommandType.Text;
                            conn.Open();
                            int count = (int)command.ExecuteScalar();
                            if (count > 0)
                                status = true;
                        }
                        catch (Exception ex)
                        {
                            aspxLogger.Items.Add(ex.Message);
                            ASPxLblStatus.Text = ex.Message;
                        }
                        finally
                        {
                            if (conn.State == ConnectionState.Open)
                                conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //throw;
            }
            return status;
        }
        // #6 drop the database
        public bool ExecuteNonQry(string connectionStr, string queryString)
        {
            bool status = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.Text;
                            //command.CommandTimeout = cmdExecTimeout;
                            connection.Open();
                            command.ExecuteNonQuery();
                            status = true;
                        }
                        catch (Exception ex)
                        {
                            status = false;
                            aspxLogger.Items.Add(ex.Message);
                            ASPxLblStatus.Text = ex.Message;
                            // throw;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                status = false;
            }
            return status;
        }

        // #7 actions if no user created for newly created databse.. (not in use right now)

        public bool DeleteActivity(string dbName, string cloudConnStr)
        {
            bool status = false;
            try
            {
                // #1 delete the new database created right now..
                int test = -1;
                try_again:
                string dbDropQry = "drop database " + dbName;
                if (ExecuteNonQry(cloudConnStr, dbDropQry))
                {
                    aspxLogger.Items.Add("Database dropped successfully.."); status = true;
                }
                else
                {
                    test += 1;
                    if (test < 3) { goto try_again; } else { status = false; aspxLogger.Items.Add("Failed to drop the database, try manually.."); goto end; }
                }
                test = -1;
                // #2 delete the inserted row in [rc_enterprise] table of [rcxidentity] database. 

                string checkdbdata = "select count(*) from rc_enterprise where en_name='" + dbName + "'";
                if (CheckUser(common_services.BuildConnString("RCXidentity", true), checkdbdata))
                {
                    try_again_1:
                    string dbrowdeleteQry = "delete from rc_enterprise where en_name='" + dbName + "'";
                    if (ExecuteNonQry(common_services.BuildConnString("RCXidentity", true), dbrowdeleteQry))
                    {
                        aspxLogger.Items.Add("Deteleted new database details in [rc_enterprise] table of [rcxidentity] database"); status = true;
                    }
                    else
                    {
                        test += 1;
                        if (test < 3) { goto try_again_1; } else { status = false; aspxLogger.Items.Add("Failed to delete new database details in [rc_enterprise] table of [rcxidentity] database, try manually.."); goto end; }
                    }
                }
                // #3 remove user if created
                string checkuser = "select count(*) from AspNetUsers where Email='" + dbName + "@ehr-llc.com'";
                if (CheckUser(common_services.BuildConnString("RCXidentity", true), checkuser))
                {
                    try_again_2:
                    string qry = "delete from AspNetUsers where Email='" + dbName + "@ehr-llc.com'";
                    if (ExecuteNonQry(common_services.BuildConnString("RCXidentity", true), qry))
                    {
                        aspxLogger.Items.Add("Deteleted new user details in [AspNetUsers] table of [rcxidentity] database"); status = true;
                    }
                    else
                    {
                        test += 1;
                        if (test < 3) { goto try_again_2; } else { status = false; aspxLogger.Items.Add("Failed to delete new user details in [AspNetUsers] table of [rcxidentity] database, try manually.."); goto end; }
                    }
                }
                end:
                ASPxTxtEnterpriseUserName.Text = "";
                ASPxTxtEnterpriseUserPwd.Text = "";
                string s = "";
            }
            catch (Exception ex)
            {
                //throw;
            }
            return status;
        }

        //checking the roles at the end
        public bool TryInsertRoles(string enterpriseName)
        {
            bool status = false;
            try
            {
                // getting the userid from Aspnetusers table
                string chkUserQry = "select Id from AspNetUsers where Email='" + enterpriseName + "@ehr-llc.com' and connstring='" + enterpriseName + "'";
                Guid userid = dbSelectQry(common_services.BuildConnString("RCXidentity", true), chkUserQry);

                //getting the enterprise role ID from rc_security_enterprise_roles table from the newly created database..
                string select_qry_roleid = "select roles_id from rc_security_enterprise_roles";
                Guid role_id = dbSelectQry(common_services.BuildConnString(enterpriseName), select_qry_roleid);

                int retry_1 = -1;
                role_1:
                //inserting enterprise admin roles in the rc_security_user_roles_enterprise table from the newly created database..
                string insert_qry1 = "insert into rc_security_user_roles_enterprise (entrole_user,entrole_roleID) values ('" + userid + "','" + role_id + "')";
                if (dbInsert(common_services.BuildConnString(enterpriseName), insert_qry1))
                { //aspxLogger.Items.Add("Successfully added the roles to the created user.."); ASPxLblStatus.Text = "Successfully created the New Enterprise Admin.."; 
                    status = true;
                }
                else
                {
                    retry_1 += 1; Thread.Sleep(1000);
                    if (retry_1 < 3) { aspxLogger.Items.Add("Trying to add roles number:" + retry_1.ToString()); goto role_1; }
                    //aspxLogger.Items.Add("The insert query is:" + insert_qry1);
                    aspxLogger.Items.Add("Failed to add the roles to the created user..");
                    ASPxLblStatus.Text = "Failed to add the roles to the created user..";
                    status = false;
                }
            }
            catch (Exception ex)
            {
                aspxLogger.Items.Add(ex.Message);
            }
            return status;
        }

        // checks the login with the newly created username and password..
        protected void ASPxBtnCheck_Click(object sender, EventArgs e)
        {
            Response.Redirect("Account/Login.aspx");
        }
        // Helps to move Userhome page of admin..
        protected void ASPxBtnUserHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("rc_project/userhome.aspx");
        }

        protected void ASPxBtnClearAll_Click(object sender, EventArgs e)
        {
            ASPxLblStatus.Text = "Status:";
            ASPxCBDB.SelectedIndex = 0;
            ASPxTxtEnterprise.Text = "";
            ASPxTxtEnterpriseUserName.Text = "";
            ASPxTxtEnterpriseUserPwd.Text = "";
            aspxLogger.Items.Clear();
        }
    }
}

