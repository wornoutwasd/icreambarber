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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PopoutNotification_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PopoutNotification_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PopoutNotification_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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


    }
}