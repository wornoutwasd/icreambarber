namespace IrcClientDemoCS
{
    partial class MainForm
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
            this.botMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicAlertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrentServer = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.rtbDebug = new System.Windows.Forms.RichTextBox();
            this.lblDebug = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTestSend = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.grpConnInputs = new System.Windows.Forms.GroupBox();
            this.cbDefault = new System.Windows.Forms.CheckBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnConnectionSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmPort = new System.Windows.Forms.MaskedTextBox();
            this.txtOauth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConnectionsList = new System.Windows.Forms.Label();
            this.lstConnectionList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMessageUNPos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iRCConnectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandBotDataSet = new IrcClientDemoCS.CommandBotDataSet();
            this.iRCConnectionsTableAdapter = new IrcClientDemoCS.CommandBotDataSetTableAdapters.IRCConnectionsTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandBotDataSet1 = new IrcClientDemoCS.CommandBotDataSet();
            this.usersTableAdapter = new IrcClientDemoCS.CommandBotDataSetTableAdapters.UsersTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.grpConnInputs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRCConnectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(602, 35);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(140, 173);
            this.lstUsers.TabIndex = 1;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(6, 217);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(502, 20);
            this.txtSend.TabIndex = 2;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(514, 217);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(3, 35);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(595, 176);
            this.rtbOutput.TabIndex = 4;
            this.rtbOutput.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(3, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(687, 215);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(77, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test 1";
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
            this.botMessagesToolStripMenuItem,
            this.pointSettingsToolStripMenuItem,
            this.userAccountsToolStripMenuItem,
            this.drawingsToolStripMenuItem,
            this.graphicAlertsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
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
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.connectionsToolStripMenuItem.Text = "Connections";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Manage";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Connect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem1
            // 
            this.disconnectToolStripMenuItem1.Name = "disconnectToolStripMenuItem1";
            this.disconnectToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem1.Text = "Disconnect";
            this.disconnectToolStripMenuItem1.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // botMessagesToolStripMenuItem
            // 
            this.botMessagesToolStripMenuItem.Name = "botMessagesToolStripMenuItem";
            this.botMessagesToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.botMessagesToolStripMenuItem.Text = "Bot Messages";
            this.botMessagesToolStripMenuItem.Click += new System.EventHandler(this.botMessagesToolStripMenuItem_Click);
            // 
            // pointSettingsToolStripMenuItem
            // 
            this.pointSettingsToolStripMenuItem.Name = "pointSettingsToolStripMenuItem";
            this.pointSettingsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.pointSettingsToolStripMenuItem.Text = "Point Settings";
            this.pointSettingsToolStripMenuItem.Click += new System.EventHandler(this.pointSettingsToolStripMenuItem_Click);
            // 
            // userAccountsToolStripMenuItem
            // 
            this.userAccountsToolStripMenuItem.Name = "userAccountsToolStripMenuItem";
            this.userAccountsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.userAccountsToolStripMenuItem.Text = "User Accounts";
            this.userAccountsToolStripMenuItem.Click += new System.EventHandler(this.userAccountsToolStripMenuItem_Click);
            // 
            // drawingsToolStripMenuItem
            // 
            this.drawingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.drawingsToolStripMenuItem.Name = "drawingsToolStripMenuItem";
            this.drawingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.drawingsToolStripMenuItem.Text = "Drawings";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // graphicAlertsToolStripMenuItem
            // 
            this.graphicAlertsToolStripMenuItem.Name = "graphicAlertsToolStripMenuItem";
            this.graphicAlertsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.graphicAlertsToolStripMenuItem.Text = "Graphic Alerts";
            this.graphicAlertsToolStripMenuItem.Click += new System.EventHandler(this.graphicAlertsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblCurrentServer
            // 
            this.lblCurrentServer.AutoSize = true;
            this.lblCurrentServer.Location = new System.Drawing.Point(94, 11);
            this.lblCurrentServer.Name = "lblCurrentServer";
            this.lblCurrentServer.Size = new System.Drawing.Size(92, 13);
            this.lblCurrentServer.TabIndex = 9;
            this.lblCurrentServer.Text = "No Current Server";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(383, 11);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(114, 13);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "No Current User Name";
            // 
            // rtbDebug
            // 
            this.rtbDebug.Location = new System.Drawing.Point(748, 35);
            this.rtbDebug.Name = "rtbDebug";
            this.rtbDebug.Size = new System.Drawing.Size(292, 173);
            this.rtbDebug.TabIndex = 11;
            this.rtbDebug.Text = "";
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(846, 15);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(39, 13);
            this.lblDebug.TabIndex = 12;
            this.lblDebug.Text = "Debug";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(538, 11);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(80, 13);
            this.lblPort.TabIndex = 13;
            this.lblPort.Text = "No Current Port";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(242, 11);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(100, 13);
            this.lblChannel.TabIndex = 15;
            this.lblChannel.Text = "No Current Channel";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnTestSend
            // 
            this.btnTestSend.Location = new System.Drawing.Point(604, 215);
            this.btnTestSend.Name = "btnTestSend";
            this.btnTestSend.Size = new System.Drawing.Size(77, 23);
            this.btnTestSend.TabIndex = 16;
            this.btnTestSend.Text = "Test Send";
            this.btnTestSend.UseVisualStyleBackColor = true;
            this.btnTestSend.Click += new System.EventHandler(this.btnTestSend_Click);
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Controls.Add(this.tabPage3);
            this.tcMain.Controls.Add(this.tabPage4);
            this.tcMain.Controls.Add(this.tabPage5);
            this.tcMain.Controls.Add(this.tabPage6);
            this.tcMain.Controls.Add(this.tabPage7);
            this.tcMain.Location = new System.Drawing.Point(0, 27);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1059, 276);
            this.tcMain.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.lstUsers);
            this.tabPage1.Controls.Add(this.lblPort);
            this.tabPage1.Controls.Add(this.lblChannel);
            this.tabPage1.Controls.Add(this.lblUserName);
            this.tabPage1.Controls.Add(this.btnTestSend);
            this.tabPage1.Controls.Add(this.txtSend);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Controls.Add(this.lblCurrentServer);
            this.tabPage1.Controls.Add(this.rtbOutput);
            this.tabPage1.Controls.Add(this.lblDebug);
            this.tabPage1.Controls.Add(this.btnTest);
            this.tabPage1.Controls.Add(this.rtbDebug);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpConnInputs);
            this.tabPage2.Controls.Add(this.lblConnectionsList);
            this.tabPage2.Controls.Add(this.lstConnectionList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connections";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1051, 250);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bot Messages";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1051, 250);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Point Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1051, 250);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "User Accounts";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1051, 250);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Drawings";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1051, 250);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Graphic Alerts";
            this.tabPage7.UseVisualStyleBackColor = true;
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
            this.grpConnInputs.Location = new System.Drawing.Point(134, 10);
            this.grpConnInputs.Name = "grpConnInputs";
            this.grpConnInputs.Size = new System.Drawing.Size(264, 208);
            this.grpConnInputs.TabIndex = 17;
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
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(60, 13);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(190, 20);
            this.txtServer.TabIndex = 0;
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(60, 39);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(190, 20);
            this.txtChannel.TabIndex = 2;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(60, 65);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(190, 20);
            this.txtUser.TabIndex = 4;
            // 
            // btnConnectionSave
            // 
            this.btnConnectionSave.Location = new System.Drawing.Point(78, 178);
            this.btnConnectionSave.Name = "btnConnectionSave";
            this.btnConnectionSave.Size = new System.Drawing.Size(86, 24);
            this.btnConnectionSave.TabIndex = 9;
            this.btnConnectionSave.Text = "Save";
            this.btnConnectionSave.UseVisualStyleBackColor = true;
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
            // txtmPort
            // 
            this.txtmPort.Location = new System.Drawing.Point(60, 118);
            this.txtmPort.Name = "txtmPort";
            this.txtmPort.Size = new System.Drawing.Size(190, 20);
            this.txtmPort.TabIndex = 8;
            this.txtmPort.Text = "6667";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oauth:";
            // 
            // lblConnectionsList
            // 
            this.lblConnectionsList.AutoSize = true;
            this.lblConnectionsList.Location = new System.Drawing.Point(28, 10);
            this.lblConnectionsList.Name = "lblConnectionsList";
            this.lblConnectionsList.Size = new System.Drawing.Size(66, 13);
            this.lblConnectionsList.TabIndex = 16;
            this.lblConnectionsList.Text = "Connections";
            // 
            // lstConnectionList
            // 
            this.lstConnectionList.DisplayMember = "ServerAddress";
            this.lstConnectionList.FormattingEnabled = true;
            this.lstConnectionList.Location = new System.Drawing.Point(8, 26);
            this.lstConnectionList.Name = "lstConnectionList";
            this.lstConnectionList.Size = new System.Drawing.Size(120, 186);
            this.lstConnectionList.TabIndex = 15;
            this.lstConnectionList.ValueMember = "ServerAddress";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(298, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 141);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bot Commands";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Command:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(66, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "!Trade [User Name]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Trade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Command:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "!Coins";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Check Point Balance:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Command:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(66, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "!Chance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Gamble Game:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMessageUNPos);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 141);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Greeting";
            // 
            // cboMessageUNPos
            // 
            this.cboMessageUNPos.AutoCompleteCustomSource.AddRange(new string[] {
            "Before",
            "After"});
            this.cboMessageUNPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMessageUNPos.FormattingEnabled = true;
            this.cboMessageUNPos.Items.AddRange(new object[] {
            "Before",
            "After"});
            this.cboMessageUNPos.Location = new System.Drawing.Point(106, 74);
            this.cboMessageUNPos.Name = "cboMessageUNPos";
            this.cboMessageUNPos.Size = new System.Drawing.Size(121, 21);
            this.cboMessageUNPos.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Show User Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Welcome to the Stream! ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Message:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 68);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Point Timer";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Points On?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(223, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Minutes";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(137, 39);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 20);
            this.textBox5.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(91, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Every";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(221, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Points";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(137, 13);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(78, 20);
            this.textBox6.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(99, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Add";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1051, 250);
            this.dataGridView1.TabIndex = 1;
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
            // iRCConnectionsTableAdapter
            // 
            this.iRCConnectionsTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.commandBotDataSet1;
            // 
            // commandBotDataSet1
            // 
            this.commandBotDataSet1.DataSetName = "CommandBotDataSet";
            this.commandBotDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(8, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 112);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Membership Levels";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 303);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Twitch Commander";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.grpConnInputs.ResumeLayout(false);
            this.grpConnInputs.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRCConnectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSet1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem1;
        private System.Windows.Forms.Label lblCurrentServer;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.RichTextBox rtbDebug;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem botMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicAlertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnTestSend;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox grpConnInputs;
        private System.Windows.Forms.CheckBox cbDefault;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnConnectionSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtmPort;
        private System.Windows.Forms.TextBox txtOauth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConnectionsList;
        private System.Windows.Forms.ListBox lstConnectionList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMessageUNPos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource iRCConnectionsBindingSource;
        private CommandBotDataSet commandBotDataSet;
        private CommandBotDataSetTableAdapters.IRCConnectionsTableAdapter iRCConnectionsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private CommandBotDataSet commandBotDataSet1;
        private CommandBotDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

