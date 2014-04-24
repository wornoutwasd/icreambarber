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
using IrcClientDemoCS.Classes.Twitch_Objects;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;

namespace IrcClientDemoCS
{
    public partial class MainForm : Form
    {
        //que https://api.twitch.tv/kraken/channels/wornoutwasd to get views/followers
        //que https://api.twitch.tv/kraken/channels/wornoutwasd/follows to get list of followers
        //que http://api.justin.tv/api/stream/summary.json?channel=wornoutwasd
        //que https://api.twitch.tv/kraken/chat/wornoutwasd/badges to get images associated with badges


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
        
        

        public MainForm()
        {

            InitializeComponent();



        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {

            btnSend.Enabled = false;
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
            
            //fires on event delegates
            
            irc.ChannelMessage += (c, u, m) =>
            {
                rtbOutput.AppendText(u + ":\t" + m + "\n");
                rtbOutput.ScrollToCaret();

                //respond to !coins request
                ChatBotMessage cbm = new ChatBotMessage();
                cbm.User = u;
                cbm.Channel = c;
                cbm.Message = "";
                //returns a point balance
                if(m.Contains(balancecmd))
                {
                    DataTable dt = new DataTable();
                    dt = usersTableAdapter.GetSpecificUserJoin(u);


                    cbm.Message = cbm.User + " your coin amount " + dt.Rows[0]["CurrentPoints"].ToString();;
                    AddQuedBotMessages(cbm);
                }
                //enters a giveaway
                if(m.Contains(activegiveawaycmd))
                {
                    //remove decimals to create ints for parsing
                    m.Replace('.', ' ');
                    string[] givearray = m.Split(' ');
                    int commandposition;
                    int entryamount = 0;
                    bool foundcmdposition = false;
                    bool validcmdformat = false;
                    bool validamount = false;
                    //find the command and the amount of tickets requested
                    for (int i = 0; i < givearray.Count(); i++)
                    {
                        if(givearray[i] == activegiveawaycmd)
                        {
                            commandposition = i;
                            foundcmdposition = true;
                            //check next item in array to see if it is a valid number
                            if(givearray.Count() - i > 1)//check this again
                            {
                                //check to see if that next item is a number
                                validcmdformat =Int32.TryParse(givearray[i+1], out entryamount);
                                if(validcmdformat == true)
                                {
                                    //if the item is a number make sure theyhave enough points to afford the number of tickets
                                    if (activegiveawaycost * entryamount < usersTableAdapter.ReturnUserPointValueQuery(u) && entryamount > 0)
                                    {
                                        double totalspent = entryamount * activegiveawaycost;
                                        //Inform user via messageque
                                        cbm.Message = u + ", You entered the contest and purchased " + entryamount.ToString() + " tickets at a cost of " + totalspent.ToString() + ". Goodluck!";
                                        AddQuedBotMessages(cbm);
                                        Enterdrawing(entryamount, u);
                                        //Subtract number of tickets - might have to add total variable - write query
                                        double result = Convert.ToDouble(usersTableAdapter.ReturnUserPointValueQuery(u)) - (Convert.ToDouble(entryamount) * activegiveawaycost);
                                        usersTableAdapter.UpdateUserPoints(result, u);
                                        usersTableAdapter.Fill(commandBotDataSet.Users);

                                    }
                                    else if(entryamount < 0)
                                    {
                                        cbm.Message = u + ", you can't buy negative tickets...";
                                        AddQuedBotMessages(cbm);
                                    }
                                    else
                                    {
                                        cbm.Message = u + ", you Can't afford that many tickets!";
                                        AddQuedBotMessages(cbm);
                                    }

                                }
                                else
                                {
                                    cbm.Message = u + ", you entered an invalid contest ticket amount. please use the correct command:![contestcommand] [#oftickets]";
                                    AddQuedBotMessages(cbm);
                                }
                            }
                            else
                            {
                                cbm.Message = u + ", you entered an invalid contest ticket amount. please use the correct command: ![contestcommand] [#oftickets]";
                                AddQuedBotMessages(cbm);
                            }
                            break;
                        }
                    }

                    if (foundcmdposition == true)
                    {

                    }
                    else
                    {
                        cbm.Message = cbm.User + " your giveaway entry request is not in the valid format";
                        AddQuedBotMessages(cbm);
                    }



                }
                //trades with a player
                if(m.Contains(tradecmd))
                {
                
                }
                //plays a gambling game
                if (m.Contains(gamblecmd))
                { 
                
                }


            };
            irc.ServerMessage += (m) =>
            {
                rtbOutput.AppendText(m + "\n");
                rtbOutput.ScrollToCaret();
            };
            irc.DebugChannelMessage += (m) =>
            {
                //items are thread dependent so I added a new delegate to the IRC class for the debug output that mirriors channel output before it is parced.
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
            string currenttime = DateTime.Now.ToString("H:mm");
            rtbOutput.AppendText(currenttime + " You:\t" + txtSend.Text + "\r\n");
            txtSend.Clear();
            txtSend.Focus();
        }
                

        

        private void btnTestSend_Click(object sender, EventArgs e)
        {
            
            //don't click this quickly.. you can get banned -dave
            //irc.SendMessage(channel, "TWITCHCLIENT 1");
            //irc.SendRAW("TWITCHCLIENT 1");
        }

        #endregion


        //**********Point Settings Tab Methods
        #region

        private void GeneratePoints()
        {
            DataTable dtuserinfo = new DataTable();
            //cycle through current users, find their membership level / multiplier, add points

            dtuserinfo = usersTableAdapter.GetUsersPoints();
            List<User> UsersList = new List<User>();

           //cycle through current users list, this assumes that current users are in the DB already (they should be added on join)
            for (int i = 0; i < lstUsers.Items.Count; i++)
            {
                double dblNewPoints;
                double dblNewTotalPoints;
                double dblCalculatedPoints;
                //get a table that cointains the user information
                dtuserinfo = usersTableAdapter.GetSpecificUserJoin(lstUsers.Items[i].ToString());
                //calcualte new values
                dblCalculatedPoints = Convert.ToDouble(dtuserinfo.Rows[0]["Multiplier"]) * Convert.ToDouble(pointspertick);
                dblNewPoints = Convert.ToDouble(dtuserinfo.Rows[0]["CurrentPoints"]) + dblCalculatedPoints;
                dblNewTotalPoints = Convert.ToDouble(dtuserinfo.Rows[0]["TotalPointsEarned"]) + dblCalculatedPoints;
                //Add points to that users
                usersTableAdapter.UpdateUserPointandTotalQuery(dblNewPoints, dblNewTotalPoints, dtuserinfo.Rows[0]["UserName"].ToString());

                usersTableAdapter.Fill(commandBotDataSet.Users);
                

            }
            
            
        }

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
                GeneratePoints();
            }
        }

