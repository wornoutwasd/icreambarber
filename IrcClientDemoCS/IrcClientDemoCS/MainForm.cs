using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TechLifeForum;
using System.Threading;
using System.Data.SqlClient;
using System.Collections;
using IrcClientDemoCS.Classes;

namespace IrcClientDemoCS
{
    public partial class MainForm : Form
    {
        //Varibles
        IrcClient irc;
        Boolean Listening = false;
        private static int ConnPort;
        private static string serverName;
        private static string channel;
        private static string user;
        private static string oauth;
        private static string greeting;
        private static string balancecmd;
        private static string tradecmd;
        private static string gamblecmd;
        private static string greetingposition;
        private static string pointspertick;
        private static string minutespertick;
        DataTable dt = new DataTable();
        private static int intPointTimer;
        private static int intMessageQueTimer = 20;
        private static List<ChatBotMessage> listChatBotMessageQue = new List<ChatBotMessage>();

        public MainForm()
        {

            InitializeComponent();



        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            //***Table Adapters
            #region
            // TODO: This line of code loads data into the 'commandBotDataSet.MembershipLevels' table. You can move, or remove it, as needed.
            this.membershipLevelsTableAdapter.Fill(this.commandBotDataSet.MembershipLevels);
            dt = this.membershipLevelsTableAdapter.GetData();
            
            // TODO: This line of code loads data into the 'commandBotDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.commandBotDataSet.Users);

            //**Load Default Connection Information - Comment this out if your DB is not setup yet
            this.iRCConnectionsTableAdapter.Fill(this.commandBotDataSet.IRCConnections);

            #endregion


            //*********Initilization Values
            #region
            //**********Connections Tab / initial conneciton settings
            #region
            // TODO: This line of code loads data into the 'commandBotDataSet.IRCConnections' table. You can move, or remove it, as needed.

            serverName = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["ServerAddress"].ToString();
            channel = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["Channel"].ToString();
            ConnPort = Convert.ToInt16(commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["Port"].ToString());
            oauth = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["OAuth"].ToString();
            user = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["User"].ToString();
            txtServer.Text = serverName;
            txtChannel.Text = channel;
            txtmPort.Text = ConnPort.ToString();
            txtOauth.Text = oauth;
            txtUser.Text = user;
            cbDefault.Checked = Convert.ToBoolean(commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["DefaultServer"]);
            #endregion



            //*********Chat Tab
            #region
            lblChannel.Text = channel;
            lblCurrentServer.Text = serverName;
            lblPort.Text = ConnPort.ToString();
            lblUserName.Text = user;
            #endregion



            //**************Bot Commands Tab
            #region
            //Current default - pull from database            
            this.settingsTableAdapter.Fill(this.commandBotDataSet.Settings);
            
            //initialize bot message timer
            //--this is to keep the bot from getting banned for spamming.
            timerBotMessages.Interval = 100;
            timerBotMessages.Start();

            //set selected value
            if (commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["GreetingPosition"].ToString() == "Before")
            {
                cboMessageUNPos.SelectedIndex = 0;
            }
            else
            {
                cboMessageUNPos.SelectedIndex = 1;
            }

            greeting = commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["Greeting"].ToString();
            balancecmd = commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["BalanceCommand"].ToString();
            gamblecmd = commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["GambleCommand"].ToString();            
            tradecmd = commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["TradeCommand"].ToString();

            txtGreetingMsg.Text = greeting;
            txtBalanceCommand.Text = balancecmd;
            txtGambleCommand.Text = gamblecmd;
            txtTradeCommand.Text = tradecmd;


            #endregion
            //***************Point Settings Tab
            #region

            //Settings table adapter already connected in the bot commands tab in the region above
            pointspertick = commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["PointsPerTick"].ToString();
            minutespertick = commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["TickMinutes"].ToString();

            txtPointsPerTick.Text = pointspertick;
            txtPointTickPerMinute.Text = minutespertick;


            #endregion
            //*************Gridview Datasets
            #region
            
            membershipLevelsTableAdapter.Fill(this.commandBotDataSet.MembershipLevels);
            dt = commandBotDataSet.MembershipLevels;

            //dgvMembership.DataSource = dt;
            #endregion
            #endregion

        }


