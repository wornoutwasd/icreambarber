namespace IrcClientDemoCS
{
    partial class PopOutChat
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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iRCConnectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandBotDataSet = new IrcClientDemoCS.CommandBotDataSet();
            this.membershipLevelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.drawingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timerPoints = new System.Windows.Forms.Timer(this.components);
            this.timerBotMessages = new System.Windows.Forms.Timer(this.components);
            this.commandBotDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iRCConnectionsTableAdapter = new IrcClientDemoCS.CommandBotDataSetTableAdapters.IRCConnectionsTableAdapter();
            this.usersTableAdapter = new IrcClientDemoCS.CommandBotDataSetTableAdapters.UsersTableAdapter();
            this.membershipLevelsTableAdapter = new IrcClientDemoCS.CommandBotDataSetTableAdapters.MembershipLevelsTableAdapter();
            this.settingsTableAdapter = new IrcClientDemoCS.CommandBotDataSetTableAdapters.SettingsTableAdapter();
            this.drawingsTableAdapter = new IrcClientDemoCS.CommandBotDataSetTableAdapters.DrawingsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iRCConnectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipLevelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.DeepPink;
            this.rtbOutput.ForeColor = System.Drawing.Color.Pink;
            this.rtbOutput.Location = new System.Drawing.Point(12, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbOutput.Size = new System.Drawing.Size(375, 454);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // iRCConnectionsBindingSource
            // 
            this.iRCConnectionsBindingSource.DataMember = "IRCConnections";
            this.iRCConnectionsBindingSource.DataSource = this.commandBotDataSet;
            // 
            // commandBotDataSet
            // 
            this.commandBotDataSet.DataSetName = "CommandBotDataSet";
            this.commandBotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membershipLevelsBindingSource
            // 
            this.membershipLevelsBindingSource.DataMember = "MembershipLevels";
            this.membershipLevelsBindingSource.DataSource = this.commandBotDataSet;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.commandBotDataSet;
            // 
            // drawingsBindingSource
            // 
            this.drawingsBindingSource.DataMember = "Drawings";
            this.drawingsBindingSource.DataSource = this.commandBotDataSet;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.commandBotDataSet;
            // 
            // commandBotDataSetBindingSource
            // 
            this.commandBotDataSetBindingSource.DataSource = this.commandBotDataSet;
            this.commandBotDataSetBindingSource.Position = 0;
            // 
            // iRCConnectionsTableAdapter
            // 
            this.iRCConnectionsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // membershipLevelsTableAdapter
            // 
            this.membershipLevelsTableAdapter.ClearBeforeFill = true;
            // 
            // settingsTableAdapter
            // 
            this.settingsTableAdapter.ClearBeforeFill = true;
            // 
            // drawingsTableAdapter
            // 
            this.drawingsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // PopOutChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(399, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbOutput);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopOutChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitch Commander - PopOutChat";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PopOutChat_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PopOutChat_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PopOutChat_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.iRCConnectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipLevelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource iRCConnectionsBindingSource;
        private CommandBotDataSet commandBotDataSet;
        private System.Windows.Forms.BindingSource membershipLevelsBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource drawingsBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Timer timerPoints;
        private System.Windows.Forms.Timer timerBotMessages;
        private System.Windows.Forms.BindingSource commandBotDataSetBindingSource;
        private CommandBotDataSetTableAdapters.IRCConnectionsTableAdapter iRCConnectionsTableAdapter;
        private CommandBotDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private CommandBotDataSetTableAdapters.MembershipLevelsTableAdapter membershipLevelsTableAdapter;
        private CommandBotDataSetTableAdapters.SettingsTableAdapter settingsTableAdapter;
        private CommandBotDataSetTableAdapters.DrawingsTableAdapter drawingsTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}