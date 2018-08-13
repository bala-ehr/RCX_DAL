using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace RC_X.controls
{
    /*  This class deals with all the database activities..
     *  1. Connecton establishment and disconnection with the database.
     *  2. Inserting data into databse.
     *  3. selecting, updating, deleting the data.
     */
    public static class DAL_RCServices
    {
        static SqlConnection _SqlConnection = null;
        static SqlCommand _SqlCommand = null;
        static SqlDataAdapter _SqlDataAdapter = null;
        static SqlDataReader _SqlDataReader = null;

        /*Retriving the database connection parameters from web.config file*/
        public static string GetdbConnectionString(string connStrName = null)
        {
            string _connStr = string.Empty;
            try
            {
                if (connStrName.ToString() == string.Empty || connStrName.ToString() == null)
                { _connStr = null; }
                else
                {
                    _connStr = ConfigurationManager.ConnectionStrings[connStrName.Trim()].ToString();
                }
            }
            catch (Exception)
            {
                //throw;
            }
            return _connStr;
        }

        /*Build database connection string */
        public static string BuildConnString(string EnterpriseDB, bool IsIdentityDB = false)
        {

            ConnectionStringSettings ConnString = ConfigurationManager.ConnectionStrings["TemplateConnString"];
            string connectString = ConnString.ConnectionString;

            if (null != ConnString)
            {
                // Retrieve the partial connection string.
                // Create a new SqlConnectionStringBuilder based on the
                // partial connection string retrieved from the config file.
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);

                // Supply the additional values.
                builder.DataSource = ConfigurationManager.AppSettings["DataSource"];
                builder.UserID = ConfigurationManager.AppSettings["DataUser"];
                builder.Password = ConfigurationManager.AppSettings["DataPass"];
                if (IsIdentityDB == false) { builder.InitialCatalog = EnterpriseDB; } else { builder.InitialCatalog = ConfigurationManager.AppSettings["IdentityCatalog"]; }

                connectString = builder.ConnectionString;
            }
            return connectString;
        }

        /* Establishing/verifying the connection status with the database */
        public static bool ConnectDB(string dbConnStr)
        {
            bool connStatus = false;
            try
            {
                if (dbConnStr == string.Empty || dbConnStr == null)
                { connStatus = false; }
                else
                {
                    _SqlConnection = new SqlConnection();
                    _SqlConnection.ConnectionString = dbConnStr;
                    _SqlConnection.Open();
                    connStatus = true;
                }
            }
            catch (Exception)
            {
                //throw;
            }
            return connStatus;
        }
        /* Disconnecting/flushing the database connection */
        public static bool DisconnectDB()
        {
            bool connStatus = false;
            try
            {
                if (_SqlConnection.State == System.Data.ConnectionState.Open)
                { _SqlConnection.Close(); connStatus = true; }
            }
            catch (Exception)
            {
                //throw;
            }
            finally
            {

            }
            return connStatus;
        }

        #region ExecuteNonQueryFunctions
        /* ExecuteNonQuery function */
        // For insert, update, delete and drop command executions..
        public static bool ExecuteNonQuery(string DBconnStr, List<string> paramDict)
        {
            bool status = false;
            int count = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBconnStr))
                {
                    using (SqlCommand command = new SqlCommand(paramDict[0].ToString(), connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            foreach (var item in paramDict)
                            {
                                if (item.Contains(";"))
                                {
                                    if (item.Split(';')[2].ToString() == "SqlDbType.UniqueIdentifier")
                                    {
                                        command.Parameters.Add(item.Split(';')[0].ToString(), SqlDbType.UniqueIdentifier).Value = Guid.Parse(item.Split(';')[1].ToString());
                                        //command.Parameters.AddWithValue(item.Split(';')[0].ToString(), item.Split(';')[1].ToString());
                                    }
                                    else if (item.Split(';')[2].ToString() == "string")
                                    {
                                        command.Parameters.AddWithValue(item.Split(';')[0].ToString(), item.Split(';')[1].ToString());
                                    }
                                    else if (item.Split(';')[2].ToString() == "DBNull")
                                    {
                                        command.Parameters.AddWithValue(item.Split(';')[0].ToString(), DBNull.Value);
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue(item.Split(';')[0].ToString(), item.Split(';')[1]);
                                    }
                                }
                            }
                            connection.Open();
                            count = command.ExecuteNonQuery();
                            if (count > 0)
                                status = true;
                        }
                        catch (Exception)
                        {
                            //throw;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }

            return status;
        }

        public static int ExecuteNonQuery_Transaction(string DBconnStr, List<string> paramDict)
        {
            int returnVal = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBconnStr))
                {
                    using (SqlCommand command = new SqlCommand(paramDict[0].ToString(), connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            foreach (var item in paramDict)
                            {
                                if (item.Contains(";"))
                                {
                                    if (item.Split(';')[2].ToString() == "SqlDbType.UniqueIdentifier")
                                    {
                                        command.Parameters.Add(item.Split(';')[0].ToString(), SqlDbType.UniqueIdentifier).Value = Guid.Parse(item.Split(';')[1].ToString());
                                        //command.Parameters.AddWithValue(item.Split(';')[0].ToString(), item.Split(';')[1].ToString());
                                    }
                                    else if (item.Split(';')[2].ToString() == "string")
                                    {
                                        command.Parameters.AddWithValue(item.Split(';')[0].ToString(), item.Split(';')[1].ToString());
                                    }
                                    else if (item.Split(';')[2].ToString() == "DBNull")
                                    {
                                        command.Parameters.AddWithValue(item.Split(';')[0].ToString(), DBNull.Value);
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue(item.Split(';')[0].ToString(), item.Split(';')[1]);
                                    }
                                }
                            }
                            connection.Open();
                            SqlTransaction transaction = connection.BeginTransaction();
                            int returnVal1 = command.ExecuteNonQuery();
                            if (returnVal1 > 0)
                            {
                                returnVal = returnVal1;
                                transaction.Commit();
                            }
                        }
                        catch (Exception)
                        {
                            //throw;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
            return returnVal;
        }
        #endregion

        #region ScalarFunctions
        /* ExecuteScalar functions */
        //#1 for executing count function - returns Int32 (no.of rows affected)
        public static Int32 ExecuteScalar_count(string DBconnStr, string DBqueryStr)
        {
            Int32 count = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBconnStr))
                {
                    using (SqlCommand command = new SqlCommand(DBqueryStr, connection))
                    {
                        try
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            connection.Open();
                            count = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception)
                        {
                            //throw;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                        }

                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
            return count;
        }
        //#2 for returning first value in the result set (first cell value)
        public static object ExecuteScalar_object(string DBconnStr, string DBqueryStr)
        {
            object obj_value = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBconnStr))
                {
                    using (SqlCommand command = new SqlCommand(DBqueryStr, connection))
                    {
                        try
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            connection.Open();
                            obj_value = command.ExecuteScalar();
                        }
                        catch (Exception)
                        {
                            //throw;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                        }

                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
            return obj_value;
        }

        #endregion

        #region ExecuteAdapterFunctions
        // Executes the data adapter functions and returns dataset object with plain query execution..
        public static DataSet ExecuteAdapter_dataset(string DBconnStr, string DBqueryStr)
        {
            DataSet _dataSet = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBconnStr))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(DBqueryStr, DBconnStr))
                    {
                        try
                        {
                            connection.Open();
                            _dataSet = new DataSet();
                            adapter.Fill(_dataSet);
                        }
                        catch (Exception)
                        {
                            //throw;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return _dataSet;
        }
        //Execute the data adapter using SP with dataset return..
        public static DataSet ExecuteAdapter_SP_dataset(string DBconnStr, List<string> paramDict)
        {
            DataSet _dataSet = null;
            SqlDataAdapter adapter;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBconnStr))
                {
                    using (SqlCommand cmd = new SqlCommand(paramDict[0].ToString(), connection))
                    {
                        try
                        {
                            adapter = new SqlDataAdapter(cmd);
                            cmd.CommandType = CommandType.StoredProcedure;
                            foreach (var item in paramDict)
                            {
                                if (item.Contains(";"))
                                {
                                    cmd.Parameters.AddWithValue(item.Split(';')[0].ToString(), item.Split(';')[1].ToString());
                                }
                            }
                            connection.Open();
                            _dataSet = new DataSet();
                            adapter.Fill(_dataSet);
                        }
                        catch (Exception ex)
                        {
                            //throw;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
            return _dataSet;
        }
        #endregion

        #region ExecuteReaderFunctions
        // returns the list objects --  need to implement
        public static List<ReaderOutputs> ExecuteReader(string DBconnStr, List<string> paramDict, int outputCount, List<string> outputVars)
        {
            List<ReaderOutputs> reader_outputs = new List<ReaderOutputs>();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBconnStr))
                {
                    using (SqlCommand command = new SqlCommand(paramDict[0].ToString(), connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            foreach (var item in paramDict)
                            {
                                if (item.Contains(";"))
                                {
                                    if (item.Split(';')[2].ToString() == "SqlDbType.UniqueIdentifier")
                                    {
                                        command.Parameters.Add(item.Split(';')[0].ToString(), SqlDbType.UniqueIdentifier).Value = Guid.Parse(item.Split(';')[1].ToString());
                                        //command.Parameters.AddWithValue(item.Split(';')[0].ToString(), item.Split(';')[1].ToString());
                                    }
                                    else if (item.Split(';')[2].ToString() == "string")
                                    {
                                        command.Parameters.AddWithValue(item.Split(';')[0].ToString(), item.Split(';')[1].ToString());
                                    }
                                    else if (item.Split(';')[2].ToString() == "DBNull")
                                    {
                                        command.Parameters.AddWithValue(item.Split(';')[0].ToString(), DBNull.Value);
                                    }
                                    else if (item.Split(';')[2].ToString() == "Guid")
                                    {
                                        command.Parameters.AddWithValue(item.Split(';')[0].ToString(), Guid.Parse(item.Split(';')[1]));
                                    }
                                    else if (item.Split(';')[2].ToString() == "DateTime") // need to check in the stored procedure..
                                    {

                                    }
                                    else if (item.Split(';')[2].ToString() == "Structured")
                                    {
                                        command.Parameters.Add(item.Split(';')[0].ToString(), SqlDbType.Structured).Value = item.Split(';')[1];
                                    }
                                }
                            }
                            connection.Open();
                            using (SqlDataReader _datareader = command.ExecuteReader())
                            {
                                if (_datareader.HasRows)
                                {
                                    while (_datareader.Read())
                                    {
                                        if (outputCount == 3)
                                        {
                                            reader_outputs.Add(new ReaderOutputs
                                            {
                                                out1 = _datareader[outputVars[0].ToString()].ToString(),
                                                out2 = _datareader[outputVars[1].ToString()].ToString(),
                                                out3 = _datareader[outputVars[2].ToString()].ToString(),
                                            });
                                        }
                                        if (outputCount == 5)
                                        {
                                            reader_outputs.Add(new ReaderOutputs
                                            {
                                                out1 = _datareader[outputVars[0].ToString()].ToString(),
                                                out2 = _datareader[outputVars[1].ToString()].ToString(),
                                                out3 = _datareader[outputVars[2].ToString()].ToString(),
                                                out4 = _datareader[outputVars[3].ToString()].ToString(),
                                                out5 = _datareader[outputVars[4].ToString()].ToString(),
                                            });
                                        }
                                        if (outputCount == 7)
                                        {
                                            reader_outputs.Add(new ReaderOutputs
                                            {
                                                out1 = _datareader[outputVars[0].ToString()].ToString(),
                                                out2 = _datareader[outputVars[1].ToString()].ToString(),
                                                out3 = _datareader[outputVars[2].ToString()].ToString(),
                                                out4 = _datareader[outputVars[3].ToString()].ToString(),
                                                out5 = _datareader[outputVars[4].ToString()].ToString(),
                                                out6 = _datareader[outputVars[5].ToString()].ToString(),
                                                out7 = _datareader[outputVars[6].ToString()].ToString(),
                                            });
                                        }
                                        if (outputCount == 8)
                                        {
                                            reader_outputs.Add(new ReaderOutputs
                                            {
                                                out1 = _datareader[outputVars[0].ToString()].ToString(),
                                                out2 = _datareader[outputVars[1].ToString()].ToString(),
                                                out3 = _datareader[outputVars[2].ToString()].ToString(),
                                                out4 = _datareader[outputVars[3].ToString()].ToString(),
                                                out5 = _datareader[outputVars[4].ToString()].ToString(),
                                                out6 = _datareader[outputVars[5].ToString()].ToString(),
                                                out7 = _datareader[outputVars[6].ToString()].ToString(),
                                                out8 = _datareader[outputVars[7].ToString()].ToString(),
                                            });
                                        }
                                        if (outputCount == 14)
                                        {
                                            reader_outputs.Add(new ReaderOutputs
                                            {
                                                out1 = _datareader[outputVars[0].ToString()].ToString(),
                                                out2 = _datareader[outputVars[1].ToString()].ToString(),
                                                out3 = _datareader[outputVars[2].ToString()].ToString(),
                                                out4 = _datareader[outputVars[3].ToString()].ToString(),
                                                out5 = _datareader[outputVars[4].ToString()].ToString(),
                                                out6 = _datareader[outputVars[5].ToString()].ToString(),
                                                out7 = _datareader[outputVars[6].ToString()].ToString(),
                                                out8 = _datareader[outputVars[7].ToString()].ToString(),
                                                out9 = _datareader[outputVars[8].ToString()].ToString(),
                                                out10 = _datareader[outputVars[9].ToString()].ToString(),
                                                out11 = _datareader[outputVars[10].ToString()].ToString(),
                                                out12 = _datareader[outputVars[11].ToString()].ToString(),
                                                out13 = _datareader[outputVars[12].ToString()].ToString(),
                                                out14 = _datareader[outputVars[13].ToString()].ToString(),
                                            });
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                            //throw;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                            _SqlDataReader.Close();
                        }

                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
            return reader_outputs;
        }

        // data reader function that returns the single string value..
        public static string ExecuteReader_SP_string(string DBconnStr, List<string> paramDict)
        {
            string returnValue = string.Empty;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBconnStr))
                {
                    using (SqlCommand command = new SqlCommand(paramDict[0].ToString(), connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            foreach (var item in paramDict)
                            {
                                if (item.Contains(";"))
                                {
                                    command.Parameters.AddWithValue(item.Split(';')[0].ToString(), item.Split(';')[1].ToString());
                                }
                            }
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        returnValue = reader[0].ToString(); 
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            //throw;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
            return returnValue;
        }
        //populate the datareader output into dataset when db query as Stored Procedure..
        public static DataSet ExecuteReader_SP_dataset(string DBconnStr, List<string> paramDict)
        {
            DataSet _dataset = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBconnStr))
                {
                    using (SqlCommand command = new SqlCommand(paramDict[0].ToString(), connection))
                    {
                        try
                        {
                            //_dataset = new DataSet();
                            command.CommandType = CommandType.StoredProcedure;
                            foreach (var item in paramDict)
                            {
                                if (item.Contains(";"))
                                {
                                    command.Parameters.AddWithValue(item.Split(';')[0].ToString(), item.Split(';')[1].ToString());
                                }
                            }
                            connection.Open();
                            using (SqlDataReader _datareader = command.ExecuteReader())
                            {
                                if (_datareader.HasRows)
                                {
                                    //string testStr = _datareader["lib_title"].ToString();
                                    _dataset = new DataSet();
                                    DataTable _datatable = new DataTable();
                                    _datatable.Load(_datareader);
                                    _dataset.Tables.Add(_datatable);
                                    //_dataset.Tables[0].Load(_datareader);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            //throw;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                            _dataset = null;

                        }

                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
            return _dataset;
        }

        #endregion

        #region AddingParametersToSP
        //Not yet used, under development..
        // send the dictionary with the key names as column names in table and values as parameters
        public static SqlCommand AddparametersToSP(SqlCommand cmd, Dictionary<string, string> mydict)
        {
            SqlCommand _command = cmd;
            int dictlength = mydict.Count;
            if (dictlength > 0)
            {
                _command.CommandType = CommandType.StoredProcedure;
                foreach (KeyValuePair<string, string> keyVal in mydict)
                    _command.Parameters.AddWithValue(keyVal.Key.ToString(), keyVal.Value.ToString());
            }
            return _command;

        }
        #endregion      
    }

    public class ReaderOutputs
    {
        public string out1 { get; set; }
        public string out2 { get; set; }
        public string out3 { get; set; }
        public string out4 { get; set; }
        public string out5 { get; set; }
        public string out6 { get; set; }
        public string out7 { get; set; }
        public string out8 { get; set; }
        public string out9 { get; set; }
        public string out10 { get; set; }
        public string out11 { get; set; }
        public string out12 { get; set; }
        public string out13 { get; set; }
        public string out14 { get; set; }
        public string out15 { get; set; }
    }
}