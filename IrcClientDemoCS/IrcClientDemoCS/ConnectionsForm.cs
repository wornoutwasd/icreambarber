using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IrcClientDemoCS
{
    public partial class ConnectionsForm : Form
    {
        private String server;
        private String channel;
        private String user;
        private String oauth;
        private int port;

        public ConnectionsForm()
        {
            InitializeComponent();
            server = "";
            channel = "";
            user = "";
            oauth = "";
            port = 0;
        }

        /// <summary>
        /// Saves the connection info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnectionSave_Click(object sender, EventArgs e)
        {
            //Form1.intConnPort = Convert.ToInt16(txtmPort.Text);
            server = txtServer.Text;
            channel = txtChannel.Text;
            user = txtUser.Text;
            port = Convert.ToInt16(txtmPort.Text);
            oauth = txtOauth.Text;
            //returns an OK DialogResult to the main form. (through the assigned connection form variable)
            DialogResult = DialogResult.OK;
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            /*tells the main form that the user canceled their decision and
            closes the window */
            DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// returns the saved channel name.
        /// </summary>
        /// <returns>the channel name.</returns>
        public String getChannel() 
        {
            return channel;
        }
        /// <summary>
        /// returns the saved user name.
        /// </summary>
        /// <returns></returns>
        public String getUser()
        {
            return user;
        }
        /// <summary>
        /// returns the saved Oauth (irc password).
        /// </summary>
        /// <returns> the oauth.</returns>
        public String getOauth()
        {
            return oauth;
        }
        /// <summary>
        /// returns the server name.
        /// </summary>
        /// <returns>the server name.</returns>
        public String getServer()
        {
            return server;
        }
        /// <summary>
        /// returns the port number.
        /// </summary>
        /// <returns>the port number.</returns>
        public int getPort()
        {
            return port;
        }
    }
}
