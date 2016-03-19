using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryClass;

namespace WndwsClient
{
    public partial class FormPasswordRecovery : Form
    {
        public FormPasswordRecovery()
        {
            InitializeComponent();
            label1.Visible = false;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (ConnectClass.isValid(textBoxEmail.Text))
            {
                ConnectClass.getPassword(textBoxEmail.Text);
                ConnectClass.MailSender();
                label1.Visible = true;
                label1.Text = "Mail sent";
            }
            else
            {
                label1.Visible = true;
                label1.Text = "Invalid email";
            }
        }
    }
}
