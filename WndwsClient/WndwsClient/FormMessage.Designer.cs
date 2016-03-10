namespace WndwsClient
{
    partial class FormMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.textBoxHeadline = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(185, 74);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(384, 163);
            this.richTextBoxMessage.TabIndex = 0;
            this.richTextBoxMessage.Text = "";
            // 
            // textBoxHeadline
            // 
            this.textBoxHeadline.Location = new System.Drawing.Point(184, 38);
            this.textBoxHeadline.Name = "textBoxHeadline";
            this.textBoxHeadline.Size = new System.Drawing.Size(385, 20);
            this.textBoxHeadline.TabIndex = 1;
            this.textBoxHeadline.Text = "Add a title";
            this.textBoxHeadline.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxHeadline_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Insert new message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(346, 258);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(176, 13);
            this.labelFeedback.TabIndex = 4;
            this.labelFeedback.Text = "Error, one of the textfields are empty";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(31, 253);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message\r\nLimit this to 250 characters please\r\n";
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxHeadline);
            this.Controls.Add(this.richTextBoxMessage);
            this.Name = "FormMessage";
            this.Text = "Create New Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.TextBox textBoxHeadline;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
    }
}