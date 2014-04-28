using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Windows;

namespace IrcClientDemoCS.Classes.Commander_Classes
{
    class Commander_HTMLWriter
    {
        public string ChatMessage(DataTable userTable, string chatUser, string chatMessage)
        {
            //build HTML output string for chat
            string htmlOut= "";
            string currtime = DateTime.Now.ToString("H:mm");

            //format is TIME, Profile Logo, Membership Logo, Display Name, : Message
            // currtime + " " + "<img src=\"http://static-cdn.jtvnw.net/jtv_user_pictures/wornoutwasd-profile_image-2a4f4766cd1e59bf-300x300.jpeg\" style=\" width: 15px; height: 15px\">" + "<img src=\"http://png.findicons.com/files/icons/2198/dark_glass/128/bookmark_add.png\" style=\" width: 15px; height: 15px\">" + " " + "<span style=\"color:red\">" + u + "</span>" + ": " + m + "<br>";

            htmlOut = currtime + " " + imgHTML(userTable.Rows[0]["logo"].ToString(), styleHTML("15", "15", ""))
            + imgHTML(userTable.Rows[0]["membership_icon"].ToString(), styleHTML("15", "15", "")) + " "
            + userHTML(userTable.Rows[0]["display_name"].ToString() == "" ? chatUser : userTable.Rows[0]["display_name"].ToString(), userTable.Rows[0]["ChatColor"].ToString()) + ": " + "" + chatMessage + "" + "<br>";
            return htmlOut;
        }
        ////reformats filepath for HTML -- actually might not need, we'll see

        //private string pathHTMLEscape(string escapeText)
        //{
            
            
        //    return escapeText;
        //}
        //returns HTML for imgsrc to make img
        private string userHTML(string displayName, string chatColor)
        {
            if (chatColor == "") chatColor = "White";
            string userSpan = "<span " + styleHTML("", "", chatColor) + ">" + displayName + "</span>";



            return userSpan;
        }
        private string imgHTML(string imgsrc, string style)
        {
            string basesrc = imgsrc;
            imgsrc = "<img src=\"" + basesrc + "\"" + style + ">";

            return imgsrc;
        }

        private string styleHTML(string height, string width, string color)//add more later
        {
            string style = "style=\"";
            if (color != "") style += "color: " + color + ";";
            if (height != "") style += "height: " + height + ";";
            if (width != "") style += "width: " + width + ";"; //make sure the last semicolon doesn't eff it up
            style += "\"";
            return style;
        }
    }
}