        //***********Chat tab methods
        #region
        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
                //this is to stop the annoying "Ding" when enter pressed.
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            irc = new IrcClient(serverName, ConnPort);
            irc.Nick = user;
            irc.ServerPass = oauth;            
            irc.Disconnect();
            irc.Connect();
            

            if (Listening == false) AddListeners();
            
            
            
        }
        //fires when event delegates from IRC thread are accessed.
        private void AddListeners()
        {
            //each of these listens for the event delegates and fires the methods below.
            irc.OnConnect += () =>
            {
                // once we're connected show it and enable the send button
                rtbOutput.AppendText("Connected!\n");
                
                irc.JoinChannel(channel);
                //irc.JoinChannel("#wornoutwasd");
                btnSend.Enabled = true;
            };

            Listening = true;
            
            //confusing as fuck
            irc.ChannelMessage += (c, u, m) =>
            {
                rtbOutput.AppendText(u + ":\t" + m + "\n");
                rtbOutput.ScrollToCaret();
                ChatBotMessage cbm = new ChatBotMessage();
                cbm.User = u;
                cbm.Channel = c;
                cbm.Message = "";

                if(m.Contains("!coins"))
                {
                    cbm.Message = cbm.User + " your coin amount is_Insert_Coin_Value_Here";
                    AddQuedBotMessages(cbm);
                }
            };
            irc.ServerMessage += (m) =>
            {
                rtbOutput.AppendText(m + "\n");
                rtbOutput.ScrollToCaret();
            };
            irc.DebugChannelMessage += (m) =>
            {
                //can't get this to work because it is not in the right thread? how do you add it to thread?
                rtbDebug.AppendText(m + "\n");
                rtbDebug.ScrollToCaret();

            };
            irc.UpdateUsers += (c, u) =>
            {
                lstUsers.Items.Clear();
                lstUsers.Items.AddRange(u);
            };
            //update users only works on initial load, adding userjoined / left -dave
            irc.UserJoined += (c, u) =>
            {
                //add to active users

                lstUsers.Items.Add(u);
                usersTableAdapter.InsertQuery(u);
                usersTableAdapter.Fill(commandBotDataSet.Users);
                //add a welcome message to the message que
                ChatBotMessage cb = new ChatBotMessage();
                cb.Channel = c;
                cb.User = u;

                if (greetingposition == "Before")
                {
                    cb.Message = u + greeting;
                }
                else 
                {
                    cb.Message = greeting + u;
                }
                
                AddQuedBotMessages(cb);
                //irc.SendMessage(channel, "Welcome!" + u);
            };
            irc.UserLeft += (c, u) =>
            {
                //remove from active users
                lstUsers.Items.Remove(u);
            };

            irc.ExceptionThrown += (ex) =>
            {
                MessageBox.Show(ex.Message);
            };
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //does not submit to debug because it is outside of that fire event - add delegate to sendmessage maybe? -dave

            irc.SendMessage(channel, txtSend.Text);
            rtbOutput.AppendText("You:\t" + txtSend.Text + "\r\n");
            txtSend.Clear();
            txtSend.Focus();
        }
                

        

        private void btnTestSend_Click(object sender, EventArgs e)
        {
            //don't click this quickly.. you can get banned -dave
            irc.SendMessage(channel, "Welcome!");
        }

        #endregion


        //**********Point Settings Tab Methods
        #region
        private void btnMembershipUpdate_Click(object sender, EventArgs e)
        {
            
        }

