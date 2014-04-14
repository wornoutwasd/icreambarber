using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IrcClientDemoCS.Classes
{
    class TwitchChannelFollowers
    {
        public int _total { get; set; }
        public string[] _links { get; set; }
        public Twitchfollow[] follows { get; set; }
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
}
