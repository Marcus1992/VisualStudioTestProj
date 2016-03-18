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
    public partial class FormMessage : Form
    {
        public FormMessage()
        {
            InitializeComponent();
            labelFeedback.Visible = false;
        }

        public static void ThreadProc()
        {
            Application.Run(new FormClient());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxHeadline.Text == "" ||richTextBoxMessage.Text == "")
            {
                labelFeedback.Visible = true;
                labelFeedback.Text = "The textboxes are empty.";
            }
            else
            {
                ConnectClass.AddMessage(textBoxHeadline.Text, richTextBoxMessage.Text);
                labelFeedback.Text = "Message inserted";
                labelFeedback.Visible = true;
                textBoxHeadline.Text = string.Empty;
                richTextBoxMessage.Text = string.Empty;
            }
        }
    
        private void textBoxHeadline_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBoxHeadline.Text == "Add a title")
            textBoxHeadline.Text = string.Empty;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t1.Start();
            this.Close();
        }
    }
}
