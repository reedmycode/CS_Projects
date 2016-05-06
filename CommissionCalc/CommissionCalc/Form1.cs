using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommissionCalc
{
    public partial class CommissionCalc : Form
    {
        public CommissionCalc()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtSales.Text = "";
            txtTax.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            double sales = Convert.ToDouble(txtSales.Text);
            double tax = Convert.ToDouble(txtTax.Text);
            double totalTax = sales * tax * .01;

            MessageBox.Show(String.Format("Your sales tax is {0:C}.",totalTax),
                  "Your Sales Tax",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtSales.SelectAll();
        }

        private void txtSales_Enter(object sender, EventArgs e)
        {
            txtTax.SelectAll();
        }
    }
}
