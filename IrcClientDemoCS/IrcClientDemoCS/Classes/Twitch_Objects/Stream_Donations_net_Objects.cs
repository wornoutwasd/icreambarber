using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IrcClientDemoCS.Classes.Twitch_Objects
{
    class Stream_Donations_net_Objects
    {
        public class donation
        {
            public string channel { get; set; }
            public string date { get; set; }
            public string processor { get; set; }
            public string transactionID{ get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string twitchUsername { get; set; }
            public string email { get; set; }
            public string currencyCode { get; set; }
            public string currencySymbol { get; set; }
            public string amount { get; set; }
            public string dollars { get; set; }
            public string cents { get; set; }
            public string note { get; set; }
            public string _id { get; set; }

            //{"channel":"wornoutwasd",
            //"date":"2014-04-12T15:28:26.584Z",
            //"processor":"Manual",
            //"transactionID":"MANUAL15719004573",
            //"firstName":"Justin",
            //"lastName":"Goetz",
            //"twitchUsername":"Justin_417",
            //"email":null,
            //"currencyCode":"USD",
            //"currencySymbol":"$",
            //"amount":"5.00",
            //"dollars":5,
            //"cents":0,
            //"note":"updated",
            //"_id":"53495b9a468d790000000dbb"}        
        }
        public class top
        {
            public List<donation> donations { get; set; }
        }
        public class mostRecent
        {
            public List<donation> donations { get; set; }
        }
        public class rootObject
        {
            public string status { get; set; }
            public top top { get; set; }
            public mostRecent mostRecent { get; set; }
        }


    }
}