        private void btnPointTimerReset_Click(object sender, EventArgs e)
        {
            intPointTimer = 60 * Convert.ToInt16(minutespertick);
        }

        private void btnPointTest_Click(object sender, EventArgs e)
        {
            GeneratePoints();
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



        //************User Accounts Tab Methods
        #region
        private void gvUserAccounts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //updates the row whenever a cell is changed.
            usersTableAdapter.UpdateQuery(Convert.ToInt16(gvUserAccounts.Rows[e.RowIndex].Cells[1].Value), Convert.ToDouble(gvUserAccounts.Rows[e.RowIndex].Cells[2].Value), Convert.ToBoolean(gvUserAccounts.Rows[e.RowIndex].Cells[3].Value), Convert.ToDouble(gvUserAccounts.Rows[e.RowIndex].Cells[4].Value), gvUserAccounts.Rows[e.RowIndex].Cells[0].Value.ToString(), gvUserAccounts.Rows[e.RowIndex].Cells[0].Value.ToString());
            //temp delete, trying to find out what is wiping the database
            usersTableAdapter.Fill(commandBotDataSet.Users);
            
        }

        private void gvUserAccounts_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            usersTableAdapter.DeleteQuery(e.Row.Cells[0].Value.ToString());
            //temp delete trying to figure out what is wiping the database.
            //usersTableAdapter.GetData();
            
            
        }


        #endregion


        //************Drawings Tab Methods
        #region


