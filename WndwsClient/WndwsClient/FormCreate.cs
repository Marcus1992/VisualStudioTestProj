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
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }

        public static void ThreadProc()
        {
            Application.Run(new FormStart());
        }

        private void FormCreate_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxCPassword.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectClass.NameTaken = false;
            ConnectClass.checkUserName(textBoxName.Text);
            try
            {
                if ((textBoxPassword.Text == textBoxCPassword.Text) && ConnectClass.NameTaken == false && (ConnectClass.isValid(textBoxEmail.Text)))
                {
                    ConnectClass.AddUser(textBoxName.Text, textBoxPassword.Text, textBoxEmail.Text, textBoxCountry.Text, Convert.ToInt32(textBoxPhone.Text), Convert.ToInt32("0"));
                   // label1.Visible = true; label1.Text = "Success";
                    System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t1.Start();
                    this.Close();
                }
                else if (ConnectClass.NameTaken == true)
                {
                    label1.Visible = true;
                    label1.Text = "Name already exists";
                }
                else if(ConnectClass.isValid(textBoxEmail.Text) == false)
                {
                    label1.Text = "Invalid email"; label1.Visible = true;
                }
                else
                {
                    label1.Text = "Passwords don't match"; label1.Visible = true;
                }
            }
            catch (Exception ex)
            {
                label1.Visible = true;
                label1.Text = "Error connecting to the database";
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
