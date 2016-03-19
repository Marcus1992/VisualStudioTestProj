namespace WndwsClient
{
    partial class manageAccount
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxCPassword = new System.Windows.Forms.TextBox();
            this.labelCPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(235, 159);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(28, 158);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 24);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Save changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(185, 123);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(101, 20);
            this.textBoxPhone.TabIndex = 22;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(28, 123);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(98, 20);
            this.textBoxCountry.TabIndex = 21;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(182, 107);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 20;
            this.labelPhone.Text = "Phone ";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(25, 107);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 19;
            this.labelCountry.Text = "Country";
            // 
            // textBoxCPassword
            // 
            this.textBoxCPassword.Location = new System.Drawing.Point(185, 84);
            this.textBoxCPassword.Name = "textBoxCPassword";
            this.textBoxCPassword.Size = new System.Drawing.Size(138, 20);
            this.textBoxCPassword.TabIndex = 18;
            // 
            // labelCPassword
            // 
            this.labelCPassword.AutoSize = true;
            this.labelCPassword.Location = new System.Drawing.Point(182, 68);
            this.labelCPassword.Name = "labelCPassword";
            this.labelCPassword.Size = new System.Drawing.Size(90, 13);
            this.labelCPassword.TabIndex = 17;
            this.labelCPassword.Text = "Confirm password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(28, 84);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(138, 20);
            this.textBoxPassword.TabIndex = 16;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(28, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(98, 20);
            this.textBoxName.TabIndex = 15;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(25, 68);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Password";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 13);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Username";
            // 
            // manageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 239);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.textBoxCPassword);
            this.Controls.Add(this.labelCPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelName);
            this.Name = "manageAccount";
            this.Text = "manageAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxCPassword;
        private System.Windows.Forms.Label labelCPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelName;
    }
}