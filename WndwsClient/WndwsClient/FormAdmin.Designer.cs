namespace WndwsClient
{
    partial class FormAdmin
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewMessages = new System.Windows.Forms.DataGridView();
            this.messageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examDBDataSet3 = new WndwsClient.ExamDBDataSet3();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examDBDataSet4 = new WndwsClient.ExamDBDataSet4();
            this.tbl_MessageTableAdapter = new WndwsClient.ExamDBDataSet3TableAdapters.tbl_MessageTableAdapter();
            this.tbl_UsersTableAdapter = new WndwsClient.ExamDBDataSet4TableAdapters.tbl_UsersTableAdapter();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMessageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMessages
            // 
            this.dataGridViewMessages.AutoGenerateColumns = false;
            this.dataGridViewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.messageIDDataGridViewTextBoxColumn,
            this.headlineDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.messageCreatedDataGridViewTextBoxColumn});
            this.dataGridViewMessages.DataSource = this.tblMessageBindingSource;
            this.dataGridViewMessages.Location = new System.Drawing.Point(12, 13);
            this.dataGridViewMessages.Name = "dataGridViewMessages";
            this.dataGridViewMessages.Size = new System.Drawing.Size(443, 205);
            this.dataGridViewMessages.TabIndex = 0;
            // 
            // messageIDDataGridViewTextBoxColumn
            // 
            this.messageIDDataGridViewTextBoxColumn.DataPropertyName = "MessageID";
            this.messageIDDataGridViewTextBoxColumn.HeaderText = "MessageID";
            this.messageIDDataGridViewTextBoxColumn.Name = "messageIDDataGridViewTextBoxColumn";
            this.messageIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // headlineDataGridViewTextBoxColumn
            // 
            this.headlineDataGridViewTextBoxColumn.DataPropertyName = "Headline";
            this.headlineDataGridViewTextBoxColumn.HeaderText = "Headline";
            this.headlineDataGridViewTextBoxColumn.Name = "headlineDataGridViewTextBoxColumn";
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            // 
            // messageCreatedDataGridViewTextBoxColumn
            // 
            this.messageCreatedDataGridViewTextBoxColumn.DataPropertyName = "MessageCreated";
            this.messageCreatedDataGridViewTextBoxColumn.HeaderText = "MessageCreated";
            this.messageCreatedDataGridViewTextBoxColumn.Name = "messageCreatedDataGridViewTextBoxColumn";
            // 
            // tblMessageBindingSource
            // 
            this.tblMessageBindingSource.DataMember = "tbl_Message";
            this.tblMessageBindingSource.DataSource = this.examDBDataSet3;
            // 
            // examDBDataSet3
            // 
            this.examDBDataSet3.DataSetName = "ExamDBDataSet3";
            this.examDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.userTypeDataGridViewCheckBoxColumn});
            this.dataGridViewUsers.DataSource = this.tblUsersBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(461, 13);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(643, 205);
            this.dataGridViewUsers.TabIndex = 1;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // userTypeDataGridViewCheckBoxColumn
            // 
            this.userTypeDataGridViewCheckBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewCheckBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewCheckBoxColumn.Name = "userTypeDataGridViewCheckBoxColumn";
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tbl_Users";
            this.tblUsersBindingSource.DataSource = this.examDBDataSet4;
            // 
            // examDBDataSet4
            // 
            this.examDBDataSet4.DataSetName = "ExamDBDataSet4";
            this.examDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_MessageTableAdapter
            // 
            this.tbl_MessageTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_UsersTableAdapter
            // 
            this.tbl_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 237);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 285);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 344);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.dataGridViewMessages);
            this.Name = "FormAdmin";
            this.Text = "Edit Data";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMessageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMessages;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private ExamDBDataSet3 examDBDataSet3;
        private System.Windows.Forms.BindingSource tblMessageBindingSource;
        private ExamDBDataSet3TableAdapters.tbl_MessageTableAdapter tbl_MessageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageCreatedDataGridViewTextBoxColumn;
        private ExamDBDataSet4 examDBDataSet4;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private ExamDBDataSet4TableAdapters.tbl_UsersTableAdapter tbl_UsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userTypeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBox1;
    }
}