        private void lstDrawings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDrawings.SelectedIndex != -1)
            {
                txtDrawingGiveAwayName.Text = commandBotDataSet.Drawings.DataSet.Tables["Drawings"].Rows[lstDrawings.SelectedIndex]["GiveAwayName"].ToString();
                txtDrawingEntryCommand.Text = commandBotDataSet.Drawings.DataSet.Tables["Drawings"].Rows[lstDrawings.SelectedIndex]["EntryCommand"].ToString();
                txtDrawingAdvertisement.Text = commandBotDataSet.Drawings.DataSet.Tables["Drawings"].Rows[lstDrawings.SelectedIndex]["Advertisement"].ToString();
                txtDrawingCongrats.Text = commandBotDataSet.Drawings.DataSet.Tables["Drawings"].Rows[lstDrawings.SelectedIndex]["Congratulations"].ToString();
                txtDrawingCost.Text = commandBotDataSet.Drawings.DataSet.Tables["Drawings"].Rows[lstDrawings.SelectedIndex]["Cost"].ToString();
                txtDrawingAdvertiseInterval.Text = commandBotDataSet.Drawings.DataSet.Tables["Drawings"].Rows[lstDrawings.SelectedIndex]["AdvertiseInterval"].ToString();
                cbDrawingAutoAdvertise.Checked = Convert.ToBoolean(commandBotDataSet.Drawings.DataSet.Tables["Drawings"].Rows[lstDrawings.SelectedIndex]["AutoAdvertise"]);
                txtDrawingMaxTickets.Text = commandBotDataSet.Drawings.DataSet.Tables["Drawings"].Rows[lstDrawings.SelectedIndex]["MaxTickets"].ToString();
                txtDrawingID.Text = commandBotDataSet.Drawings.DataSet.Tables["Drawings"].Rows[lstDrawings.SelectedIndex]["Id"].ToString();
            }
        }


        private void Enterdrawing(int entries, string user)
        {
            for (int i = 0; i < entries; i++)
            {
                lstRaffleEntries.Items.Add(user);
            }
        
        }

        #endregion



        private void btnDrawingActivate_Click(object sender, EventArgs e)
        {
            if (giveawayactive == false)
            {
                giveawayactive = true;
                lstDrawings.Enabled = false;
                grpDrawingsEdit.Enabled = false;
                btnDrawingActivate.Text = "Deactivate Drawing";
                activegiveawaycmd = txtDrawingEntryCommand.Text;
                activegiveawaycost = Convert.ToInt16(txtDrawingCost.Text);
            }
            else
            {
                giveawayactive = false;
                lstDrawings.Enabled = true;
                grpDrawingsEdit.Enabled = true;
                btnDrawingActivate.Text = "Activate Drawing";
                activegiveawaycmd = "ON@)(#*H:O@!NP(";//yup
                activegiveawaycost = 0;
            }
            
        }

        private void btnDrawingChooseWinner_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int max = lstRaffleEntries.Items.Count;
            if (max != 0)
            {
                int winner = r.Next(0, max);
                lstRaffleEntries.SelectedIndex = winner;

                
            }

            //popup to complete later

            //Raffle d = new Raffle();
            //ListBox l = new ListBox();
            //foreach (string item in lstRaffleEntries.Items)
            //{
            //    l.Items.Add(item);
            //}
            //l.Location = new Point(0, 0);

            ////d.Controls.Add(l);
            //d.Show();

            
            
        }
        //***************Graphic Alerts

        #region
        private void button1_Click(object sender, EventArgs e)
        {
            string currtime = DateTime.Now.ToString("H:mm");
            string strHTML = webBrowser1.DocumentText;
            Image img = Image.FromFile(@"C:\Users\DavidServer\Documents\GitHub\icreambarber\IrcClientDemoCS\IrcClientDemoCS\Resources\ViewerIcon.png");

            strHTML += currtime + " " + "<img src=\"C:\\Users\\DavidServer\\Documents\\GitHub\\icreambarber\\IrcClientDemoCS\\IrcClientDemoCS\\Resources\\ViewsIcon.png\">" + " Message Goes HereMessage Goes HereMessage Goes HereMessage Goes Here " + "<button type=\"button\" submit=\"button1_Click()\">Click Me!</button>" + "<br>";
            webBrowser1.DocumentText = strHTML;
            
            ScrollToBottom();
        }

        private void ScrollToBottom()
        {
            // MOST IMP : processes all windows messages queue
            Application.DoEvents();

            if (webBrowser1.Document != null)
            {
                webBrowser1.Document.Window.ScrollTo(0, webBrowser1.Document.Body.ScrollRectangle.Height);
            }
        }

    
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            StreamInfo c = new StreamInfo();
            c.Size = new System.Drawing.Size(250, 25);
            c.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            PopOutChat p = new PopOutChat();
            RichTextBox r = new RichTextBox();
            r.Text = rtbOutput.Text;
            //p.Controls.Add(r);
            p.Show();
        }

        int panelx = 50;
        int panely = -150;
        private void timerTest_Tick(object sender, EventArgs e)
        {
            panely++;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PopoutNotifaction p = new PopoutNotifaction();
            p.Show();
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        







    }
}