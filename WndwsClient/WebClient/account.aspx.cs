using System;
using System.Web.UI.WebControls;
using LibraryClass;

namespace WebClient
{
    public partial class account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxPassword.TextMode = TextBoxMode.Password;
            TextBoxCPassword.TextMode = TextBoxMode.Password;
            LabelFeedBack.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConnectClass.NameTaken = false;
            ConnectClass.checkUserName(TextBoxName.Text);
            if ((TextBoxPassword.Text == TextBoxCPassword.Text) && ConnectClass.NameTaken == false && (ConnectClass.isValid(TextBoxEmail.Text)))
            {
                ConnectClass.AddUser(TextBoxName.Text, TextBoxPassword.Text,TextBoxEmail.Text, TextBoxCountry.Text, Convert.ToInt32(TextBoxPhone.Text), Convert.ToInt32("0"));
                TextBoxName.Text = string.Empty;
                TextBoxCountry.Text = string.Empty;
                TextBoxPhone.Text = string.Empty;
                Response.Redirect("Index.aspx");
            }
            else if (ConnectClass.NameTaken == true)
            {
                LabelFeedBack.Visible = true;
                LabelFeedBack.Text = "Name already exists";
            }
            else if (ConnectClass.isValid(TextBoxEmail.Text) == false)
            {
                LabelFeedBack.Text = "Invalid email"; LabelFeedBack.Visible = true;
            }
            else
            {
                LabelFeedBack.Visible = true;
                LabelFeedBack.Text = "Passwords don't match";
            }
        }
    }
}