using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IrcClientDemoCS.Classes
{
    class TwitchChannelSummary
    {

        //http://api.justin.tv/api/stream/summary.json?channel=wornoutwasd
        //{"average_bitrate":0,"viewers_count":"0","streams_count":0}
        public string average_bitrate { get; set; }
        public int viewers_count { get; set; }
        public int streams_count { get; set; }

    }
}
