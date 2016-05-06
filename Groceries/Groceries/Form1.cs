using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groceries
{
    public partial class frmGrocery : Form
    {
        public frmGrocery()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lstGrocery.Items.Add(txtItem.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstGrocery.Items.Remove(txtRemove.Text);
        }

        private void lstGrocery_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOutput.Text = Convert.ToString(lstGrocery.SelectedItem);
        }
    }
}
