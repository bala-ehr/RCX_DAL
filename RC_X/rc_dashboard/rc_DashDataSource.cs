using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Native;
using DevExpress.DataAccess.Web;
using System.Configuration;
using System.Data.SqlClient;
// ...

public class MyDataSourceWizardConnectionStringsProvider : IDataSourceWizardConnectionStringsProvider
{
    public Dictionary<string, string> GetConnectionDescriptions()
    {
        Dictionary<string, string> connections = new Dictionary<string, string>();

        // Customize the loaded connections list.  
        //connections.Remove("LocalSqlServer");
        connections.Add("ReadyCert", "ReadyCert Data Source");
       
        //connections.Add("msSqlConnection", "MS SQL Connection");
        return connections;
    }

    public DataConnectionParametersBase GetDataConnectionParameters(string name)
    {


       string UserConnString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
        // Create a new SqlConnectionStringBuilder based on the
        // partial connection string retrieved from the config file.
        SqlConnectionStringBuilder builder =  new SqlConnectionStringBuilder(UserConnString);

        string DBname = builder.InitialCatalog;
        string Password = builder.Password;
        string UserName = builder.UserID;
        //Get individual datasource parts to get user's enterprise connetcion string


        // Return custom connection parameters for the custom connection.
        switch (name)
        {
            case "ReadyCert":
                //return new
                return new MsSqlConnectionParameters("rcx.database.windows.net", DBname, UserName, Password, MsSqlAuthorizationType.SqlServer);

       
        }
      
        return AppConfigHelper.LoadConnectionParameters(name);
    }
}

