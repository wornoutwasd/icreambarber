using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IrcClientDemoCS.Classes
{
    class Twitchfollow
    {
        public DateTime created_at {get;set;}
        public string _links {get;set;}

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
