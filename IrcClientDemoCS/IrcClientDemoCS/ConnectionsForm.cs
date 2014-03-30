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
        public ConnectionsForm()
        {
            InitializeComponent();
        }

        private void btnConnectionSave_Click(object sender, EventArgs e)
        {
            Form1.intConnPort = Convert.ToInt16(txtmPort.Text);
            
        }
    }
}
