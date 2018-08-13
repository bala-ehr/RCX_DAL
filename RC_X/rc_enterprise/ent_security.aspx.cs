using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.rc_enterprise
{
    public partial class ent_security : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!rc_services.CheckPermission("ent_security")) { Response.Redirect("~/controls/unauthorized.aspx"); }


            sqlRolesDropDown.ConnectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            sqlProjectRoles.ConnectionString= System.Web.HttpContext.Current.Session["userConnString"].ToString();
            sqlUserProjects.ConnectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            sqlEnterpriseRoles.ConnectionString= System.Web.HttpContext.Current.Session["userConnString"].ToString();
            sqlEnterpriseRolesDropDown.ConnectionString= System.Web.HttpContext.Current.Session["userConnString"].ToString();
            sqlEnterpriseRoleAssigner.ConnectionString= System.Web.HttpContext.Current.Session["userConnString"].ToString();
            sqlProjectRoleAssigner.ConnectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            sqlProjects.ConnectionString= System.Web.HttpContext.Current.Session["userConnString"].ToString();
            rc_services.FillEnterpriseUserRoles();
            rc_services.FillProjectUserRoles();
            BindDropdown();
           
            //ddlProjects.SelectedItem.Value.ToString()
               

            RCuserList UserList = rc_services.GetUsers();
            DataTable EnterpriseUsers = UserList.GetUserTable();

            gridUsers.DataSource = EnterpriseUsers;
            gridUsers.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           

            gridUsers.Columns[0].Visible = rc_services.CheckPermission("ent_security_users");

            GridViewDataColumn c = gridEnterpriseRoles.Columns["Role"] as GridViewDataColumn;
            c.ReadOnly = !rc_services.CheckPermission("ent_security_roles");

            gridEnterpriseLevelRoles.Columns[0].Visible = rc_services.CheckPermission("ent_security_roles");

            GridViewDataColumn entcc = gridProjectRoles.Columns["Role"] as GridViewDataColumn;
            c.ReadOnly = !rc_services.CheckPermission("ent_security_roles");

            gridProjectLevelRoles.Columns[0].Visible = rc_services.CheckPermission("ent_security_roles");
        }

        public void BindDropdown()
        {
            //ddlProjects.DataSource = common_services.GetProjects();
     
            sqlEnterpriseRolesDropDown.Select(DataSourceSelectArguments.Empty);
            sqlRolesDropDown.Select(DataSourceSelectArguments.Empty);
            sqlEnterpriseRolesDropDown.DataBind();
            sqlRolesDropDown.DataBind();

            gvUsersStatistics.DataSource = rc_services.GetUserStatistics();
            gvUsersStatistics.DataBind();


            gridEnterpriseLevelRoles.DataBind();
            gridProjectLevelRoles.DataBind();
            //gridProjectRoles.DataBind();
            gridEnterpriseRoles.DataBind();
            ddlProjects.DataBind();
            //ddlProjects.SelectedIndex = 0;
            if (ddlProjects.SelectedIndex == -1)
            {
                ddlProjects.SelectedItem = ddlProjects.Items.FindByValue(Session["projectID"]);
            }
        }

        protected void gridEnterpriseRolePermissions_Init(object sender, EventArgs e)
        {
            ASPxGridView gridEnterpriseRolePermissions = (ASPxGridView)sender;
            GridViewDataColumn c = gridEnterpriseRolePermissions.Columns["Authorized"] as GridViewDataColumn;
            c.ReadOnly = !rc_services.CheckPermission("ent_security_roles");
        }
        protected void gridRolePermissions_Init(object sender, EventArgs e)
        {
            ASPxGridView gridRolePermissions = (ASPxGridView)sender;
            GridViewDataColumn c = gridRolePermissions.Columns["Authorized"] as GridViewDataColumn;
            c.ReadOnly = !rc_services.CheckPermission("ent_security_roles");
        }

        protected void gridUsers_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            Guid DefaultProject;
            ///// TODO fix Change from static project and enterprise to proper guid value

            string UserName = (string)e.NewValues[0];
            string Email = (string)e.NewValues[0];
            string PhoneNumber = (string)e.NewValues[1];
            if (e.NewValues[2] == null) { DefaultProject = Guid.Parse(Session["projectID"].ToString()); }
            else { DefaultProject = Guid.Parse(e.NewValues[2].ToString()); }
            string ConnString = (string)Session["UserConnString"];

            UserName.Trim();
            Email.Trim();

            string result = rc_services.NewUser(Email, UserName, (Guid)Session["enterpriseID"], DefaultProject, PhoneNumber, ConnString, Page.Request);
            
            e.Cancel = true;
            gridUsers.CancelEdit();
            gridUsers.DataBind();
            BindDropdown();
        }     

        protected void gridProjectLevelRoles_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
        {
            if (e.Expanded == true)
            {
                Guid xRoleID = (Guid)gridProjectLevelRoles.GetRowValues(e.VisibleIndex, "roles_id");
                rc_services.FillProjectRolePermissions(xRoleID);
            }            
        }

        protected void gridEnterpriseLevelRoles_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
        {
            if (e.Expanded == true)
            {
                Guid xRoleID = (Guid)gridEnterpriseLevelRoles.GetRowValues(e.VisibleIndex, "roles_id");
                rc_services.FillEnterpriseRolePermissions(xRoleID);
            }
        }


        protected void ddlProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            rc_services.FillProjectUserRoles();
            
            BindDropdown();
            //gridProjectRoles.DataSource = rc_services.GetProjectUserRoles(Guid.Parse(ddlProjects.SelectedItem.Value.ToString()));
            //gridProjectRoles.DataBind();
        }

        protected void gridProjectRoles_BatchUpdate(object sender, DevExpress.Web.Data.ASPxDataBatchUpdateEventArgs e)
        {
            foreach (var item in e.UpdateValues)
            {
                //e.UpdateValues
            }

            //ProjectUserRoleList NewRoles = new ProjectUserRoleList();
            //foreach (var item in e.UpdateValues)
            //{
            //    NewRoles.Add(new ProjectUserRole
            //    {
            //        Id = Guid.Parse(item.Keys[0].ToString()),
            //        UserID = Guid.Parse(gridProjectRoles.GetRowValuesByKeyValue(item.Keys[0].ToString(), "UserID").ToString()),  
            //        RoleID = Guid.Parse(item.NewValues[0].ToString()),
            //        ProjectID = Guid.Parse(ddlProjects.SelectedItem.Value.ToString())
            //    });
            //}
            //string result = rc_services.UpdateProjectUserRoles(NewRoles);

            //if (result == "1")
            //{
            //    e.Handled = true;             
            //}
            ////gridProjectRoles.CancelEdit();
            //gridProjectRoles.DataSource = rc_services.GetProjectUserRoles(Guid.Parse(ddlProjects.SelectedItem.Value.ToString()));
            //gridProjectRoles.DataBind();
        }

        //protected void gridEnterpriseRoles_BatchUpdate(object sender, DevExpress.Web.Data.ASPxDataBatchUpdateEventArgs e)
        //{
        //    ProjectUserRoleList NewRoles = new ProjectUserRoleList();
        //    foreach (var item in e.UpdateValues)
        //    {
        //        NewRoles.Add(new ProjectUserRole
        //        {
        //            Id = Guid.Parse(item.Keys[0].ToString()),
        //            UserID = Guid.Parse(gridEnterpriseRoles.GetRowValuesByKeyValue(item.Keys[0].ToString(), "UserID").ToString()),
        //            RoleID = Guid.Parse(item.NewValues[0].ToString())
        //        });
        //    }
        //    string result = rc_services.UpdateEnterpriseUserRoles(NewRoles);

        //    if (result == "1")
        //    {
        //        e.Handled = true;
        //    }

        //    gridEnterpriseRoles.DataSource = rc_services.GetEnterpriseUserRoles();           
        //    gridEnterpriseRoles.DataBind();
        //}



        protected void sqlDefinitions_DataBinding(object sender, EventArgs e)
        {
            SqlDataSource sqlDefinitions = (SqlDataSource)sender;
            sqlDefinitions.ConnectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
        }



        protected void gridUsers_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            Guid UserID = Guid.Parse(e.Keys[0].ToString());
            string delEted = rc_services.DeleteUser(UserID);

            e.Cancel = true;
            gridUsers.DataBind();
        }

        
    }
}