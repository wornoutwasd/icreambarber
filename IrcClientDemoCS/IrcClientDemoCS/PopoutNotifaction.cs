using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Net;
using Newtonsoft.Json;
using System.Web;

using IrcClientDemoCS.Classes.Twitch_Objects;



namespace IrcClientDemoCS
{
    public partial class PopoutNotifaction : Form
    {
        int followerPanelHeight = 100;
        int followerPanelWidth = 800;
        int donationPanelHeight = 100;
        int donationPanelWidth = 800;
        int followerAnimationSeconds = 1;
        int followerAnimantionDwell = 3;
        int donationAnimationSeconds = 1;
        int donationAnimantionDwell = 3;
        string newFollowerText = "[Name] Just Followed!";
        string newDonatorText = "[Name] Just Donated!";
        int panelystart = 0;
        int panelxstart = 0;
        public DateTime lastfollowtime = Convert.ToDateTime("2014-04-22T03:48:52Z");
        public DateTime lastdonationtime = Convert.ToDateTime("2014-04-22T03:48:52Z");
        string streamdonationsdotnetAPIKey = "ZDI1YjljNjkxYmM4MDgwNTE1ZWU3Yzdh";
        string streamdonationchannel = "wornoutwasd";
        List<GraphicPopup> popupQue = new List<GraphicPopup>();
        public Image panelBackgroundFollower = Image.FromFile(@"C:\Users\DavidServer\Documents\GitHub\icreambarber\IrcClientDemoCS\IrcClientDemoCS\Resources\wornWASD.png");
        public Image panelBackgroundDonation = Image.FromFile(@"C:\Users\DavidServer\Documents\GitHub\icreambarber\IrcClientDemoCS\IrcClientDemoCS\Resources\Dollars2.png");
        public PopoutNotifaction()
        {

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 50);
            InitializeComponent();
            
            pictureBox1.Visible = false;
            timerPolling.Start();
            //sets the panel out of the visible form and centers it
            followerpanelreset();
            //timerPopupQue.Interval = (((followerAnimationSeconds*2) + followerAnimantionDwell) * 1000) + 1000;
            timerPopupQue.Interval = ((followerAnimationSeconds + followerAnimantionDwell) * 2) * 1000;
            timerPopupQue.Start();
        }



