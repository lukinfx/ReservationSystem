using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReservationSystemEntityFW;

namespace WebApp
{
    public partial class Login : Page
    {
        DatabaseUtils databaseUtils = new DatabaseUtils();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnLoggingIn(object sender, LoginCancelEventArgs e)
        {
            bool valid = databaseUtils.ValidateUser(Login1.UserName, Login1.Password);

            if (valid)
            {
                WebAppContext.Instance().ValidUser = true;
                Response.Redirect("ViewRequests.aspx");
                Response.End();
            }
            else
            {
                Login1.InstructionText = "Enter a valid email address.";
                Login1.InstructionTextStyle.ForeColor = System.Drawing.Color.RosyBrown;
                e.Cancel = true;
            }
        }
        
        protected void OnLoginError(object sender, EventArgs e)
        {
            Login1.HelpPageText = "Help with logging in...";
            Login1.PasswordRecoveryText = "Forgot your password?";
        }

    }
}