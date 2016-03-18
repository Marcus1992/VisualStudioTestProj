using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using LibraryClass;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WndwsClient
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        public static void ThreadProc()
        {
            Application.Run(new FormClient());
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDBDataSet1.tbl_Message' table. You can move, or remove it, as needed.
            this.tbl_MessageTableAdapter.Fill(this.testDBDataSet1.tbl_Message);
            // TODO: This line of code loads data into the 'testDBDataSet.tbl_Users' table. You can move, or remove it, as needed.
            this.tbl_UsersTableAdapter.Fill(this.testDBDataSet.tbl_Users);


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t1.Start();
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
          //  if (dataGridViewMessages.SelectedCells[0].ColumnIndex == 2)
            {
                //dataGridViewMessages.SelectedCells[0].Value = textBox1.Text;
                //this.tbl_MessageTableAdapter.Update(this.examDBDataSet3.tbl_Message);
            }
        }
    }
}
