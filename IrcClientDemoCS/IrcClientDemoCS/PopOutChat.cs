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

using System.Net;
using System.Media;
using Newtonsoft.Json;


namespace IrcClientDemoCS
{
    public partial class PopOutChat : Form
    {

        public PopOutChat()
        {
            InitializeComponent();
            timer1.Start();
        }

        //Movement
        #region
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void PopOutChat_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void PopOutChat_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void PopOutChat_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Interval = 10000;
            
                
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //que https://api.twitch.tv/kraken/channels/wornoutwasd to get views/followers
        //que https://api.twitch.tv/kraken/channels/wornoutwasd/follows to get list of followers
        //que http://api.justin.tv/api/stream/summary.json?channel=wornoutwasd

        //Varibles

        public delegate void delPassData(RichTextBox text);

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
        private static string activegiveawaycmd = "(BF)#@:QAHS()DHP!@#$";//yup
        private static string activegiveawayname;
        private static int activegiveawaycost;
        private static bool giveawayactive = false;
        DataTable dt = new DataTable();
        private static int intPointTimer;
        private static int intMessageQueTimer = 20;
        private static List<ChatBotMessage> listChatBotMessageQue = new List<ChatBotMessage>();

        

        

        
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            
            // TODO: This line of code loads data into the 'commandBotDataSet.Drawings' table. You can move, or remove it, as needed.
            this.drawingsTableAdapter.Fill(this.commandBotDataSet.Drawings);
            
            //***Table Adapters
            #region
            // TODO: This line of code loads data into the 'commandBotDataSet.MembershipLevels' table. You can move, or remove it, as needed.
            this.membershipLevelsTableAdapter.Fill(this.commandBotDataSet.MembershipLevels);
            //dt = this.membershipLevelsTableAdapter.GetData();
            
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
            
            #endregion



            //*********Chat Tab
            #region
            
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
            

            greeting = commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["Greeting"].ToString();
            balancecmd = commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["BalanceCommand"].ToString();
            gamblecmd = commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["GambleCommand"].ToString();            
            tradecmd = commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["TradeCommand"].ToString();

            


            #endregion
            //***************Point Settings Tab
            #region

            //Settings table adapter already connected in the bot commands tab in the region above
            pointspertick = commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["PointsPerTick"].ToString();
            minutespertick = commandBotDataSet.Settings.DataSet.Tables["Settings"].Rows[0]["TickMinutes"].ToString();

            


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
            button1.Visible = false;
            
            
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
                
            };

            Listening = true;
            
            //fires on event delegates
            
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
                //items are thread dependent so I added a new delegate to the IRC class for the debug output that mirriors channel output before it is parced.
                

            };
            irc.UpdateUsers += (c, u) =>
            {
                
            };
            //update users only works on initial load, adding userjoined / left -dave
            irc.UserJoined += (c, u) =>
            {
                //add to active users

                
                //inserts user if they are not in the database already
                usersTableAdapter.InsertQuery1(u);
                
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
                
                
                //irc.SendMessage(channel, "Welcome!" + u);
            };
            irc.UserLeft += (c, u) =>
            {
                //remove from active users
                
            };

            irc.ExceptionThrown += (ex) =>
            {
                MessageBox.Show(ex.Message);
            };
            
        }

        
        
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void savePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



 



    }
}

