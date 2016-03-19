using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryClass;

namespace WebClient
{
    public partial class manageAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxName.Text = ConnectClass.passU;
            TextBoxPassword.TextMode = TextBoxMode.Password;
            TextBoxCPassword.TextMode = TextBoxMode.Password;
            LabelFeedBack.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("messages.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == TextBoxCPassword.Text && TextBoxPassword.Text != string.Empty)
            {
                ConnectClass.updateUserInfo(TextBoxName.Text, TextBoxPassword.Text, TextBoxCountry.Text, Convert.ToInt32(TextBoxPhone.Text));
                LabelFeedBack.Visible = true;
                LabelFeedBack.Text = "Changes saved";
            }
            else
            {
               LabelFeedBack.Text = "Passwords don't match";
            }
        }
    }
}