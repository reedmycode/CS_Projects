using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop
{
    public partial class frmCarShop : Form
    {
        public frmCarShop()
        {
            InitializeComponent();
        }

        private void btnCO_Click(object sender, EventArgs e)
        {
            if (cbWindows.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("You must make a choice for Power Windows",
                      "Missing Entry");
                return;
            }
            if (cbAir.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("You must make a choice for Air Conditioning",
                      "Missing Entry");
                return;
            }
            if (cbChrome.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("You must make a choice for Chrome finish",
                      "Missing Entry");
                return;
            }
            if (!rdoBlue.Checked && !rdoWhite.Checked)
            {
                MessageBox.Show("You must make a color selection",
                      "Missing Entry");
                return;
            }
            double basePrice = 15000;
            double winPrice = 500;
            double airPrice = 750;
            double chrPrice = 1000;
            double totPrice = basePrice;
            double buisDisc = .03;
            if (cbAir.Checked) totPrice += airPrice;
            if (cbWindows.Checked) totPrice += winPrice;
            if (cbChrome.Checked) totPrice += chrPrice;
            if (rdoBuis.Checked == true)
                totPrice -= (totPrice * buisDisc);
            MessageBox.Show(String.Format("Your total {0:C}",totPrice),
                             "Check Out",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            return;    
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdoWhite_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
