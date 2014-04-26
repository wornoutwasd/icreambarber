using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using IrcClientDemoCS.Classes;
using IrcClientDemoCS.Classes.Twitch_Objects;

namespace IrcClientDemoCS
{
    public partial class StreamInfo : Form
    {
        public StreamInfo()
        {
            InitializeComponent();
            timerNetLoad.Start();
            
            
        }
        //***** These methods are to enable dragging of the window from form click
        #region
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void StreamInfo_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
            StreamInfo.ActiveForm.Size = new System.Drawing.Size(220, 25);
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void StreamInfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void StreamInfo_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion


        private void timerNetLoad_Tick(object sender, EventArgs e)
        {
            //check every 10 seconds
            timerNetLoad.Interval = 10000;
            WebClient client = new WebClient();
            //resize form and move objects depending on width of text


            try
            {
                string channelname = "wornoutwasd";
                //these need grab current channel from connection settings -
                string ChannelSummaryString = client.DownloadString("http://api.justin.tv/api/stream/summary.json?channel=" + channelname);
                var streamsummary = JsonConvert.DeserializeObject<Twitch_Objects.Stream_Summary>(ChannelSummaryString);

                lblViewers.Text = streamsummary.viewers_count.ToString();
                //get total follows
                string followsSummaryString = client.DownloadString("https://api.twitch.tv/kraken/channels/" + channelname + "/follows");
                var follows = JsonConvert.DeserializeObject<Twitch_Objects.RootObject>(followsSummaryString);
                lblFollowers.Text = follows._total.ToString();

                //get total views
                string ChannelString = client.DownloadString("https://api.twitch.tv/kraken/channels/" + channelname);
                var channel = JsonConvert.DeserializeObject<Twitch_Objects.Channel>(ChannelString);
                lblTotalViews.Text = channel.views;

                //var follows = JsonConvert.DeserializeObject<Twitch_Objects.RootObject>(followsSummaryString);
                //lblFollowers.Text = follows.follows.ToString();
            }
            catch
            { 
                //note in database
            }
            ////*****VIEW TESTING********
            #region
            ////(set for 9,999 of each)
            //Random r = new Random();
            //r.Next(0, 9999);
            //lblViewers.Text = r.Next(0, 9999).ToString();
            //lblFollowers.Text = r.Next(0, 9999).ToString();
            //lblTotalViews.Text = r.Next(0, 9999).ToString();
            #endregion

            //This centers and repositions images and lables to expand/contract depending on the width of the numbers
            #region
            //default positions for images are 0,0; 66,0;130,-2;
            //default positions for labes are 21,2; 86,2; 151,2
            int viewerwidth = lblViewers.Width;
            int viewswidth = lblTotalViews.Width;
            int followerswidth = lblFollowers.Width;
            //offset will center all of the items by taking the total (220) and subtracting the sum of the widths and divding by 2.
            int offset = (220 - (21 + viewerwidth + 21 + viewswidth + 21 + followerswidth)) / 2;
            //viewers location won't change
            pbViewers.Location = new System.Drawing.Point(offset, 0);
            lblViewers.Location = new System.Drawing.Point(offset + 21, 2);
            //total views will be first picture + viewerswidth + second picture
            //pictures are 25px
            pbTotalViews.Location = new System.Drawing.Point(offset + 21+viewerwidth, 0);
            lblTotalViews.Location = new System.Drawing.Point(offset + 21 + viewerwidth + 21, 2);
            pbFollowers.Location = new System.Drawing.Point(offset + 21 + viewerwidth + 21 + viewswidth, -2);
            lblFollowers.Location = new System.Drawing.Point(offset + 21 + viewerwidth + 21 + viewswidth + 21, 2);
            #endregion






        }

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
    }
}
