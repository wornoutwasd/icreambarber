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
            this.components = new System.ComponentModel.Container();
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
            this.lstConnectionList = new System.Windows.Forms.ListBox();
            this.lblConnectionsList = new System.Windows.Forms.Label();
            this.grpConnInputs = new System.Windows.Forms.GroupBox();
            this.cbDefault = new System.Windows.Forms.CheckBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.commandBotDataSet = new IrcClientDemoCS.CommandBotDataSet();
            this.iRCConnectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iRCConnectionsTableAdapter = new IrcClientDemoCS.CommandBotDataSetTableAdapters.IRCConnectionsTableAdapter();
            this.grpConnInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRCConnectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(60, 13);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(190, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Channel:";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(60, 39);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(190, 20);
            this.txtChannel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "User:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(60, 65);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(190, 20);
            this.txtUser.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oauth:";
            // 
            // txtOauth
            // 
            this.txtOauth.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtOauth.Location = new System.Drawing.Point(60, 91);
            this.txtOauth.Name = "txtOauth";
            this.txtOauth.Size = new System.Drawing.Size(190, 20);
            this.txtOauth.TabIndex = 6;
            this.txtOauth.Text = "oauth:5apvk3gardkvm4ekpp1wdf5vazso8jq";
            // 
            // txtmPort
            // 
            this.txtmPort.Location = new System.Drawing.Point(60, 118);
            this.txtmPort.Name = "txtmPort";
            this.txtmPort.Size = new System.Drawing.Size(190, 20);
            this.txtmPort.TabIndex = 8;
            this.txtmPort.Text = "6667";
            // 
            // btnConnectionSave
            // 
            this.btnConnectionSave.Location = new System.Drawing.Point(78, 178);
            this.btnConnectionSave.Name = "btnConnectionSave";
            this.btnConnectionSave.Size = new System.Drawing.Size(86, 24);
            this.btnConnectionSave.TabIndex = 9;
            this.btnConnectionSave.Text = "Save";
            this.btnConnectionSave.UseVisualStyleBackColor = true;
            this.btnConnectionSave.Click += new System.EventHandler(this.btnConnectionSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(169, 178);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 25);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // lstConnectionList
            // 
            this.lstConnectionList.DataSource = this.iRCConnectionsBindingSource;
            this.lstConnectionList.DisplayMember = "ServerAddress";
            this.lstConnectionList.FormattingEnabled = true;
            this.lstConnectionList.Location = new System.Drawing.Point(12, 25);
            this.lstConnectionList.Name = "lstConnectionList";
            this.lstConnectionList.Size = new System.Drawing.Size(120, 160);
            this.lstConnectionList.TabIndex = 12;
            this.lstConnectionList.ValueMember = "ServerAddress";
            // 
            // lblConnectionsList
            // 
            this.lblConnectionsList.AutoSize = true;
            this.lblConnectionsList.Location = new System.Drawing.Point(32, 9);
            this.lblConnectionsList.Name = "lblConnectionsList";
            this.lblConnectionsList.Size = new System.Drawing.Size(66, 13);
            this.lblConnectionsList.TabIndex = 13;
            this.lblConnectionsList.Text = "Connections";
            // 
            // grpConnInputs
            // 
            this.grpConnInputs.Controls.Add(this.cbDefault);
            this.grpConnInputs.Controls.Add(this.btnNew);
            this.grpConnInputs.Controls.Add(this.label1);
            this.grpConnInputs.Controls.Add(this.txtServer);
            this.grpConnInputs.Controls.Add(this.txtChannel);
            this.grpConnInputs.Controls.Add(this.cancelButton);
            this.grpConnInputs.Controls.Add(this.label2);
            this.grpConnInputs.Controls.Add(this.label5);
            this.grpConnInputs.Controls.Add(this.txtUser);
            this.grpConnInputs.Controls.Add(this.btnConnectionSave);
            this.grpConnInputs.Controls.Add(this.label3);
            this.grpConnInputs.Controls.Add(this.txtmPort);
            this.grpConnInputs.Controls.Add(this.txtOauth);
            this.grpConnInputs.Controls.Add(this.label4);
            this.grpConnInputs.Location = new System.Drawing.Point(138, 9);
            this.grpConnInputs.Name = "grpConnInputs";
            this.grpConnInputs.Size = new System.Drawing.Size(264, 208);
            this.grpConnInputs.TabIndex = 14;
            this.grpConnInputs.TabStop = false;
            // 
            // cbDefault
            // 
            this.cbDefault.AutoSize = true;
            this.cbDefault.Location = new System.Drawing.Point(61, 145);
            this.cbDefault.Name = "cbDefault";
            this.cbDefault.Size = new System.Drawing.Size(69, 17);
            this.cbDefault.TabIndex = 14;
            this.cbDefault.Text = "Default ?";
            this.cbDefault.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 178);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(66, 24);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // commandBotDataSet
            // 
            this.commandBotDataSet.DataSetName = "CommandBotDataSet";
            this.commandBotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iRCConnectionsBindingSource
            // 
            this.iRCConnectionsBindingSource.DataMember = "IRCConnections";
            this.iRCConnectionsBindingSource.DataSource = this.commandBotDataSet;
            // 
            // iRCConnectionsTableAdapter
            // 
            this.iRCConnectionsTableAdapter.ClearBeforeFill = true;
            // 
            // ConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 251);
            this.Controls.Add(this.grpConnInputs);
            this.Controls.Add(this.lblConnectionsList);
            this.Controls.Add(this.lstConnectionList);
            this.Name = "ConnectionsForm";
            this.Text = "Connections";
            this.Load += new System.EventHandler(this.ConnectionsForm_Load);
            this.grpConnInputs.ResumeLayout(false);
            this.grpConnInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRCConnectionsBindingSource)).EndInit();
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
        private System.Windows.Forms.ListBox lstConnectionList;
        private System.Windows.Forms.Label lblConnectionsList;
        private System.Windows.Forms.GroupBox grpConnInputs;
        private System.Windows.Forms.CheckBox cbDefault;
        private System.Windows.Forms.Button btnNew;
        private CommandBotDataSet commandBotDataSet;
        private System.Windows.Forms.BindingSource iRCConnectionsBindingSource;
        private CommandBotDataSetTableAdapters.IRCConnectionsTableAdapter iRCConnectionsTableAdapter;
    }
}