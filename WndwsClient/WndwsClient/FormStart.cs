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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
            ConnectClass.Access = false;
        }

        public static void ThreadProc()
        {
            Application.Run(new FormCreate());
        }

        public static void ThreadProc2()
        {
            Application.Run(new FormClient());
        }

        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t1.Start();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ConnectClass.UseType = 0;
            ConnectClass.checkLogin(textBoxUsername.Text, textBoxPassword.Text);
            ConnectClass.GetUserID(textBoxUsername.Text);
            ConnectClass.GetUserType(textBoxUsername.Text);
            if (textBoxUsername.Text != string.Empty || textBoxPassword.Text != string.Empty)
            {
                if (ConnectClass.Access == true)
                {
                    System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc2));
                    t1.Start();
                    this.Close();
                }
                else
                {
                    textBoxUsername.Text = string.Empty;
                    textBoxPassword.Text = string.Empty;
                    MessageBox.Show("Logon info is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void buttonForgot_Click(object sender, EventArgs e)
        {
            FormPasswordRecovery pr = new FormPasswordRecovery();
            pr.Show();
        }
    }
}
