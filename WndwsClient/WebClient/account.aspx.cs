using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
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
            if ((TextBoxPassword.Text == TextBoxCPassword.Text && TextBoxPassword.Text != string.Empty) && ConnectClass.NameTaken == false)
            {
                ConnectClass.AddUser(TextBoxName.Text, TextBoxPassword.Text, TextBoxCountry.Text, Convert.ToInt32(TextBoxPhone.Text), Convert.ToInt32("0"));
                LabelFeedBack.Visible = true;
                LabelFeedBack.Text = "Success";
                TextBoxName.Text = string.Empty;
                TextBoxCountry.Text = string.Empty;
                TextBoxPhone.Text = string.Empty;
            }
            else if (ConnectClass.NameTaken == true)
            {
                LabelFeedBack.Visible = true;
                LabelFeedBack.Text = "Name already exists";
            }
            else
            {
                LabelFeedBack.Visible = false;
                LabelFeedBack.Text = "Passwords don't match";
            }
        }
    }
}