        //**********Doesn't work
        private void membershipLevelsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        
            
        }


        private void btnPointInfoSave_Click(object sender, EventArgs e)
        {
            //set the static form values
            pointspertick = txtPointsPerTick.Text;
            minutespertick = txtPointTickPerMinute.Text;
            int intminutepertick = Convert.ToInt16(minutespertick);
            //update db
            settingsTableAdapter.UpdatePointSettings(Convert.ToDouble(pointspertick), intminutepertick, 1);
            settingsTableAdapter.Fill(commandBotDataSet.Settings);
            //inform user
            MessageBox.Show("The points per tick: " + commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["PointsPerTick"].ToString() + " was added to the local database" + Environment.NewLine
            + "The Minutes per tick: " + commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["TickMinutes"].ToString() + " was added to the local database", 
            "Updated Point Settings", MessageBoxButtons.OK);
   
        }
        //starts the timer for points
        private void btnPointStart_Click(object sender, EventArgs e)
        {
            if (timerPoints.Enabled == true)
            {
                timerPoints.Enabled = false;
                timerPoints.Stop();
                btnPointStart.Text = "Start";
            }
            else
            {
                timerPoints.Enabled = true;
                timerPoints.Interval = 1000;
                timerPoints.Start();
                intPointTimer = 60 * Convert.ToInt16(minutespertick);
                btnPointStart.Text = "Stop";
            }
            
        }

        private void timerPoints_Tick(object sender, EventArgs e)
        {
            //countdown timer label
            TimeSpan t = TimeSpan.FromSeconds(intPointTimer);
            lblPointTickTimer.Text = t.ToString();
            //reset after time is reached
            intPointTimer--;
            if (intPointTimer < 0)
            {
                intPointTimer = 60 * Convert.ToInt16(minutespertick);
                // => method to save points
            }
        }

        private void btnPointTimerReset_Click(object sender, EventArgs e)
        {
            intPointTimer = 60 * Convert.ToInt16(minutespertick);
        }
        #endregion


        //**********Bot Messages Tab Methods
        #region

        private void btnSaveGreeting_Click(object sender, EventArgs e)
        {
            //set the static form values
            greeting = txtGreetingMsg.Text;
            greetingposition = cboMessageUNPos.Text;
            //update db
            settingsTableAdapter.UpdateGreeting(txtGreetingMsg.Text, cboMessageUNPos.Text, 1);
            settingsTableAdapter.Fill(commandBotDataSet.Settings);
            //inform user
            MessageBox.Show("The Greeting: " + commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["Greeting"].ToString() + "was added to the local database" + Environment.NewLine +  "The position of the username in the greeting is: " + commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["GreetingPosition"].ToString(), "Updated Greeting", MessageBoxButtons.OK);
        }

        private void btnSaveBotCommands_Click(object sender, EventArgs e)
        {
            //set the static form values
            balancecmd = txtBalanceCommand.Text;
            gamblecmd = txtGambleCommand.Text;
            tradecmd = txtTradeCommand.Text;
            //update db
            settingsTableAdapter.UpdateDefaultBotCommands(txtBalanceCommand.Text, txtGambleCommand.Text, txtTradeCommand.Text, 1);
            settingsTableAdapter.Fill(commandBotDataSet.Settings);
            //inform user
            MessageBox.Show("The Balance Command: " + commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["BalanceCommand"].ToString() + " was added to the local database" + Environment.NewLine
            + "The Trade Command: " + commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["TradeCommand"].ToString() + " was added to the local database" + Environment.NewLine
            + "The Gamble Command: " + commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["GambleCommand"].ToString() + " was added to the local database" + Environment.NewLine, 
            "Updated Bot Commands", MessageBoxButtons.OK);

        }
        private void btnBotMessageClear_Click(object sender, EventArgs e)
        {
            lstMessageQue.Items.Clear();
            listChatBotMessageQue.Clear();
        }

        private void AddQuedBotMessages(ChatBotMessage cbm)
        {
            listChatBotMessageQue.Add(cbm);
            lstMessageQue.Items.Add(cbm.Message);            
        }
        private void executeQuedBotMessage()
        {
            if (lstMessageQue.Items.Count > 0)
            {
                irc.SendMessage(channel, listChatBotMessageQue[0].Message);
                listChatBotMessageQue.RemoveAt(0);
                lstMessageQue.Items.RemoveAt(0);
            }
        }
        private void timerBotMessages_Tick(object sender, EventArgs e)
        {
            TimeSpan t = TimeSpan.FromMilliseconds(intMessageQueTimer * 100);
            lblMessageTimer.Text = String.Format("{0:s\\.f}", t);
            intMessageQueTimer--;
                       
            if (intMessageQueTimer < 0) intMessageQueTimer = 20;
            if (intMessageQueTimer == 0) executeQuedBotMessage();
        }

        #endregion




       







    }
}