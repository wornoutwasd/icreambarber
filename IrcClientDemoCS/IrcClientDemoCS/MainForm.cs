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
        private static bool greetingposition;
        private static string pointspertick;
        private static string minutespertick;
        DataTable dt = new DataTable();

        public MainForm()
        {

            InitializeComponent();



        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'commandBotDataSet.MembershipLevels' table. You can move, or remove it, as needed.
            this.membershipLevelsTableAdapter.Fill(this.commandBotDataSet.MembershipLevels);
            // TODO: This line of code loads data into the 'commandBotDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.commandBotDataSet.Users);
            
            //**Load Default Connection Information - Comment this out if your DB is not setup yet
            this.iRCConnectionsTableAdapter.Fill(this.commandBotDataSet.IRCConnections);
            serverName = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["ServerAddress"].ToString();
            channel = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["Channel"].ToString();
            ConnPort = Convert.ToInt16(commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["Port"].ToString());
            oauth = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["OAuth"].ToString();
            user = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["User"].ToString();
            


            //**********Connections Tab
            #region
            // TODO: This line of code loads data into the 'commandBotDataSet.IRCConnections' table. You can move, or remove it, as needed.

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
            dgvMembership.DataSource = dt;
            #endregion


        }
       
        

        public void debugupdate(string dbupdate)
        { 
            
        }

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
            // hopefully these are self explanitory (nope)
            // you can also subscribe to events
            // using a regular method that accepted
            // the required parameters
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
                lstUsers.Items.Add(u);
                irc.SendMessage(channel, "Welcome!" + u);
            };
            irc.UserLeft += (c, u) =>
            {
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

        //private void btnMembershipUpdate_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.Validate();
        //        this.membershipLevelsBindingSource.EndEdit();

        //        //this.membershipLevelsTableAdapter.Update();          
                
        //        MessageBox.Show("Update successful");
        //    }
        //    catch (System.Exception ex)
        //    {
        //        MessageBox.Show("Update failed " + ex.ToString());
        //    }
        //}

        private void btnMembershipUpdate_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void commandBotDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnMembershipUpdate_Click(object sender, EventArgs e)
        {
           
        }




    }
}