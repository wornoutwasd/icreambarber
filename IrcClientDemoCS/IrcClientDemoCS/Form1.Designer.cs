namespace IrcClientDemoCS
{
    partial class Form1
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
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giveAwaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrentServer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 16;
            this.lstUsers.Location = new System.Drawing.Point(823, 126);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(159, 516);
            this.lstUsers.TabIndex = 1;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(16, 618);
            this.txtSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(691, 22);
            this.txtSend.TabIndex = 2;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(715, 614);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 28);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(16, 134);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(797, 475);
            this.rtbOutput.TabIndex = 4;
            this.rtbOutput.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(16, 98);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(167, 98);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 28);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionsToolStripMenuItem,
            this.giveAwaysToolStripMenuItem,
            this.coinsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(999, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "Blank";
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.disconnectToolStripMenuItem1});
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.connectionsToolStripMenuItem.Text = "Connections";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.connectToolStripMenuItem.Text = "Manage";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.disconnectToolStripMenuItem.Text = "Connect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem1
            // 
            this.disconnectToolStripMenuItem1.Name = "disconnectToolStripMenuItem1";
            this.disconnectToolStripMenuItem1.Size = new System.Drawing.Size(151, 24);
            this.disconnectToolStripMenuItem1.Text = "Disconnect";
            // 
            // giveAwaysToolStripMenuItem
            // 
            this.giveAwaysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.giveAwaysToolStripMenuItem.Name = "giveAwaysToolStripMenuItem";
            this.giveAwaysToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.giveAwaysToolStripMenuItem.Text = "Give Aways";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // coinsToolStripMenuItem
            // 
            this.coinsToolStripMenuItem.Name = "coinsToolStripMenuItem";
            this.coinsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.coinsToolStripMenuItem.Text = "Coins";
            // 
            // lblCurrentServer
            // 
            this.lblCurrentServer.AutoSize = true;
            this.lblCurrentServer.Location = new System.Drawing.Point(33, 34);
            this.lblCurrentServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentServer.Name = "lblCurrentServer";
            this.lblCurrentServer.Size = new System.Drawing.Size(43, 17);
            this.lblCurrentServer.TabIndex = 9;
            this.lblCurrentServer.Text = "Blank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Blank";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentServer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.lstUsers);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Twitch IRC Bot";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveAwaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem1;
        private System.Windows.Forms.Label lblCurrentServer;
        private System.Windows.Forms.Label label1;
    }
}

