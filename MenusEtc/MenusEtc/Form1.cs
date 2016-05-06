using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenusEtc
{
    public partial class frmMenus : Form
    {
        public frmMenus()
        {
 
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsPurple_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Purple;
            lblMessage.Text = "I love Purple";
        }

        private void tsBlue_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Blue;
            lblMessage.Text = "I love Blue";
        }

        private void tsReed_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text = "I love Reed";
        }

        private void tsOrange_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Orange;
            lblMessage.Text = "I love Orange";
        }

        private void tsGreen_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = "I love Green";
        }

        private void rbBlue1_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.BackColor = Color.Blue;
        }

        private void rbGreen1_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.BackColor = Color.Green;
        }

        private void rbReed1_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.BackColor = Color.Red;
        }

        private void rbOrange1_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.BackColor = Color.Orange;
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Blue;
            lblMessage.Text = "I love Blue";
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = "I love Green";
        }

        private void rbReed_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text = "I love Red";
        }

        private void rbOrange_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Orange;
            lblMessage.Text = "I love Orange";
        }



    }
}
