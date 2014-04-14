using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AXVLC;
using System.Media;

namespace IrcClientDemoCS
{
    public partial class NotificationGraphicPopout : Form
    {
        public NotificationGraphicPopout()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //plays a sound
            SoundPlayer s = new SoundPlayer(@"C:\Users\DavidServer\Documents\GitHub\icreambarber\IrcClientDemoCS\IrcClientDemoCS\Resources\Follwer.wav");
            
            s.Play();
        }

       
    }
}
