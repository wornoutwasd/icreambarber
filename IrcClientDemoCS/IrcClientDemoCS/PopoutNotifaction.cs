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
        int panelystart = 0;
        int panelxstart = 0;


        public PopoutNotifaction()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            timerPolling.Start();
            //sets the panel out of the visible form and centers it
            followerpanelreset();

        }



        //***** These methods are to enable dragging of the window from form click
        #region
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void PopoutNotification_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;

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


        private void button1_Click(object sender, EventArgs e)
        {
            ////plays a sound
            //SoundPlayer s = new SoundPlayer(@"C:\Users\DavidServer\Documents\GitHub\icreambarber\IrcClientDemoCS\IrcClientDemoCS\Resources\Follwer.wav");
            playfollowersound();
            //s.Play();
            ////shows falling money!
            //pictureBox1.Visible = true;
            //pictureBox1.Dock = DockStyle.Fill;
            //timerGraphic.Start();
            followerGraphic(textBox1.Text, 1, 3);
        }
        //start animation for panel
        private void followerGraphic(string name, int animationseconds, int animationdwell)
        {
            
            //set initial interval for animation timer
            int interval = animationseconds * 1000 / followerPanelHeight;
            timerFollowerGraphic.Interval = interval;
            //sets lable name
            label1.Text = newFollowerText.Replace("[Name]", name);
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
        }
        //move up
        private void followerGraphicMoveUp()
        {
            panel1.Location = new Point(panelxstart, panel1.Location.Y - 2);
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

        public DateTime lastfollowtime = Convert.ToDateTime("2014-04-13T02:22:08Z");

        private void timerPolling_Tick(object sender, EventArgs e)
        {
            //check every 30 seconds
            timerPolling.Interval = 30000;
            WebClient client = new WebClient();

            string channelname = "wornoutwasd";

            //new followers graphic
            #region
            //poll twitch api for follwers
            string followsSummaryString = client.DownloadString("https://api.twitch.tv/kraken/channels/" + channelname + "/follows");
            //parce follwers from serialized data
            var follows = JsonConvert.DeserializeObject<Twitch_Objects.RootObject>(followsSummaryString);
            listBox1.Items.Clear();
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
                listBox1.Items.Add(f.user.display_name);
            }


            // do things with the names

            #endregion
            //donation tracker

            //https://www.streamdonations.net/api/poll?channel=wornoutwasd&key=ZDI1YjljNjkxYmM4MDgwNTE1ZWU3Yzdh
            //{"status":"success","top":[{"channel":"wornoutwasd","date":"2014-04-12T15:28:26.584Z","processor":"Manual","transactionID":"MANUAL15719004573","firstName":"Justin","lastName":"Goetz","twitchUsername":"Justin_417","email":null,"currencyCode":"USD","currencySymbol":"$","amount":"5.00","dollars":5,"cents":0,"note":"updated","_id":"53495b9a468d790000000dbb"}],"mostRecent":[{"channel":"wornoutwasd","date":"2014-04-12T15:28:26.584Z","processor":"Manual","transactionID":"MANUAL15719004573","firstName":"Justin","lastName":"Goetz","twitchUsername":"Justin_417","email":null,"currencyCode":"USD","currencySymbol":"$","amount":"5.00","dollars":5,"cents":0,"note":"updated","_id":"53495b9a468d790000000dbb"}]}


        }

        private void button2_Click(object sender, EventArgs e)
        {
            playfollowersound();
        }

        




    }
}
