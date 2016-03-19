using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryClass;

namespace WebClient
{
    public partial class passwordRecovery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            if (ConnectClass.isValid(TextBoxEmail.Text))
            {
                ConnectClass.getPassword(TextBoxEmail.Text);
                ConnectClass.MailSender();
                LabelFeedBack.Visible = true;
                LabelFeedBack.Text = "Mail sent";
            }
            else
            {
                LabelFeedBack.Visible = true;
                LabelFeedBack.Text = "Invalid email";
            }
        }
    }
}