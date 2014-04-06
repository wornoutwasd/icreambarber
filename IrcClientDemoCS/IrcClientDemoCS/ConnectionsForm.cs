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
        public DataTable dt;

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

        private void ConnectionsForm_Load(object sender, EventArgs e)
        {
                        // TODO: This line of code loads data into the 'commandBotDataSet.IRCConnections' table. You can move, or remove it, as needed.
            this.iRCConnectionsTableAdapter.Fill(this.commandBotDataSet.IRCConnections);
            txtServer.Text = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["ServerAddress"].ToString();
            txtChannel.Text = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["Channel"].ToString();
            txtmPort.Text = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["Port"].ToString();
            txtOauth.Text = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["OAuth"].ToString();
            txtUser.Text = commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["User"].ToString();
            cbDefault.Checked = Convert.ToBoolean(commandBotDataSet.IRCConnections.DataSet.Tables["IRCConnections"].Rows[0]["DefaultServer"]);
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
