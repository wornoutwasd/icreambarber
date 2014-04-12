namespace IrcClientDemoCS
{
    partial class StreamInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StreamInfo));
            this.pbFollowers = new System.Windows.Forms.PictureBox();
            this.pbTotalViews = new System.Windows.Forms.PictureBox();
            this.pbViewers = new System.Windows.Forms.PictureBox();
            this.lblViewers = new System.Windows.Forms.Label();
            this.lblTotalViews = new System.Windows.Forms.Label();
            this.lblFollowers = new System.Windows.Forms.Label();
            this.timerNetLoad = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFollowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewers)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFollowers
            // 
            this.pbFollowers.Image = global::IrcClientDemoCS.Properties.Resources.FollowersIcon;
            this.pbFollowers.Location = new System.Drawing.Point(130, -2);
            this.pbFollowers.Name = "pbFollowers";
            this.pbFollowers.Size = new System.Drawing.Size(25, 27);
            this.pbFollowers.TabIndex = 2;
            this.pbFollowers.TabStop = false;
            // 
            // pbTotalViews
            // 
            this.pbTotalViews.Image = global::IrcClientDemoCS.Properties.Resources.ViewsIcon;
            this.pbTotalViews.Location = new System.Drawing.Point(66, 0);
            this.pbTotalViews.Name = "pbTotalViews";
            this.pbTotalViews.Size = new System.Drawing.Size(25, 27);
            this.pbTotalViews.TabIndex = 1;
            this.pbTotalViews.TabStop = false;
            // 
            // pbViewers
            // 
            this.pbViewers.Image = global::IrcClientDemoCS.Properties.Resources.ViewerIcon;
            this.pbViewers.Location = new System.Drawing.Point(0, 0);
            this.pbViewers.Name = "pbViewers";
            this.pbViewers.Size = new System.Drawing.Size(25, 27);
            this.pbViewers.TabIndex = 0;
            this.pbViewers.TabStop = false;
            // 
            // lblViewers
            // 
            this.lblViewers.AutoSize = true;
            this.lblViewers.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewers.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblViewers.Image = ((System.Drawing.Image)(resources.GetObject("lblViewers.Image")));
            this.lblViewers.Location = new System.Drawing.Point(21, 2);
            this.lblViewers.Name = "lblViewers";
            this.lblViewers.Size = new System.Drawing.Size(50, 21);
            this.lblViewers.TabIndex = 3;
            this.lblViewers.Text = "9999";
            this.lblViewers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalViews
            // 
            this.lblTotalViews.AutoSize = true;
            this.lblTotalViews.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalViews.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotalViews.Image = ((System.Drawing.Image)(resources.GetObject("lblTotalViews.Image")));
            this.lblTotalViews.Location = new System.Drawing.Point(86, 2);
            this.lblTotalViews.Name = "lblTotalViews";
            this.lblTotalViews.Size = new System.Drawing.Size(50, 21);
            this.lblTotalViews.TabIndex = 4;
            this.lblTotalViews.Text = "9999";
            this.lblTotalViews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowers.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFollowers.Image = ((System.Drawing.Image)(resources.GetObject("lblFollowers.Image")));
            this.lblFollowers.Location = new System.Drawing.Point(151, 2);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(50, 21);
            this.lblFollowers.TabIndex = 5;
            this.lblFollowers.Text = "9999";
            this.lblFollowers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerNetLoad
            // 
            this.timerNetLoad.Tick += new System.EventHandler(this.timerNetLoad_Tick);
            // 
            // StreamInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::IrcClientDemoCS.Properties.Resources.backgroundcolor;
            this.ClientSize = new System.Drawing.Size(202, 25);
            this.Controls.Add(this.lblFollowers);
            this.Controls.Add(this.lblTotalViews);
            this.Controls.Add(this.lblViewers);
            this.Controls.Add(this.pbFollowers);
            this.Controls.Add(this.pbTotalViews);
            this.Controls.Add(this.pbViewers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamInfo";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StreamInfo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StreamInfo_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StreamInfo_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbFollowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbViewers;
        private System.Windows.Forms.PictureBox pbTotalViews;
        private System.Windows.Forms.PictureBox pbFollowers;
        private System.Windows.Forms.Label lblViewers;
        private System.Windows.Forms.Label lblTotalViews;
        private System.Windows.Forms.Label lblFollowers;
        private System.Windows.Forms.Timer timerNetLoad;
    }
}