namespace WndwsClient
{
    partial class FormClient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.headlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examDBDataSet1 = new WndwsClient.ExamDBDataSet1();
            this.examDBDataSet = new WndwsClient.ExamDBDataSet();
            this.spGetFullMessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetFullMessageTableAdapter = new WndwsClient.ExamDBDataSetTableAdapters.spGetFullMessageTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonMessage = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tbl_MessageTableAdapter = new WndwsClient.ExamDBDataSet1TableAdapters.tbl_MessageTableAdapter();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMessageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetFullMessageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headlineDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.messageCreatedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMessageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(148, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 218);
            this.dataGridView1.TabIndex = 0;
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
            this.tblMessageBindingSource.DataSource = this.examDBDataSet1;
            // 
            // examDBDataSet1
            // 
            this.examDBDataSet1.DataSetName = "ExamDBDataSet1";
            this.examDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examDBDataSet
            // 
            this.examDBDataSet.DataSetName = "ExamDBDataSet";
            this.examDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetFullMessageBindingSource
            // 
            this.spGetFullMessageBindingSource.DataMember = "spGetFullMessage";
            this.spGetFullMessageBindingSource.DataSource = this.examDBDataSet;
            // 
            // spGetFullMessageTableAdapter
            // 
            this.spGetFullMessageTableAdapter.ClearBeforeFill = true;
            // 
            // buttonMessage
            // 
            this.buttonMessage.Location = new System.Drawing.Point(12, 160);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(98, 23);
            this.buttonMessage.TabIndex = 1;
            this.buttonMessage.Text = "New message";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Click += new System.EventHandler(this.buttonMessage_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 205);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(98, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // tbl_MessageTableAdapter
            // 
            this.tbl_MessageTableAdapter.ClearBeforeFill = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(12, 249);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(98, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(13, 22);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(35, 13);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "label1";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 284);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormClient";
            this.Text = "Watch Messages";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMessageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetFullMessageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource spGetFullMessageBindingSource;
        private ExamDBDataSet examDBDataSet;
        private ExamDBDataSetTableAdapters.spGetFullMessageTableAdapter spGetFullMessageTableAdapter;
        private System.Windows.Forms.Button buttonMessage;
        private System.Windows.Forms.Button buttonBack;
        private ExamDBDataSet1 examDBDataSet1;
        private System.Windows.Forms.BindingSource tblMessageBindingSource;
        private ExamDBDataSet1TableAdapters.tbl_MessageTableAdapter tbl_MessageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn headlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelWelcome;
    }
}

