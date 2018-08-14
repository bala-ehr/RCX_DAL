using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using DevExpress.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using RC_X.Models;

namespace RC_X
{
    public partial class ForgotPassword : Page
    {
        protected void Page_Load(object sender, EventArgs e)
              {
            //ASPxMenu MainMenu = (ASPxMenu)this.Master.FindControl("rcMenu");


        }

        protected void Forgot(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validate the user's email address
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                ApplicationUser user = manager.FindByEmail(Email.Text);
                if (user == null || !manager.IsEmailConfirmed(user.Id))
                {
                    FailureText.Text = "The user either does not exist or is not confirmed.";
                    return;
                }
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                // Send email with the code and the redirect to reset password page
                string code = manager.GeneratePasswordResetToken(user.Id);
                string callbackUrl = IdentityHelper.GetResetPasswordRedirectUrl(code, Request);


                List<EmailTemplatePlaceholders> MessageParameters = new List<EmailTemplatePlaceholders>();
                if (HttpContext.Current.Session["EnterpriseName"] != null)
                { MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{ENTERPRISE}", Replacement = HttpContext.Current.Session["EnterpriseName"].ToString() }); }
                else { MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{ENTERPRISE}", Replacement = "" }); }
                MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{SUBJECT}", Replacement = "Your Password Reset Link" });
                MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{USERNAME}", Replacement = "User: " + user.Email });
                MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{MESSAGE}", Replacement = "Please reset your password by <a href =\"" + callbackUrl + "\">clicking here</a>." });

                String PasswordResetMessage = common_services.PrepNotificationEmail(MessageParameters);

               manager.SendEmail(user.Id, "Reset Password your RCX password", PasswordResetMessage);
                loginForm.Visible = false;
                DisplayEmail.Visible = true;
            }
        }
    }
}