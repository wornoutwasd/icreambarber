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
    public partial class Raffle : Form
    {
        public Raffle()
        {
            InitializeComponent();
        }
        //this works, make some objects.
        double x1 = 1;
        double y1 = 1;
        double x2 = 1;
        double y2 = 1;
        double x3 = 1;
        double y3 = 1;
        double time = 0;
        int intrad = 100;
        private void btnRaffle_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(1, 1);
            timerFPS.Start();
        }

        private void timerFPS_Tick(object sender, EventArgs e)
        {
            x1 = 200 + Math.Sin(time) * intrad;
            y1 = 200 + Math.Cos(time) * intrad;
            x2 = 200 + Math.Sin(time+5) * intrad;
            y2 = 200 + Math.Cos(time+5) * intrad;
            x3 = 200 + Math.Sin(time+10) * intrad;
            y3 = 200 + Math.Cos(time+10) * intrad;
            
            timerFPS.Interval = 1;
            pictureBox1.Location = new Point(Convert.ToInt16(x1), Convert.ToInt16(y1));
            pictureBox1.Height = Convert.ToInt16(x1 * .2);
            pictureBox1.Width = Convert.ToInt16(x1 * .2);
            pictureBox2.Location = new Point(Convert.ToInt16(x2), Convert.ToInt16(y2));
            pictureBox2.Height = Convert.ToInt16(x2 * .2);
            pictureBox2.Width = Convert.ToInt16(x2 * .2);
            pictureBox3.Location = new Point(Convert.ToInt16(x3), Convert.ToInt16(y3));
            pictureBox3.Height = Convert.ToInt16(x3 * .2);
            pictureBox3.Width = Convert.ToInt16(x3 * .2);
            if (time < 9)
            {
                timerFPS.Interval = 10000;
            }
            if (time < 8)
            {
                timerFPS.Interval = 1000;
            }
            if (time < 7)
            {
                timerFPS.Interval = 100;
            }
            if (time < 5)
            {
                timerFPS.Interval = 10;
            }
            if (time < 10)
            {
                timerFPS.Interval = 1;
            }
            time = time + 0.05;
        }
    }
}
