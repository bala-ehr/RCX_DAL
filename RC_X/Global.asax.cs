using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Security;
    using System.Web.SessionState;
    using DevExpress.Web;
using DevExpress.DashboardWeb;
using DevExpress.XtraReports.Security;

namespace RC_X {
        public class Global_asax : System.Web.HttpApplication {
            void Application_Start(object sender, EventArgs e)
        {
                DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(Application_Error);
          
                AccountManager.RegisterAzure("FileManagerAzureAccount", "rcxstorage", "Rxyn6Kgt/uloudxg2u8Y4g5q9FnFKt8KWPr3uBmNPWZvfTt9oKlkcQRkifI/zo2oQdvG77Iqcov+w/bNrmAcfw==");
                AccountManager.RegisterAzure("UploadAzureAccount", "rcxstorage", "Rxyn6Kgt/uloudxg2u8Y4g5q9FnFKt8KWPr3uBmNPWZvfTt9oKlkcQRkifI/zo2oQdvG77Iqcov+w/bNrmAcfw==");
                DevExpress.Utils.AzureCompatibility.Enable = true;

            DevExpress.Utils.AzureCompatibility.Enable = true;
            ScriptPermissionManager.GlobalInstance = new ScriptPermissionManager(ExecutionMode.Unrestricted);


            ///FOr Dashboards
         //   DashboardConfigurator.Default.SetConnectionStringsProvider(new MyDataSourceWizardConnectionStringsProvider());

        }

            void Application_End(object sender, EventArgs e) {
                // Code that runs on application shutdown
            }

            void Application_Error(object sender, EventArgs e) {
            // Code that runs when an unhandled error occursS
            //Exception error = Server.GetLastError();

            
            }

            void Session_Start(object sender, EventArgs e) {
                // Code that runs when a new session is started
            }

            void Session_End(object sender, EventArgs e) {
                // Code that runs when a session ends. 
                // Note: The Session_End event is raised only when the sessionstate mode
                // is set to InProc in the Web.config file. If session mode is set to StateServer 
                // or SQLServer, the event is not raised.
            }
        }
    }