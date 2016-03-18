using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryClass;
using System.Net.Mail;
using System.Net;

namespace WebClient
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectClass.Access = false;
            TextBoxPassword.TextMode = TextBoxMode.Password;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("account.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ConnectClass.UseType = 0;
            ConnectClass.checkLogin(TextBoxUsername.Text, TextBoxPassword.Text);
            ConnectClass.GetUserID(TextBoxUsername.Text);
            ConnectClass.GetUserType(TextBoxUsername.Text);
            if (ConnectClass.Access == true)
            {
                Response.Redirect("messages.aspx");
            }
            else
            {
                TextBoxUsername.Text = "";
                TextBoxPassword.Text = "";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("passwordRecovery.aspx");
        }
    }
}