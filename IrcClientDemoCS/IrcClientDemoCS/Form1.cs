using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TechLifeForum;

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
        public string Server = "";
        public static int intConnPort;
        
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
            irc = new IrcClient("irc.twitch.tv", 6667);
            irc.Nick = "wornoutbot";
            irc.ServerPass = "oauth:5apvk3gardkvm4ekpp1wdf5vazso8jq";
            irc.Disconnect();
            if (Listening == false) AddListeners();
            
            irc.Connect();
        }
        private void AddListeners()
        {
            // hopefully these are self explanitory
            // you can also subscribe to events
            // using a regular method that accepted
            // the required parameters
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
            irc.OnConnect += () =>
            {
                // once we're connected show it and enable the send button
                rtbOutput.AppendText("Connected!\n");
                irc.JoinChannel("#wornoutwasd");
                btnSend.Enabled = true;
            };
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            irc.SendMessage("#wornoutwasd", txtSend.Text);
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

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionsForm c1 = new ConnectionsForm();
            c1.ShowDialog(); //shows manage window
        }
    }
}