using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryClass;

namespace WebClient
{
    public partial class create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("messages.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBoxHeadline.Text != string.Empty || TextBoxMessage.Text != string.Empty)
            {
                ConnectClass.AddMessage(TextBoxHeadline.Text, TextBoxMessage.Text);
                LabelFeedBack.Visible = true;
                LabelFeedBack.Text = "Message inserted";
            }
        }
    }
}