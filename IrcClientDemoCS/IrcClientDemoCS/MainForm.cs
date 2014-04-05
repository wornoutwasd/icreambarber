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
        public MainForm()
        {
            InitializeComponent();
        }
        IrcClient irc;
        Boolean Listening = false;
        private static int intConnPort;
        private static string serverName;
        private static string channel;
        private static string user;
        private static string oauth;
        

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
            irc = new IrcClient(serverName, intConnPort);
            irc.Nick = user;
            irc.ServerPass = oauth;
            /*irc = new IrcClient("irc.twitch.tv", 6667);
            irc.Nick = "wornoutbot";
            irc.ServerPass = "oauth:5apvk3gardkvm4ekpp1wdf5vazso8jq";*/
            irc.Disconnect();
            irc.Connect();
            

            if (Listening == false) AddListeners();
            
            
            
        }
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
            //irc.SendMessage("#wornoutwasd", txtSend.Text);
            irc.SendMessage(channel, txtSend.Text);
            rtbOutput.AppendText("You:\t" + txtSend.Text + "\r\n");
            txtSend.Clear();
            txtSend.Focus();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblCurrentServer.Text = Convert.ToString(intConnPort);
            updateLabels();
 
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            irc.Disconnect();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionsForm c1 = new ConnectionsForm();
            c1.ShowDialog(); //shows connection management window
            if (c1.DialogResult == DialogResult.OK)
            {
                intConnPort = c1.getPort();
                serverName = c1.getServer();
                channel = c1.getChannel();
                user = c1.getUser();
                oauth = c1.getOauth();
            }
        }

        public void updateLabels()
        {
            
            lblChannel.Text = channel;
            lblCurrentServer.Text = serverName;
            lblPort.Text = intConnPort.ToString();
            lblUserName.Text = user;
        }

        //Menu Items
        #region
        private void botMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BotMessagesForm b1 = new BotMessagesForm();
            b1.ShowDialog();//shows bot messages form
            
        }

        private void userAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccountsForm ua1 = new UserAccountsForm();
            ua1.ShowDialog();
        }

        private void pointSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PointSettingsForm ps1 = new PointSettingsForm();
            ps1.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawingsForm df1 = new DrawingsForm();
            df1.ShowDialog();
        }

        private void graphicAlertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphicAlertsForm ga1 = new GraphicAlertsForm();
            ga1.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af1 = new AboutForm();
            af1.ShowDialog();
        }
        #endregion

        private void btnTestSend_Click(object sender, EventArgs e)
        {
            irc.SendMessage(channel, "Welcome!");
        }


    }
}