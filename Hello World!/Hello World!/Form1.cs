using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnMessage_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Reed My Address";
            lblGreeting1.Text = "1234 SW My St.";
            lblGreeting2.Text = "Somewhere,Else";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "";
            lblGreeting1.Text = "";
            lblGreeting2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblTextbox.Text = Convert.ToString(Convert.ToInt32(txtInput.Text) + 10);
        }


    }
}
