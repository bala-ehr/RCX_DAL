using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RC_X
{
    public class EventLogger
    {
        static SqlConnection con;
        private static void connection()
        {
            string constr = HttpContext.Current.Session["userConnString"].ToString();
            con = new SqlConnection(constr);
            con.Open();
        }

        public static void Log(string strEvent, string Notes = null)
        {
            if (HttpContext.Current.Session["userConnString"] != null)
            {
                connection();
                var CurrentProjectId = System.Web.HttpContext.Current.Session["projectID"].ToString();
                var user = HttpContext.Current.Session["UserEmail"].ToString();
                var ip = GetIPAddress();

                SqlCommand com = new SqlCommand("sp_rc_InsertUserStatistics", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@UserName", user);
                com.Parameters.AddWithValue("@ProjectId", CurrentProjectId);
                com.Parameters.AddWithValue("@EventName", strEvent);
                com.Parameters.AddWithValue("@IPAdress", ip);
                com.Parameters.AddWithValue("@EventTime", DateTime.Now);
                com.Parameters.AddWithValue("@Notes", Notes);
                com.ExecuteNonQuery();

                con.Close();
            }
        }

        private static string GetIPAddress()
        {
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }
            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
    }
}