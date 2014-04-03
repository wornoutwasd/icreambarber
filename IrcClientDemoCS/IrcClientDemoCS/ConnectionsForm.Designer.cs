namespace IrcClientDemoCS
{
    partial class ConnectionsForm
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOauth = new System.Windows.Forms.TextBox();
            this.txtmPort = new System.Windows.Forms.MaskedTextBox();
            this.btnConnectionSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(147, 15);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(252, 22);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "irc.twitch.tv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Channel:";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(147, 47);
            this.txtChannel.Margin = new System.Windows.Forms.Padding(4);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(252, 22);
            this.txtChannel.TabIndex = 2;
            this.txtChannel.Text = "#wornoutwasd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "User:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(147, 79);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(252, 22);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "wornoutbot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oauth:";
            // 
            // txtOauth
            // 
            this.txtOauth.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtOauth.Location = new System.Drawing.Point(147, 111);
            this.txtOauth.Margin = new System.Windows.Forms.Padding(4);
            this.txtOauth.Name = "txtOauth";
            this.txtOauth.Size = new System.Drawing.Size(252, 22);
            this.txtOauth.TabIndex = 6;
            this.txtOauth.Text = "oauth:5apvk3gardkvm4ekpp1wdf5vazso8jq";
            // 
            // txtmPort
            // 
            this.txtmPort.Location = new System.Drawing.Point(147, 144);
            this.txtmPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtmPort.Name = "txtmPort";
            this.txtmPort.Size = new System.Drawing.Size(252, 22);
            this.txtmPort.TabIndex = 8;
            this.txtmPort.Text = "6667";
            // 
            // btnConnectionSave
            // 
            this.btnConnectionSave.Location = new System.Drawing.Point(147, 180);
            this.btnConnectionSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnectionSave.Name = "btnConnectionSave";
            this.btnConnectionSave.Size = new System.Drawing.Size(115, 30);
            this.btnConnectionSave.TabIndex = 9;
            this.btnConnectionSave.Text = "Save";
            this.btnConnectionSave.UseVisualStyleBackColor = true;
            this.btnConnectionSave.Click += new System.EventHandler(this.btnConnectionSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(292, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 31);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 223);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConnectionSave);
            this.Controls.Add(this.txtmPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOauth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConnectionsForm";
            this.Text = "Connections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOauth;
        private System.Windows.Forms.MaskedTextBox txtmPort;
        private System.Windows.Forms.Button btnConnectionSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelButton;
    }
}