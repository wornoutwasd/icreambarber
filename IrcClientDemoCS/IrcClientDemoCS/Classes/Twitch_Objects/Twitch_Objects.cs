using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IrcClientDemoCS.Classes.Twitch_Objects
{
    class Twitch_Objects
    {
        public class Stream_Summary
        {
            public string average_bitrate { get; set; }
            public int viewers_count { get; set; }
            public int streams_count { get; set; }
        }
        public class Links
        {
            public string next { get; set; }
            public string self { get; set; }
        }

        public class Links2
        {
            public string self { get; set; }
        }

        public class Links3
        {
            public string stream_key { get; set; }
            public string self { get; set; }
            public string videos { get; set; }
            public string commercial { get; set; }
            public string chat { get; set; }
            public string features { get; set; }
        }

        public class Channel
        {
            public object banner { get; set; }
            public int _id { get; set; }
            public string url { get; set; }
            public object mature { get; set; }
            public List<object> teams { get; set; }
            public object status { get; set; }
            public object logo { get; set; }
            public string name { get; set; }
            public object video_banner { get; set; }
            public string display_name { get; set; }
            public string created_at { get; set; }
            public int delay { get; set; }
            public object game { get; set; }
            public Links3 _links { get; set; }
            public string updated_at { get; set; }
            public object background { get; set; }
            //added these
            public string views { get; set; }
            public string followers { get; set; }

        }

        public class Follow
        {
            public string created_at { get; set; }
            public Links2 _links { get; set; }
            public Channel channel { get; set; }
            public User user { get; set; }

        }
        //added user to get specific follower info.
        public class User
        {
            public string display_name { get; set; }
            public string _id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string bio { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public string logo { get; set; }
            public Links2 _links { get; set; }

            //Example from https://api.twitch.tv/kraken/channels/wornoutwasd/follows
            //{"_total":62,"_links":{"self":"https://api.twitch.tv/kraken/channels/wornoutwasd/follows?direction=DESC&limit=25&offset=0"
            //,"next":"https://api.twitch.tv/kraken/channels/wornoutwasd/follows?direction=DESC&limit=25&offset=25"}
            //,"follows":[
            //{"created_at":"2014-04-13T03:36:25Z"
            //,"_links":{"self":"https://api.twitch.tv/kraken/users/swee1mrstarman/follows/channels/wornoutwasd"}
            //,"user":{"display_name":"Swee1mrstarman"
            //,"_id":39081001,"name":"swee1mrstarman"
            //,"type":"user",
            //"bio":null,"created_at":"2013-01-06T02:59:40Z"
            //,"updated_at":"2014-03-19T20:16:01Z"
            //,"logo":null,
            //"_links":{"self":"https://api.twitch.tv/kraken/users/swee1mrstarman"}}}}
        }

        public class RootObject
        {
            public Links _links { get; set; }
            public List<Follow> follows { get; set; }
            //added these
            public int _total { get; set; }
        }

        //http://api.justin.tv/api/stream/summary.json?channel=wornoutwasd
        //{"average_bitrate":0,"viewers_count":"0","streams_count":0}

        //Example from https://api.twitch.tv/kraken/channels/wornoutwasd/follows
        //{"_total":62,"_links":{"self":"https://api.twitch.tv/kraken/channels/wornoutwasd/follows?direction=DESC&limit=25&offset=0"
        //,"next":"https://api.twitch.tv/kraken/channels/wornoutwasd/follows?direction=DESC&limit=25&offset=25"}
        //,"follows":[
        //{"created_at":"2014-04-13T03:36:25Z"
        //,"_links":{"self":"https://api.twitch.tv/kraken/users/swee1mrstarman/follows/channels/wornoutwasd"}
        //,"user":{"display_name":"Swee1mrstarman"
        //,"_id":39081001,"name":"swee1mrstarman"
        //,"type":"user",
        //"bio":null,"created_at":"2013-01-06T02:59:40Z"
        //,"updated_at":"2014-03-19T20:16:01Z"
        //,"logo":null,
        //"_links":{"self":"https://api.twitch.tv/kraken/users/swee1mrstarman"}}}}

        //example https://api.twitch.tv/kraken/channels/wornoutwasd
        //{"mature":true,
        //"abuse_reported":null,
        //"status":"Beta Babe Leveling",
        //"display_name":"WornOutWASD",
        //"game":"Hawken",
        //"delay":0,
        //"_id":57774896,
        //"name":"wornoutwasd",
        //"created_at":"2014-02-26T13:59:11Z",
        //"updated_at":"2014-04-13T06:15:20Z",
        //"primary_team_name":null,
        //"primary_team_display_name":null,
        //"logo":"http://static-cdn.jtvnw.net/jtv_user_pictures/wornoutwasd-profile_image-2a4f4766cd1e59bf-300x300.jpeg",
        //"banner":null,
        //"video_banner":"http://static-cdn.jtvnw.net/jtv_user_pictures/wornoutwasd-channel_offline_image-b47ce8139a214025-640x360.jpeg",
        //"background":null,
        //"profile_banner":null,
        //"profile_banner_background_color":null,
        //"url":"http://www.twitch.tv/wornoutwasd",
        //"views":1130,
        //"followers":62,
        //"_links":{"self":"https://api.twitch.tv/kraken/channels/wornoutwasd",
        //"follows":"https://api.twitch.tv/kraken/channels/wornoutwasd/follows",
        //"commercial":"https://api.twitch.tv/kraken/channels/wornoutwasd/commercial",
        //"stream_key":"https://api.twitch.tv/kraken/channels/wornoutwasd/stream_key",
        //"chat":"https://api.twitch.tv/kraken/chat/wornoutwasd",
        //"features":"https://api.twitch.tv/kraken/channels/wornoutwasd/features",
        //"subscriptions":"https://api.twitch.tv/kraken/channels/wornoutwasd/subscriptions",
        //"editors":"https://api.twitch.tv/kraken/channels/wornoutwasd/editors",
        //"teams":"https://api.twitch.tv/kraken/channels/wornoutwasd/teams",
        //"videos":"https://api.twitch.tv/kraken/channels/wornoutwasd/videos"}}


    }
}
