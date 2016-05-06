using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSpace
{
    public partial class FrmTime : Form
    {
        Time myTime;
        public FrmTime()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myTime = new Time();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int hr,min,sec;
            try
            {
                hr = Convert.ToInt32(tbHour.Text);
                min = Convert.ToInt32(tbMinute.Text);
                sec = Convert.ToInt32(tbSecond.Text);
            }
            catch(Exception _e)
            {
                MessageBox.Show(_e.ToString(),
                                "Use Numbers Genius",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
                bool timeStatus = myTime.setTime(hr, min, sec);
                if (!timeStatus)
                {
                    MessageBox.Show("Please enter valid time",
                                     "Oops",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    lblHr.Text = String.Format("{0:D2}", hr);
                    lblMin.Text = String.Format("{0:D2}", min);
                    lblSec.Text = String.Format("{0:D2}", sec);
                    timer1.Enabled = true;
                }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            myTime.AddSecond();
            int[] theTime = myTime.getTime();
            lblHr.Text = String.Format("{0:D2}",theTime[0]);
            lblMin.Text = String.Format("{0:D2}",theTime[1]);
            lblSec.Text = String.Format("{0:00}",theTime[2]);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myTime.AddSecond();
            int[] theTime = myTime.getTime();
            lblHr.Text = String.Format("{0:D2}", theTime[0]);
            lblMin.Text = String.Format("{0:D2}", theTime[1]);
            lblSec.Text = String.Format("{0:00}", theTime[2]);
        }
    }
}
