namespace IrcClientDemoCS
{
    partial class PopoutNotifaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopoutNotifaction));
            this.timerGraphic = new System.Windows.Forms.Timer(this.components);
            this.timerPolling = new System.Windows.Forms.Timer(this.components);
            this.timerFollowerGraphic = new System.Windows.Forms.Timer(this.components);
            this.timerDonationGraphic = new System.Windows.Forms.Timer(this.components);
            this.timerPopupQue = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPositionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTableAdapter1 = new IrcClientDemoCS.CommandBotDataSetTableAdapters.SettingsTableAdapter();
            this.mAKEITRAINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerGraphic
            // 
            this.timerGraphic.Tick += new System.EventHandler(this.timerGraphic_Tick);
            // 
            // timerPolling
            // 
            this.timerPolling.Tick += new System.EventHandler(this.timerPolling_Tick);
            // 
            // timerFollowerGraphic
            // 
            this.timerFollowerGraphic.Tick += new System.EventHandler(this.timerFollowerGraphic_Tick);
            // 
            // timerPopupQue
            // 
            this.timerPopupQue.Tick += new System.EventHandler(this.timerPopupQue_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::IrcClientDemoCS.Properties.Resources.worn_WASD;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(152, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(184, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "[Name] Just Followed!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.resetPositionToolStripMenuItem,
            this.resetPositionToolStripMenuItem1,
            this.exitToolStripMenuItem,
            this.mAKEITRAINToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 136);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.followerToolStripMenuItem,
            this.donationToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // followerToolStripMenuItem
            // 
            this.followerToolStripMenuItem.Name = "followerToolStripMenuItem";
            this.followerToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.followerToolStripMenuItem.Text = "Follower";
            this.followerToolStripMenuItem.Click += new System.EventHandler(this.followerToolStripMenuItem_Click);
            // 
            // donationToolStripMenuItem
            // 
            this.donationToolStripMenuItem.Name = "donationToolStripMenuItem";
            this.donationToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.donationToolStripMenuItem.Text = "Donation";
            this.donationToolStripMenuItem.Click += new System.EventHandler(this.donationToolStripMenuItem_Click);
            // 
            // resetPositionToolStripMenuItem
            // 
            this.resetPositionToolStripMenuItem.Name = "resetPositionToolStripMenuItem";
            this.resetPositionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetPositionToolStripMenuItem.Text = "Save Position";
            this.resetPositionToolStripMenuItem.Click += new System.EventHandler(this.savePositionToolStripMenuItem_Click);
            // 
            // resetPositionToolStripMenuItem1
            // 
            this.resetPositionToolStripMenuItem1.Name = "resetPositionToolStripMenuItem1";
            this.resetPositionToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.resetPositionToolStripMenuItem1.Text = "Reset Position";
            this.resetPositionToolStripMenuItem1.Click += new System.EventHandler(this.resetPositionToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsTableAdapter1
            // 
            this.settingsTableAdapter1.ClearBeforeFill = true;
            // 
            // mAKEITRAINToolStripMenuItem
            // 
            this.mAKEITRAINToolStripMenuItem.Name = "mAKEITRAINToolStripMenuItem";
            this.mAKEITRAINToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mAKEITRAINToolStripMenuItem.Text = "MAKE IT RAIN";
            this.mAKEITRAINToolStripMenuItem.Click += new System.EventHandler(this.mAKEITRAINToolStripMenuItem_Click);
            // 
            // PopoutNotifaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopoutNotifaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationGraphicPopout";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Crimson;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PopoutNotifaction_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PopoutNotification_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PopoutNotification_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PopoutNotification_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerGraphic;
        private System.Windows.Forms.Timer timerPolling;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerFollowerGraphic;
        private System.Windows.Forms.Timer timerDonationGraphic;
        private System.Windows.Forms.Timer timerPopupQue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPositionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private CommandBotDataSetTableAdapters.SettingsTableAdapter settingsTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem mAKEITRAINToolStripMenuItem;


    }
}