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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblCurrentServer = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.rtbDebug = new System.Windows.Forms.RichTextBox();
            this.lblDebug = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.btnTestSend = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpConnInputs = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnDeleteConnection = new System.Windows.Forms.Button();
            this.cbDefault = new System.Windows.Forms.CheckBox();
            this.btnNewConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.btnCancelConnection = new System.Windows.Forms.Button();
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
            this.iRCConnectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandBotDataSet = new IrcClientDemoCS.CommandBotDataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBotMessageClear = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.lstMessageQue = new System.Windows.Forms.ListBox();
            this.lblMessageTimer = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveBotCommands = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTradeCommand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBalanceCommand = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGambleCommand = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveGreeting = new System.Windows.Forms.Button();
            this.cboMessageUNPos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGreetingMsg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnPointTest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMembershipUpdate = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnPointTimerReset = new System.Windows.Forms.Button();
            this.lblPointTickTimer = new System.Windows.Forms.Label();
            this.btnPointStart = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gvMembershipLevels = new System.Windows.Forms.DataGridView();
            this.membershipLevelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multiplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipLevelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipLevelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPointInfoSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPointTickPerMinute = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPointsPerTick = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gvUserAccounts = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inGameDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalPointsEarnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.grpDrawings = new System.Windows.Forms.GroupBox();
            this.grpDrawingsEdit = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDrawingMaxTickets = new System.Windows.Forms.TextBox();
            this.btnDrawingNew = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnDrawingSave = new System.Windows.Forms.Button();
            this.txtDrawingGiveAwayName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDrawingEntryCommand = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtDrawingID = new System.Windows.Forms.TextBox();
            this.txtDrawingAdvertisement = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtDrawingCongrats = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cbDrawingAutoAdvertise = new System.Windows.Forms.CheckBox();
            this.txtDrawingCost = new System.Windows.Forms.TextBox();
            this.txtDrawingAdvertiseInterval = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnDrawingChooseWinner = new System.Windows.Forms.Button();
            this.btnDrawingActivate = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.lstRaffleEntries = new System.Windows.Forms.ListBox();
            this.label27 = new System.Windows.Forms.Label();
            this.lstDrawings = new System.Windows.Forms.ListBox();
            this.drawingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
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
            this.rtbwebdata = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpConnInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iRCConnectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMembershipLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipLevelsBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.grpDrawings.SuspendLayout();
            this.grpDrawingsEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingsBindingSource)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(514, 35);
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
            this.rtbOutput.Size = new System.Drawing.Size(505, 176);
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
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.rtbDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDebug.Location = new System.Drawing.Point(660, 35);
            this.rtbDebug.Name = "rtbDebug";
            this.rtbDebug.Size = new System.Drawing.Size(383, 173);
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
            this.tcMain.Controls.Add(this.tabPage8);
            this.tcMain.Location = new System.Drawing.Point(0, 1);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1059, 270);
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
            this.tabPage1.Size = new System.Drawing.Size(1051, 244);
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
            this.tabPage2.Size = new System.Drawing.Size(1051, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connections";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpConnInputs
            // 
            this.grpConnInputs.Controls.Add(this.label30);
            this.grpConnInputs.Controls.Add(this.maskedTextBox1);
            this.grpConnInputs.Controls.Add(this.btnDeleteConnection);
            this.grpConnInputs.Controls.Add(this.cbDefault);
            this.grpConnInputs.Controls.Add(this.btnNewConnection);
            this.grpConnInputs.Controls.Add(this.label1);
            this.grpConnInputs.Controls.Add(this.txtServer);
            this.grpConnInputs.Controls.Add(this.txtChannel);
            this.grpConnInputs.Controls.Add(this.btnCancelConnection);
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
            this.grpConnInputs.Size = new System.Drawing.Size(264, 228);
            this.grpConnInputs.TabIndex = 17;
            this.grpConnInputs.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(33, 144);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(21, 13);
            this.label30.TabIndex = 17;
            this.label30.Text = "ID:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(60, 141);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // btnDeleteConnection
            // 
            this.btnDeleteConnection.Location = new System.Drawing.Point(6, 198);
            this.btnDeleteConnection.Name = "btnDeleteConnection";
            this.btnDeleteConnection.Size = new System.Drawing.Size(66, 24);
            this.btnDeleteConnection.TabIndex = 15;
            this.btnDeleteConnection.Text = "Delete";
            this.btnDeleteConnection.UseVisualStyleBackColor = true;
            // 
            // cbDefault
            // 
            this.cbDefault.AutoSize = true;
            this.cbDefault.Location = new System.Drawing.Point(169, 144);
            this.cbDefault.Name = "cbDefault";
            this.cbDefault.Size = new System.Drawing.Size(69, 17);
            this.cbDefault.TabIndex = 14;
            this.cbDefault.Text = "Default ?";
            this.cbDefault.UseVisualStyleBackColor = true;
            // 
            // btnNewConnection
            // 
            this.btnNewConnection.Location = new System.Drawing.Point(6, 168);
            this.btnNewConnection.Name = "btnNewConnection";
            this.btnNewConnection.Size = new System.Drawing.Size(66, 24);
            this.btnNewConnection.TabIndex = 12;
            this.btnNewConnection.Text = "New";
            this.btnNewConnection.UseVisualStyleBackColor = true;
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
            // btnCancelConnection
            // 
            this.btnCancelConnection.Location = new System.Drawing.Point(169, 198);
            this.btnCancelConnection.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelConnection.Name = "btnCancelConnection";
            this.btnCancelConnection.Size = new System.Drawing.Size(80, 25);
            this.btnCancelConnection.TabIndex = 11;
            this.btnCancelConnection.Text = "Cancel";
            this.btnCancelConnection.UseVisualStyleBackColor = true;
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
            this.btnConnectionSave.Location = new System.Drawing.Point(78, 198);
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
            // 
            // txtOauth
            // 
            this.txtOauth.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtOauth.Location = new System.Drawing.Point(60, 91);
            this.txtOauth.Name = "txtOauth";
            this.txtOauth.Size = new System.Drawing.Size(190, 20);
            this.txtOauth.TabIndex = 6;
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
            this.lstConnectionList.DataSource = this.iRCConnectionsBindingSource;
            this.lstConnectionList.DisplayMember = "ServerAddress";
            this.lstConnectionList.FormattingEnabled = true;
            this.lstConnectionList.Location = new System.Drawing.Point(8, 26);
            this.lstConnectionList.Name = "lstConnectionList";
            this.lstConnectionList.Size = new System.Drawing.Size(120, 186);
            this.lstConnectionList.TabIndex = 15;
            this.lstConnectionList.ValueMember = "ServerAddress";
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1051, 244);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bot Messages";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnBotMessageClear);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.lstMessageQue);
            this.groupBox5.Controls.Add(this.lblMessageTimer);
            this.groupBox5.Location = new System.Drawing.Point(588, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(455, 191);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Message Que";
            // 
            // btnBotMessageClear
            // 
            this.btnBotMessageClear.Location = new System.Drawing.Point(204, 141);
            this.btnBotMessageClear.Name = "btnBotMessageClear";
            this.btnBotMessageClear.Size = new System.Drawing.Size(245, 23);
            this.btnBotMessageClear.TabIndex = 15;
            this.btnBotMessageClear.Text = "Clear Messages";
            this.btnBotMessageClear.UseVisualStyleBackColor = true;
            this.btnBotMessageClear.Click += new System.EventHandler(this.btnBotMessageClear_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(37, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 65);
            this.label19.TabIndex = 2;
            this.label19.Text = "The Bot Timer is to prevent\r\n       Message Overload\r\n(20 messages in 30 seconds)" +
    "\r\nMessage Overload results in\r\n            8 Hour Ban!";
            // 
            // lstMessageQue
            // 
            this.lstMessageQue.FormattingEnabled = true;
            this.lstMessageQue.Location = new System.Drawing.Point(204, 14);
            this.lstMessageQue.Name = "lstMessageQue";
            this.lstMessageQue.Size = new System.Drawing.Size(245, 121);
            this.lstMessageQue.TabIndex = 1;
            // 
            // lblMessageTimer
            // 
            this.lblMessageTimer.AutoSize = true;
            this.lblMessageTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageTimer.Location = new System.Drawing.Point(76, 22);
            this.lblMessageTimer.Name = "lblMessageTimer";
            this.lblMessageTimer.Size = new System.Drawing.Size(65, 37);
            this.lblMessageTimer.TabIndex = 0;
            this.lblMessageTimer.Text = "0.0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveBotCommands);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTradeCommand);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBalanceCommand);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtGambleCommand);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(298, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 191);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bot Commands";
            // 
            // btnSaveBotCommands
            // 
            this.btnSaveBotCommands.Location = new System.Drawing.Point(66, 141);
            this.btnSaveBotCommands.Name = "btnSaveBotCommands";
            this.btnSaveBotCommands.Size = new System.Drawing.Size(120, 23);
            this.btnSaveBotCommands.TabIndex = 14;
            this.btnSaveBotCommands.Text = "Save Bot Commands";
            this.btnSaveBotCommands.UseVisualStyleBackColor = true;
            this.btnSaveBotCommands.Click += new System.EventHandler(this.btnSaveBotCommands_Click);
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
            // txtTradeCommand
            // 
            this.txtTradeCommand.Location = new System.Drawing.Point(66, 110);
            this.txtTradeCommand.Name = "txtTradeCommand";
            this.txtTradeCommand.Size = new System.Drawing.Size(212, 20);
            this.txtTradeCommand.TabIndex = 12;
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
            // txtBalanceCommand
            // 
            this.txtBalanceCommand.Location = new System.Drawing.Point(66, 32);
            this.txtBalanceCommand.Name = "txtBalanceCommand";
            this.txtBalanceCommand.Size = new System.Drawing.Size(212, 20);
            this.txtBalanceCommand.TabIndex = 9;
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
            // txtGambleCommand
            // 
            this.txtGambleCommand.Location = new System.Drawing.Point(66, 71);
            this.txtGambleCommand.Name = "txtGambleCommand";
            this.txtGambleCommand.Size = new System.Drawing.Size(212, 20);
            this.txtGambleCommand.TabIndex = 6;
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
            this.groupBox1.Controls.Add(this.btnSaveGreeting);
            this.groupBox1.Controls.Add(this.cboMessageUNPos);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtGreetingMsg);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Greeting";
            // 
            // btnSaveGreeting
            // 
            this.btnSaveGreeting.Location = new System.Drawing.Point(78, 141);
            this.btnSaveGreeting.Name = "btnSaveGreeting";
            this.btnSaveGreeting.Size = new System.Drawing.Size(120, 23);
            this.btnSaveGreeting.TabIndex = 15;
            this.btnSaveGreeting.Text = "Save Bot Greeting";
            this.btnSaveGreeting.UseVisualStyleBackColor = true;
            this.btnSaveGreeting.Click += new System.EventHandler(this.btnSaveGreeting_Click);
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
            // txtGreetingMsg
            // 
            this.txtGreetingMsg.Location = new System.Drawing.Point(10, 37);
            this.txtGreetingMsg.Name = "txtGreetingMsg";
            this.txtGreetingMsg.Size = new System.Drawing.Size(268, 20);
            this.txtGreetingMsg.TabIndex = 1;
            this.txtGreetingMsg.Text = " ";
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
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.btnPointTest);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.btnMembershipUpdate);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1051, 244);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Point Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnPointTest
            // 
            this.btnPointTest.Location = new System.Drawing.Point(48, 189);
            this.btnPointTest.Name = "btnPointTest";
            this.btnPointTest.Size = new System.Drawing.Size(199, 23);
            this.btnPointTest.TabIndex = 10;
            this.btnPointTest.Text = "txtPointTest";
            this.btnPointTest.UseVisualStyleBackColor = true;
            this.btnPointTest.Click += new System.EventHandler(this.btnPointTest_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(763, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update Gridview";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMembershipUpdate
            // 
            this.btnMembershipUpdate.Location = new System.Drawing.Point(558, 214);
            this.btnMembershipUpdate.Name = "btnMembershipUpdate";
            this.btnMembershipUpdate.Size = new System.Drawing.Size(199, 23);
            this.btnMembershipUpdate.TabIndex = 8;
            this.btnMembershipUpdate.Text = "update membership";
            this.btnMembershipUpdate.UseVisualStyleBackColor = true;
            this.btnMembershipUpdate.Click += new System.EventHandler(this.btnMembershipUpdate_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPointTimerReset);
            this.groupBox6.Controls.Add(this.lblPointTickTimer);
            this.groupBox6.Controls.Add(this.btnPointStart);
            this.groupBox6.Location = new System.Drawing.Point(8, 85);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(292, 98);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Point Clock";
            // 
            // btnPointTimerReset
            // 
            this.btnPointTimerReset.Location = new System.Drawing.Point(91, 19);
            this.btnPointTimerReset.Name = "btnPointTimerReset";
            this.btnPointTimerReset.Size = new System.Drawing.Size(75, 23);
            this.btnPointTimerReset.TabIndex = 9;
            this.btnPointTimerReset.Text = "Reset";
            this.btnPointTimerReset.UseVisualStyleBackColor = true;
            this.btnPointTimerReset.Click += new System.EventHandler(this.btnPointTimerReset_Click);
            // 
            // lblPointTickTimer
            // 
            this.lblPointTickTimer.AutoSize = true;
            this.lblPointTickTimer.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointTickTimer.Location = new System.Drawing.Point(3, 43);
            this.lblPointTickTimer.Name = "lblPointTickTimer";
            this.lblPointTickTimer.Size = new System.Drawing.Size(283, 43);
            this.lblPointTickTimer.TabIndex = 0;
            this.lblPointTickTimer.Text = "Countdown Timer";
            // 
            // btnPointStart
            // 
            this.btnPointStart.Location = new System.Drawing.Point(11, 19);
            this.btnPointStart.Name = "btnPointStart";
            this.btnPointStart.Size = new System.Drawing.Size(75, 23);
            this.btnPointStart.TabIndex = 7;
            this.btnPointStart.Text = "Start";
            this.btnPointStart.UseVisualStyleBackColor = true;
            this.btnPointStart.Click += new System.EventHandler(this.btnPointStart_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gvMembershipLevels);
            this.groupBox4.Location = new System.Drawing.Point(306, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(734, 208);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Membership Levels";
            // 
            // gvMembershipLevels
            // 
            this.gvMembershipLevels.AllowUserToDeleteRows = false;
            this.gvMembershipLevels.AutoGenerateColumns = false;
            this.gvMembershipLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMembershipLevels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.membershipLevelDataGridViewTextBoxColumn1,
            this.multiplierDataGridViewTextBoxColumn,
            this.membershipLevelNameDataGridViewTextBoxColumn});
            this.gvMembershipLevels.DataSource = this.membershipLevelsBindingSource;
            this.gvMembershipLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMembershipLevels.Location = new System.Drawing.Point(3, 16);
            this.gvMembershipLevels.Name = "gvMembershipLevels";
            this.gvMembershipLevels.Size = new System.Drawing.Size(728, 189);
            this.gvMembershipLevels.TabIndex = 0;
            // 
            // membershipLevelDataGridViewTextBoxColumn1
            // 
            this.membershipLevelDataGridViewTextBoxColumn1.DataPropertyName = "MembershipLevel";
            this.membershipLevelDataGridViewTextBoxColumn1.HeaderText = "MembershipLevel";
            this.membershipLevelDataGridViewTextBoxColumn1.Name = "membershipLevelDataGridViewTextBoxColumn1";
            // 
            // multiplierDataGridViewTextBoxColumn
            // 
            this.multiplierDataGridViewTextBoxColumn.DataPropertyName = "Multiplier";
            this.multiplierDataGridViewTextBoxColumn.HeaderText = "Multiplier";
            this.multiplierDataGridViewTextBoxColumn.Name = "multiplierDataGridViewTextBoxColumn";
            // 
            // membershipLevelNameDataGridViewTextBoxColumn
            // 
            this.membershipLevelNameDataGridViewTextBoxColumn.DataPropertyName = "MembershipLevelName";
            this.membershipLevelNameDataGridViewTextBoxColumn.HeaderText = "MembershipLevelName";
            this.membershipLevelNameDataGridViewTextBoxColumn.Name = "membershipLevelNameDataGridViewTextBoxColumn";
            // 
            // membershipLevelsBindingSource
            // 
            this.membershipLevelsBindingSource.DataMember = "MembershipLevels";
            this.membershipLevelsBindingSource.DataSource = this.commandBotDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPointInfoSave);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtPointTickPerMinute);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtPointsPerTick);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 76);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Point Timer";
            // 
            // btnPointInfoSave
            // 
            this.btnPointInfoSave.Location = new System.Drawing.Point(7, 43);
            this.btnPointInfoSave.Name = "btnPointInfoSave";
            this.btnPointInfoSave.Size = new System.Drawing.Size(75, 23);
            this.btnPointInfoSave.TabIndex = 8;
            this.btnPointInfoSave.Text = "Save";
            this.btnPointInfoSave.UseVisualStyleBackColor = true;
            this.btnPointInfoSave.Click += new System.EventHandler(this.btnPointInfoSave_Click);
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
            // txtPointTickPerMinute
            // 
            this.txtPointTickPerMinute.Location = new System.Drawing.Point(137, 39);
            this.txtPointTickPerMinute.Name = "txtPointTickPerMinute";
            this.txtPointTickPerMinute.Size = new System.Drawing.Size(78, 20);
            this.txtPointTickPerMinute.TabIndex = 4;
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
            // txtPointsPerTick
            // 
            this.txtPointsPerTick.Location = new System.Drawing.Point(137, 13);
            this.txtPointsPerTick.Name = "txtPointsPerTick";
            this.txtPointsPerTick.Size = new System.Drawing.Size(78, 20);
            this.txtPointsPerTick.TabIndex = 1;
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gvUserAccounts);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1051, 244);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "User Accounts";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gvUserAccounts
            // 
            this.gvUserAccounts.AllowUserToAddRows = false;
            this.gvUserAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvUserAccounts.AutoGenerateColumns = false;
            this.gvUserAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUserAccounts.ColumnHeadersHeight = 25;
            this.gvUserAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvUserAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.membershipLevelDataGridViewTextBoxColumn,
            this.currentPointsDataGridViewTextBoxColumn,
            this.inGameDataGridViewCheckBoxColumn,
            this.totalPointsEarnedDataGridViewTextBoxColumn});
            this.gvUserAccounts.DataSource = this.usersBindingSource1;
            this.gvUserAccounts.Location = new System.Drawing.Point(3, 3);
            this.gvUserAccounts.Name = "gvUserAccounts";
            this.gvUserAccounts.RowHeadersWidth = 40;
            this.gvUserAccounts.Size = new System.Drawing.Size(1048, 204);
            this.gvUserAccounts.TabIndex = 0;
            this.gvUserAccounts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUserAccounts_CellEndEdit);
            this.gvUserAccounts.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gvUserAccounts_UserDeletingRow);
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
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.commandBotDataSet;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.grpDrawings);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1051, 244);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Drawings";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // grpDrawings
            // 
            this.grpDrawings.Controls.Add(this.grpDrawingsEdit);
            this.grpDrawings.Controls.Add(this.btnDrawingChooseWinner);
            this.grpDrawings.Controls.Add(this.btnDrawingActivate);
            this.grpDrawings.Controls.Add(this.label29);
            this.grpDrawings.Controls.Add(this.lstRaffleEntries);
            this.grpDrawings.Controls.Add(this.label27);
            this.grpDrawings.Controls.Add(this.lstDrawings);
            this.grpDrawings.Location = new System.Drawing.Point(9, 4);
            this.grpDrawings.Name = "grpDrawings";
            this.grpDrawings.Size = new System.Drawing.Size(1034, 237);
            this.grpDrawings.TabIndex = 0;
            this.grpDrawings.TabStop = false;
            this.grpDrawings.Text = "Drawings";
            // 
            // grpDrawingsEdit
            // 
            this.grpDrawingsEdit.Controls.Add(this.label21);
            this.grpDrawingsEdit.Controls.Add(this.txtDrawingMaxTickets);
            this.grpDrawingsEdit.Controls.Add(this.btnDrawingNew);
            this.grpDrawingsEdit.Controls.Add(this.label18);
            this.grpDrawingsEdit.Controls.Add(this.btnDrawingSave);
            this.grpDrawingsEdit.Controls.Add(this.txtDrawingGiveAwayName);
            this.grpDrawingsEdit.Controls.Add(this.label22);
            this.grpDrawingsEdit.Controls.Add(this.txtDrawingEntryCommand);
            this.grpDrawingsEdit.Controls.Add(this.label23);
            this.grpDrawingsEdit.Controls.Add(this.txtDrawingID);
            this.grpDrawingsEdit.Controls.Add(this.txtDrawingAdvertisement);
            this.grpDrawingsEdit.Controls.Add(this.label28);
            this.grpDrawingsEdit.Controls.Add(this.label24);
            this.grpDrawingsEdit.Controls.Add(this.txtDrawingCongrats);
            this.grpDrawingsEdit.Controls.Add(this.label25);
            this.grpDrawingsEdit.Controls.Add(this.cbDrawingAutoAdvertise);
            this.grpDrawingsEdit.Controls.Add(this.txtDrawingCost);
            this.grpDrawingsEdit.Controls.Add(this.txtDrawingAdvertiseInterval);
            this.grpDrawingsEdit.Controls.Add(this.label26);
            this.grpDrawingsEdit.Location = new System.Drawing.Point(6, 13);
            this.grpDrawingsEdit.Name = "grpDrawingsEdit";
            this.grpDrawingsEdit.Size = new System.Drawing.Size(428, 219);
            this.grpDrawingsEdit.TabIndex = 26;
            this.grpDrawingsEdit.TabStop = false;
            this.grpDrawingsEdit.Text = "Edit Drawings";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Give Away Name";
            // 
            // txtDrawingMaxTickets
            // 
            this.txtDrawingMaxTickets.Location = new System.Drawing.Point(83, 171);
            this.txtDrawingMaxTickets.Name = "txtDrawingMaxTickets";
            this.txtDrawingMaxTickets.Size = new System.Drawing.Size(55, 20);
            this.txtDrawingMaxTickets.TabIndex = 25;
            // 
            // btnDrawingNew
            // 
            this.btnDrawingNew.Location = new System.Drawing.Point(314, 169);
            this.btnDrawingNew.Name = "btnDrawingNew";
            this.btnDrawingNew.Size = new System.Drawing.Size(108, 23);
            this.btnDrawingNew.TabIndex = 0;
            this.btnDrawingNew.Text = "New Drawing";
            this.btnDrawingNew.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Max Tickets";
            // 
            // btnDrawingSave
            // 
            this.btnDrawingSave.Location = new System.Drawing.Point(314, 139);
            this.btnDrawingSave.Name = "btnDrawingSave";
            this.btnDrawingSave.Size = new System.Drawing.Size(108, 23);
            this.btnDrawingSave.TabIndex = 1;
            this.btnDrawingSave.Text = "Save Drawing";
            this.btnDrawingSave.UseVisualStyleBackColor = true;
            // 
            // txtDrawingGiveAwayName
            // 
            this.txtDrawingGiveAwayName.Location = new System.Drawing.Point(110, 13);
            this.txtDrawingGiveAwayName.Name = "txtDrawingGiveAwayName";
            this.txtDrawingGiveAwayName.Size = new System.Drawing.Size(201, 20);
            this.txtDrawingGiveAwayName.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Entry Command";
            // 
            // txtDrawingEntryCommand
            // 
            this.txtDrawingEntryCommand.Location = new System.Drawing.Point(110, 37);
            this.txtDrawingEntryCommand.Name = "txtDrawingEntryCommand";
            this.txtDrawingEntryCommand.Size = new System.Drawing.Size(201, 20);
            this.txtDrawingEntryCommand.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Advertisement";
            // 
            // txtDrawingID
            // 
            this.txtDrawingID.Location = new System.Drawing.Point(255, 171);
            this.txtDrawingID.Name = "txtDrawingID";
            this.txtDrawingID.ReadOnly = true;
            this.txtDrawingID.Size = new System.Drawing.Size(55, 20);
            this.txtDrawingID.TabIndex = 19;
            // 
            // txtDrawingAdvertisement
            // 
            this.txtDrawingAdvertisement.Location = new System.Drawing.Point(110, 63);
            this.txtDrawingAdvertisement.Multiline = true;
            this.txtDrawingAdvertisement.Name = "txtDrawingAdvertisement";
            this.txtDrawingAdvertisement.Size = new System.Drawing.Size(201, 49);
            this.txtDrawingAdvertisement.TabIndex = 7;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(231, 174);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(18, 13);
            this.label28.TabIndex = 18;
            this.label28.Text = "ID";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(15, 123);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 13);
            this.label24.TabIndex = 8;
            this.label24.Text = "Congratulations";
            // 
            // txtDrawingCongrats
            // 
            this.txtDrawingCongrats.Location = new System.Drawing.Point(110, 120);
            this.txtDrawingCongrats.Name = "txtDrawingCongrats";
            this.txtDrawingCongrats.Size = new System.Drawing.Size(201, 20);
            this.txtDrawingCongrats.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 149);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 10;
            this.label25.Text = "Cost";
            // 
            // cbDrawingAutoAdvertise
            // 
            this.cbDrawingAutoAdvertise.AutoSize = true;
            this.cbDrawingAutoAdvertise.Location = new System.Drawing.Point(144, 173);
            this.cbDrawingAutoAdvertise.Name = "cbDrawingAutoAdvertise";
            this.cbDrawingAutoAdvertise.Size = new System.Drawing.Size(95, 17);
            this.cbDrawingAutoAdvertise.TabIndex = 15;
            this.cbDrawingAutoAdvertise.Text = "Auto Advertise";
            this.cbDrawingAutoAdvertise.UseVisualStyleBackColor = true;
            // 
            // txtDrawingCost
            // 
            this.txtDrawingCost.Location = new System.Drawing.Point(49, 146);
            this.txtDrawingCost.Name = "txtDrawingCost";
            this.txtDrawingCost.Size = new System.Drawing.Size(55, 20);
            this.txtDrawingCost.TabIndex = 11;
            // 
            // txtDrawingAdvertiseInterval
            // 
            this.txtDrawingAdvertiseInterval.Location = new System.Drawing.Point(256, 146);
            this.txtDrawingAdvertiseInterval.Name = "txtDrawingAdvertiseInterval";
            this.txtDrawingAdvertiseInterval.Size = new System.Drawing.Size(55, 20);
            this.txtDrawingAdvertiseInterval.TabIndex = 13;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(110, 149);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(140, 13);
            this.label26.TabIndex = 12;
            this.label26.Text = "Advertise Interval (Seconds)";
            // 
            // btnDrawingChooseWinner
            // 
            this.btnDrawingChooseWinner.Location = new System.Drawing.Point(798, 35);
            this.btnDrawingChooseWinner.Name = "btnDrawingChooseWinner";
            this.btnDrawingChooseWinner.Size = new System.Drawing.Size(108, 23);
            this.btnDrawingChooseWinner.TabIndex = 23;
            this.btnDrawingChooseWinner.Text = "Choose Winner!";
            this.btnDrawingChooseWinner.UseVisualStyleBackColor = true;
            this.btnDrawingChooseWinner.Click += new System.EventHandler(this.btnDrawingChooseWinner_Click);
            // 
            // btnDrawingActivate
            // 
            this.btnDrawingActivate.Location = new System.Drawing.Point(480, 203);
            this.btnDrawingActivate.Name = "btnDrawingActivate";
            this.btnDrawingActivate.Size = new System.Drawing.Size(108, 23);
            this.btnDrawingActivate.TabIndex = 22;
            this.btnDrawingActivate.Text = "Activate Drawing";
            this.btnDrawingActivate.UseVisualStyleBackColor = true;
            this.btnDrawingActivate.Click += new System.EventHandler(this.btnDrawingActivate_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(653, 21);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(126, 13);
            this.label29.TabIndex = 21;
            this.label29.Text = "Current Giveaway Entries";
            // 
            // lstRaffleEntries
            // 
            this.lstRaffleEntries.FormattingEnabled = true;
            this.lstRaffleEntries.Location = new System.Drawing.Point(640, 37);
            this.lstRaffleEntries.Name = "lstRaffleEntries";
            this.lstRaffleEntries.Size = new System.Drawing.Size(152, 160);
            this.lstRaffleEntries.TabIndex = 20;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(513, 21);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 13);
            this.label27.TabIndex = 17;
            this.label27.Text = "Drawings";
            // 
            // lstDrawings
            // 
            this.lstDrawings.DataSource = this.drawingsBindingSource;
            this.lstDrawings.DisplayMember = "GiveAwayName";
            this.lstDrawings.FormattingEnabled = true;
            this.lstDrawings.Location = new System.Drawing.Point(462, 37);
            this.lstDrawings.Name = "lstDrawings";
            this.lstDrawings.Size = new System.Drawing.Size(152, 160);
            this.lstDrawings.TabIndex = 16;
            this.lstDrawings.ValueMember = "GiveAwayName";
            this.lstDrawings.SelectedIndexChanged += new System.EventHandler(this.lstDrawings_SelectedIndexChanged);
            // 
            // drawingsBindingSource
            // 
            this.drawingsBindingSource.DataMember = "Drawings";
            this.drawingsBindingSource.DataSource = this.commandBotDataSet;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.pictureBox1);
            this.tabPage7.Controls.Add(this.rtbwebdata);
            this.tabPage7.Controls.Add(this.button1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1051, 244);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Graphic Alerts";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.textBox7);
            this.tabPage8.Controls.Add(this.label20);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1051, 244);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "About";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(374, 41);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(326, 183);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = resources.GetString("textBox7.Text");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(405, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(161, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Copyright 2014 - David Campbell";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.commandBotDataSet;
            // 
            // timerPoints
            // 
            this.timerPoints.Tick += new System.EventHandler(this.timerPoints_Tick);
            // 
            // timerBotMessages
            // 
            this.timerBotMessages.Tick += new System.EventHandler(this.timerBotMessages_Tick);
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
            this.button1.Location = new System.Drawing.Point(179, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbwebdata
            // 
            this.rtbwebdata.Location = new System.Drawing.Point(310, 41);
            this.rtbwebdata.Name = "rtbwebdata";
            this.rtbwebdata.Size = new System.Drawing.Size(462, 158);
            this.rtbwebdata.TabIndex = 1;
            this.rtbwebdata.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IrcClientDemoCS.Properties.Resources.ViewerIcon;
            this.pictureBox1.Location = new System.Drawing.Point(833, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 271);
            this.Controls.Add(this.tcMain);
            this.Name = "MainForm";
            this.Text = "Twitch Commander";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpConnInputs.ResumeLayout(false);
            this.grpConnInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iRCConnectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMembershipLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipLevelsBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.grpDrawings.ResumeLayout(false);
            this.grpDrawings.PerformLayout();
            this.grpDrawingsEdit.ResumeLayout(false);
            this.grpDrawingsEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingsBindingSource)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBotDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblCurrentServer;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.RichTextBox rtbDebug;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblChannel;
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
        private System.Windows.Forms.Button btnNewConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Button btnCancelConnection;
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
        private System.Windows.Forms.TextBox txtTradeCommand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBalanceCommand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGambleCommand;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMessageUNPos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGreetingMsg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPointTickPerMinute;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPointsPerTick;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private CommandBotDataSet commandBotDataSet;
        private System.Windows.Forms.BindingSource iRCConnectionsBindingSource;
        private CommandBotDataSetTableAdapters.IRCConnectionsTableAdapter iRCConnectionsTableAdapter;
        private System.Windows.Forms.Button btnDeleteConnection;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBotMessageClear;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox lstMessageQue;
        private System.Windows.Forms.Label lblMessageTimer;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblPointTickTimer;
        private System.Windows.Forms.Timer timerPoints;
        private System.Windows.Forms.DataGridView gvUserAccounts;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private CommandBotDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inGameDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPointsEarnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSaveBotCommands;
        private System.Windows.Forms.Button btnPointStart;
        private System.Windows.Forms.Button btnSaveGreeting;
        private System.Windows.Forms.BindingSource commandBotDataSetBindingSource;
        private System.Windows.Forms.Button btnMembershipUpdate;
        private CommandBotDataSetTableAdapters.MembershipLevelsTableAdapter membershipLevelsTableAdapter;
        private CommandBotDataSetTableAdapters.SettingsTableAdapter settingsTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gvMembershipLevels;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Timer timerBotMessages;
        private System.Windows.Forms.Button btnPointInfoSave;
        private System.Windows.Forms.Button btnPointTimerReset;
        private System.Windows.Forms.GroupBox grpDrawings;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ListBox lstDrawings;
        private System.Windows.Forms.CheckBox cbDrawingAutoAdvertise;
        private System.Windows.Forms.TextBox txtDrawingAdvertiseInterval;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtDrawingCost;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtDrawingCongrats;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtDrawingAdvertisement;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtDrawingEntryCommand;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtDrawingGiveAwayName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnDrawingSave;
        private System.Windows.Forms.Button btnDrawingNew;
        private System.Windows.Forms.TextBox txtDrawingID;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnDrawingChooseWinner;
        private System.Windows.Forms.Button btnDrawingActivate;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ListBox lstRaffleEntries;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipLevelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn multiplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipLevelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource membershipLevelsBindingSource;
        private System.Windows.Forms.TextBox txtDrawingMaxTickets;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.BindingSource drawingsBindingSource;
        private CommandBotDataSetTableAdapters.DrawingsTableAdapter drawingsTableAdapter;
        private System.Windows.Forms.Button btnPointTest;
        private System.Windows.Forms.GroupBox grpDrawingsEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbwebdata;
        private System.Windows.Forms.PictureBox pictureBox1;
        
    }
}

