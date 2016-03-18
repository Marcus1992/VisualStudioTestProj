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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            string sc =String.Format("Welcome {0}", ConnectClass.passU);
            if (ConnectClass.UseType == 1)
            {
                buttonEdit.Enabled = true;
            }
            else
            {
                buttonEdit.Enabled = false;
            }
            DataGridViewColumn column1 = dataGridView1.Columns[2];
            DataGridViewColumn column2 = dataGridView1.Columns[1];
            column1.Width = 200;
            column2.Width = 100;

            labelWelcome.Text = sc;
        }

        public static void ThreadProc()
        {
            Application.Run(new FormStart());
        }

        public static void ThreadProc2()
        {
            Application.Run(new FormMessage());
        }

        public static void ThreadProc3()
        {
            Application.Run(new FormAdmin());
        }

        public static void ThreadProc4()
        {
            Application.Run(new manageAccount());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t1.Start();
            this.Close();
        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc2));
            t1.Start();
            this.Close();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc3));
            t1.Start();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonManageAccount_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc4));
            t1.Start();
            this.Close();
        }
    }
}
