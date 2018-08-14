using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using RC_X.Models;
using System.Data;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Configuration;
using DevExpress.Web;

namespace RC_X {
    public partial class Login : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void SendEmailConfirmationToken(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = manager.FindByName(tbUserName.Text);
            if (user != null)
            {
                if (!user.EmailConfirmed)
                {
                    string code = manager.GenerateEmailConfirmationToken(user.Id);
                    string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                    manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");
                    tbUserName.ErrorText = "Confirmation email sent. Please view the email and confirm your account.";
                    ResendConfirm.Visible = false;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(IsValid) {
                // Validate the user password
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();


                var user = manager.FindByName(tbUserName.Text);
                if (user != null)
                    if (!user.EmailConfirmed)
                    {
                        tbUserName.ErrorText = "Invalid login attempt. You must have a confirmed email address. Enter your email and password, then press 'Resend Confirmation'.";
                        ResendConfirm.Visible = true;
                    }
                    else
                    {
                        // This doen't count login failures towards account lockout
                        // To enable password failures to trigger lockout, change to shouldLockout: true
                        var result = signinManager.PasswordSignIn(tbUserName.Text, tbPassword.Text, isPersistent: false, shouldLockout: false);

                        switch (result)
                        {
                            case SignInStatus.Success:
                                
                                //Now that the user is authenticated, cast the user from ASP.NET Identity to retrieve his default landing project
                                var xmanager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
                                //var currentUser = xmanager.FindById(User.Identity.GetUserId());
                                var currentUser = xmanager.FindByName (tbUserName.Text);

                                // Use the extended user property of 'project' which contains the GUID for the enterprise project and it to session so it can be used when querying data throughout the project
                                HttpContext.Current.Session.Add("enterpriseID", currentUser.enterprise);
                                HttpContext.Current.Session.Add("UserID", currentUser.Id);
                                HttpContext.Current.Session.Add("UserEmail", currentUser.Email);

                                //Mode for saying whether user is in Enterprise or Project Mode DEPRECATED
                                HttpContext.Current.Session.Add("Mode", "project");

                                //Now select query other information about the project and then add them to session variabes so they can be use. Session(projectID) will be used for querying
                                //and the other properties pro_name and pro_color will be used to customize the interface to show the use what project he is currently working on
                                //First, add the user's connection String to the sqldatasource - also save the connectionstring into session so that it can be declaratively used on SqlDataSources throughout the project

                                // Get Enteprise Name and COnnection String
                                EnterpriseInfo LoginEnterprise = common_services.GetEnterpriseInfo(currentUser.enterprise);
                                HttpContext.Current.Session.Add("userConnString", common_services.BuildConnString(LoginEnterprise.DBconnectionString));
                                HttpContext.Current.Session.Add("IdentityConnString", common_services.BuildConnString("rcxidentity", true));
                                //DEPRECATED BELOW - LoginEnterprise.DBConnectionString only pulls DB name now, which the function above makes into a connection string based on slot app settings
                                //HttpContext.Current.Session.Add("userConnString", LoginEnterprise.DBconnectionString);
                                HttpContext.Current.Session.Add("EnterpriseName", LoginEnterprise.EnterpriseName);

                                // Now get the project info from the enterprise database for this client (the client's enterprise DB has the information for each solution)
                                DropdownItem NewProject = new DropdownItem();
                                NewProject = common_services.GetProjectMilestone(currentUser.project);
                                HttpContext.Current.Session.Add("projectName", NewProject.Name);
                                HttpContext.Current.Session.Add("projectColor", NewProject.Color);
                                HttpContext.Current.Session.Add("projectID", NewProject.Id);
                                HttpContext.Current.Session.Add("MilestoneID", NewProject.MilestoneID);
                                HttpContext.Current.Session.Add("MilestoneName", NewProject.MilestoneName);

                                EventLogger.Log("Login");

                                //Use ASP.NET Identity method to return user to the correct page
                                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                                
                                break;
                            case SignInStatus.LockedOut:
                                Response.Redirect("~/Account/Lockout.aspx");
                                break;
                            case SignInStatus.RequiresVerification:
                                Response.Redirect(String.Format("/Account/TwoFactorAuthenticationSignIn.aspx?ReturnUrl={0}&RememberMe={1}",
                                                                Request.QueryString["ReturnUrl"],
                                                                false),
                                                  true);
                                break;
                            case SignInStatus.Failure:
                            default:
                                tbUserName.ErrorText = "Invalid user";
                                tbUserName.IsValid = false;
                                break;
                        }
       

       
                }
            }
        }
    }
}