        //***** These methods are to enable dragging of the window from form click
        #region
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void PopoutNotification_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void PopoutNotification_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void PopoutNotification_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            
        }
        #endregion



        //start animation for panel
        private void followerGraphic(string name, int animationseconds, int animationdwell)
        {
            
            //set initial interval for animation timer
            int interval = animationseconds * 1000 / followerPanelHeight;
            timerFollowerGraphic.Interval = interval;
            
            //center label
            label1.Location = new Point((panel1.Width - label1.Width) / 2, 20);
            //begins graphic
            timerFollowerGraphic.Start();
        }

        private void playfollowersound()
        {
            //plays a sound
            SoundPlayer s = new SoundPlayer(@"C:\Users\DavidServer\Documents\GitHub\icreambarber\IrcClientDemoCS\IrcClientDemoCS\Resources\Follwer.wav");
            s.Play();
        }
        private void playDonatorsound()
        {
            //plays a sound
            SoundPlayer s = new SoundPlayer(@"C:\Users\DavidServer\Documents\GitHub\icreambarber\IrcClientDemoCS\IrcClientDemoCS\Resources\Cha_Ching_Register.wav");
            s.Play();
        }
        int followerGraphicTickCount = 0;
        //animation
        private void timerFollowerGraphic_Tick(object sender, EventArgs e)
        {
            followerGraphicTickCount++;
            if (followerGraphicTickCount < followerPanelHeight)
            {
                followerGraphicMoveDown();
            }
            
            if (followerGraphicTickCount == followerPanelHeight)
            {
                timerFollowerGraphic.Interval = followerAnimantionDwell * 1000;
                
            }
            if (followerGraphicTickCount > followerPanelHeight && followerGraphicTickCount < followerPanelHeight * 2)
            {
                int interval = followerAnimationSeconds * 1000 / followerPanelHeight;
                timerFollowerGraphic.Interval = interval;
                followerGraphicMoveUp();

            }
            if (followerGraphicTickCount > followerPanelHeight * 2)
            {
                timerFollowerGraphic.Stop();
                followerGraphicTickCount = 0;
                followerpanelreset();

            }
        }
        //move down
        private void followerGraphicMoveDown()
        {
            panel1.Location = new Point(panelxstart, panel1.Location.Y + 1);
            panel1.Invalidate();
            Invalidate();
        }
        //move up
        private void followerGraphicMoveUp()
        {
            panel1.Location = new Point(panelxstart, panel1.Location.Y - 2);
            panel1.Invalidate();
            Invalidate();
        }
        //reset position of panel
        private void followerpanelreset()
        {
            panelystart = followerPanelHeight * -1;
            panelxstart = (this.ClientRectangle.Width - followerPanelWidth) / 2;
            panel1.Location = new Point(panelxstart, panelystart);
        }


        private void MakeItRain()
        {
            pictureBox1.Visible = true;
            pictureBox1.Dock = DockStyle.Fill;
            timerGraphic.Start();
        }

        private void timerGraphic_Tick(object sender, EventArgs e)
        {
            timerGraphic.Interval = 11800;
            timerGraphic.Stop();
            pictureBox1.Visible = false;

        }

        
        private void timerPolling_Tick(object sender, EventArgs e)
        {
            //check every 30 seconds
            timerPolling.Interval = 30000;
            WebClient client = new WebClient();

            string channelname = "wornoutwasd";

            //new followers graphic
            #region
            //poll twitch api for follwers
            //try catch is for 503 errors etc.
            try 
            { 
                string followsSummaryString = client.DownloadString("https://api.twitch.tv/kraken/channels/" + channelname + "/follows");
                //parce follwers from serialized data
                var follows = JsonConvert.DeserializeObject<Twitch_Objects.RootObject>(followsSummaryString);
            
                List<Twitch_Objects.Follow> lstfollows = new List<Twitch_Objects.Follow>();
                //save the follows that are newer than the last follow time
                for (int i = 0; i < follows.follows.Count; i++)
                {

                    if (Convert.ToDateTime(follows.follows[i].created_at) > lastfollowtime)
                    {
                        lstfollows.Add(follows.follows[i]);
                    
                    }
                }
                //store the newest follow time to compare against for next round
                lastfollowtime = Convert.ToDateTime(follows.follows[0].created_at);
                //make a que for the names
                foreach (Twitch_Objects.Follow f in lstfollows)
                {
                    GraphicPopup g = new GraphicPopup();
                    g.name = f.user.display_name;
                    g.time = f.created_at;
                    g.type = "Follow";
                    popupQue.Add(g);
                }

            }

            catch
            {
                //note in DB
            }
            // do things with the names

            #endregion
            //donation tracker
            #region
            //https://www.streamdonations.net/api/poll?channel=wornoutwasd&key=ZDI1YjljNjkxYmM4MDgwNTE1ZWU3Yzdh
            //{"status":"success","top":[{"channel":"wornoutwasd","date":"2014-04-12T15:28:26.584Z","processor":"Manual","transactionID":"MANUAL15719004573","firstName":"Justin","lastName":"Goetz","twitchUsername":"Justin_417","email":null,"currencyCode":"USD","currencySymbol":"$","amount":"5.00","dollars":5,"cents":0,"note":"updated","_id":"53495b9a468d790000000dbb"}],"mostRecent":[{"channel":"wornoutwasd","date":"2014-04-12T15:28:26.584Z","processor":"Manual","transactionID":"MANUAL15719004573","firstName":"Justin","lastName":"Goetz","twitchUsername":"Justin_417","email":null,"currencyCode":"USD","currencySymbol":"$","amount":"5.00","dollars":5,"cents":0,"note":"updated","_id":"53495b9a468d790000000dbb"}]}
            //try catch is for 503 errors etc.
            try
            {
                string donationsSummaryString = client.DownloadString("https://www.streamdonations.net/api/poll?channel=" + streamdonationchannel + "&key=" + streamdonationsdotnetAPIKey);
                //parce follwers from serialized data
                //var items = JsonConvert.DeserializeObject<Dictionary<string, object>>(donationsSummaryString);
                List<Stream_Donations_net_Objects.donation> lstDonations = new List<Stream_Donations_net_Objects.donation>();
                var streamdonations = JsonConvert.DeserializeObject<Stream_Donations_net_Objects.rootObject>(donationsSummaryString);
                for (int j = 0; j < streamdonations.mostRecent.Count; j++)
                { 
                    if(Convert.ToDateTime(streamdonations.mostRecent[j].date) > lastdonationtime)
                    {
                        lstDonations.Add(streamdonations.mostRecent[j]);
                    
                    }
                }
                lastdonationtime = Convert.ToDateTime(streamdonations.mostRecent[0].date);
                foreach (Stream_Donations_net_Objects.donation don in lstDonations)
                {
                    GraphicPopup g = new GraphicPopup();
                    g.name = don.twitchUsername;
                    g.time = don.date;
                    g.type = "Donation";
                    popupQue.Add(g);
                }

            }

            catch
            {
                //note in db
            }

            #endregion
        }

        private void timerPopupQue_Tick(object sender, EventArgs e)
        {
            if (popupQue.Count > 0)
            {
                if (popupQue[0].type == "Follow")
                {
                    //sets lable name
                    label1.Text = newFollowerText.Replace("[Name]", popupQue[0].name);
                    panel1.BackgroundImage = panelBackgroundFollower;
                    followerGraphic(popupQue[0].name, 1, 3);
                    playfollowersound();
                }
                else
                {
                    label1.Text = newDonatorText.Replace("[Name]", popupQue[0].name);
                    panel1.BackgroundImage = panelBackgroundDonation;
                    followerGraphic(popupQue[0].name, 1, 3);
                    playDonatorsound();
                }
                //listBox1.Items.RemoveAt(0);
                popupQue.RemoveAt(0);
            }
        }

        private void followerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphicPopup g = new GraphicPopup();
            g.name = "Test";
            g.time = "2014-04-22T03:48:52Z";
            g.type = "Follow";
            popupQue.Add(g);
        }

        private void donationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphicPopup g = new GraphicPopup();
            g.name = "Test";
            g.time = "2014-04-22T03:48:52Z";
            g.type = "Donation";
            popupQue.Add(g);
        }

        private void resetPositionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void savePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopoutNotifaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            settingsTableAdapter1.UpdateGraphicIndicatorQuery(false, 1);
        }

        




    }
}
