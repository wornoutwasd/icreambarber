using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace IrcClientDemoCS
{
    public partial class StreamInfo : Form
    {
        public StreamInfo()
        {
            InitializeComponent();
            timerNetLoad.Start();
            
            
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void StreamInfo_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
            StreamInfo.ActiveForm.Size = new System.Drawing.Size(220, 25);
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

        private void timerNetLoad_Tick(object sender, EventArgs e)
        {
            //check every 10 seconds
            timerNetLoad.Interval = 10000;
            WebClient client = new WebClient();
            //resize form and move objects depending on width of text
            
            //dirty parse for viewers count.


            string channelname = "wornoutwasd";
            //these need grab current channel from connection settings -
            string ChannelSummaryString = client.DownloadString("http://api.justin.tv/api/stream/summary.json?channel=" + channelname);
            string[] parsearr = ChannelSummaryString.Split(',');
            string[] viewerscount = parsearr[1].Split(':');
            lblViewers.Text = viewerscount[1].ToString();
            //get total follows
            string followsSummaryString = client.DownloadString("https://api.twitch.tv/kraken/channels/" + channelname + "/follows");
            string[] followsparsearr = followsSummaryString.Split(',');
            string[] followscount = followsparsearr[0].Split(':');
            lblFollowers.Text = followscount[1].ToString();

            //get total views
            string totalviewsSummaryString = client.DownloadString("https://api.twitch.tv/kraken/channels/" + channelname);
            string[] totalviewsparsearr = totalviewsSummaryString.Split(',');
            string[] totalviewscount = totalviewsparsearr[20].Split(':');
            lblTotalViews.Text = totalviewscount[1].ToString();

            ////*****VIEW TESTING********
            ////(set for 9,999 of each)
            //Random r = new Random();
            //r.Next(0, 9999);
            //lblViewers.Text = r.Next(0, 9999).ToString();
            //lblFollowers.Text = r.Next(0, 9999).ToString();
            //lblTotalViews.Text = r.Next(0, 9999).ToString();

            
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
            
                
            



        }
    }
}
