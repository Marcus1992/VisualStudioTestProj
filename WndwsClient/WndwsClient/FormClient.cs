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
            if (ConnectClass.UseType == 1)
            {
                buttonEdit.Enabled = true;
            }
            else
            {
                buttonEdit.Enabled = false;
            }
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            DataGridViewColumn column2 = dataGridView1.Columns[0];
            column1.Width = 300;
            column2.Width = 200;
            labelWelcome.Text = "Welcome, {0}";
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
            // TODO: This line of code loads data into the 'examDBDataSet1.tbl_Message' table. You can move, or remove it, as needed.
            this.tbl_MessageTableAdapter.Fill(this.examDBDataSet1.tbl_Message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc3));
            t1.Start();
            this.Close();
        }
    }
}
