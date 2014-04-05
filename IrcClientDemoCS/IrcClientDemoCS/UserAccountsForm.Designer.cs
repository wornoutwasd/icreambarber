namespace IrcClientDemoCS
{
    partial class UserAccountsForm
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
            this.commandBotDataSet = new IrcClientDemoCS.CommandBotDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new IrcClientDemoCS.CommandBotDataSetTableAdapters.UsersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inGameDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalPointsEarnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.membershipLevelDataGridViewTextBoxColumn,
            this.currentPointsDataGridViewTextBoxColumn,
            this.inGameDataGridViewCheckBoxColumn,
            this.totalPointsEarnedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // commandBotDataSet
            // 
            this.commandBotDataSet.DataSetName = "CommandBotDataSet";
            this.commandBotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.commandBotDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // membershipLevelDataGridViewTextBoxColumn
            // 
            this.membershipLevelDataGridViewTextBoxColumn.DataPropertyName = "MembershipLevel";
            this.membershipLevelDataGridViewTextBoxColumn.HeaderText = "MembershipLevel";
            this.membershipLevelDataGridViewTextBoxColumn.Name = "membershipLevelDataGridViewTextBoxColumn";
            // 
            // currentPointsDataGridViewTextBoxColumn
            // 
            this.currentPointsDataGridViewTextBoxColumn.DataPropertyName = "CurrentPoints";
            this.currentPointsDataGridViewTextBoxColumn.HeaderText = "CurrentPoints";
            this.currentPointsDataGridViewTextBoxColumn.Name = "currentPointsDataGridViewTextBoxColumn";
            // 
            // inGameDataGridViewCheckBoxColumn
            // 
            this.inGameDataGridViewCheckBoxColumn.DataPropertyName = "InGame";
            this.inGameDataGridViewCheckBoxColumn.HeaderText = "InGame";
            this.inGameDataGridViewCheckBoxColumn.Name = "inGameDataGridViewCheckBoxColumn";
            // 
            // totalPointsEarnedDataGridViewTextBoxColumn
            // 
            this.totalPointsEarnedDataGridViewTextBoxColumn.DataPropertyName = "TotalPointsEarned";
            this.totalPointsEarnedDataGridViewTextBoxColumn.HeaderText = "TotalPointsEarned";
            this.totalPointsEarnedDataGridViewTextBoxColumn.Name = "totalPointsEarnedDataGridViewTextBoxColumn";
            // 
            // UserAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 288);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserAccountsForm";
            this.Text = "UserAccountsForm";
            this.Load += new System.EventHandler(this.UserAccountsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CommandBotDataSet commandBotDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private CommandBotDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inGameDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPointsEarnedDataGridViewTextBoxColumn;


    }
}