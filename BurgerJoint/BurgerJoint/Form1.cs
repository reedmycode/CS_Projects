using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerJoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCO_Click(object sender, EventArgs e)
        {
            double hamPrice = 2;
            double fryPrice = 1.5;
            double drkPrice = 1;
            double totPrice = 0;
            string myOrder = "";
            if (!ckbBurger.Checked && !ckbDrink.Checked && !ckbFries.Checked)
            {
                MessageBox.Show(
                    "Please select food before checkout",
                    "Oops",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            string username = txtName.Text;
            if (username == "")
            {
                MessageBox.Show(
                    "Please enter a name for your order",
                    "Oops",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                 );
                return;
            }         
            if (ckbBurger.Checked)
            {
                totPrice += hamPrice;
                myOrder += "a hamburger, ";
            }
            if (ckbFries.Checked)
            {
                totPrice += fryPrice;
                myOrder += "fries, ";
            }
            if (ckbDrink.Checked)
            {
                totPrice += drkPrice;
                myOrder += "a drink, ";
            }
            if (rdoCake.Checked)
            {
                myOrder += "and cake";
            
            }else
            {
                myOrder += "and ice cream";
            }
            MessageBox.Show(
                String.Format("{0} your order is ready.\nYou ordered {1}.\nTotal: {2:C}\n\nThanks come again!",username,myOrder,totPrice),
                "Cashier",
                MessageBoxButtons.OK);
            return;
        }
    }
}
