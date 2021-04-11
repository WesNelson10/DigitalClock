using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Display current time data on the labels as strings.
            lbl24.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMMMMMMM dd yyyy"); // I think this will work for all months. It should.
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblSecond.Location = new Point(lbl24.Location.X + lbl24.Width-5, lblSecond.Location.Y);
            // The icon flag is Thai, my father was born there.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
