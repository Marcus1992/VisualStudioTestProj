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
    public partial class manageAccount : Form
    {
        public manageAccount()
        {
            InitializeComponent();
            textBoxName.Text = ConnectClass.passU;
            this.ActiveControl = textBoxPassword;
            label1.Visible = false;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxCPassword.UseSystemPasswordChar = true;
        }

        public static void ThreadProc()
        {
            Application.Run(new FormClient());
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try {
                if (textBoxPassword.Text == textBoxCPassword.Text && textBoxPassword.Text != string.Empty)
                {
                    ConnectClass.updateUserInfo(textBoxName.Text, textBoxPassword.Text, textBoxCountry.Text, Convert.ToInt32(textBoxPhone.Text));
                    label1.Text = "Saves changed";
                    label1.Visible = true;
                }
                else
                {
                    label1.Text = "Passwords don't match";
                    label1.Visible = true;
                }
            }
            catch
            {
                label1.Text = "Missing information";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t1.Start();
            this.Close();
        }
    }
}
