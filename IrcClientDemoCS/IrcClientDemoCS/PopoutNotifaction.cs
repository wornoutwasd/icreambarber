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
        public PopoutNotifaction()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            timerPolling.Start();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

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
            
            //s.Play();
            pictureBox1.Visible = true;
            pictureBox1.Dock = DockStyle.Fill;
            timerGraphic.Start();
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
            timerPolling.Interval = 10000;
            WebClient client = new WebClient();
            //resize form and move objects depending on width of text

            //dirty parse for viewers count.


            string channelname = "wornoutwasd";
            //poll twitch api for follwers
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
            //update the last follow time.
            lastfollowtime = Convert.ToDateTime(follows.follows[0].created_at);
            //make a que for the names
            foreach (Twitch_Objects.Follow f in lstfollows)
            {
                listBox1.Items.Add(f.user.display_name);
            }

            //store the newest follow time to compare against for next round

        }



       
    }
}
