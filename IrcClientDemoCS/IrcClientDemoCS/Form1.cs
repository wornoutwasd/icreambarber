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
    public partial class Form1 : Form
    {
        public Form1()
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
            // hopefully these are self explanitory
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

            irc.UpdateUsers += (c, u) =>
            {
                lstUsers.Items.Clear();
                lstUsers.Items.AddRange(u);
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
    }
}