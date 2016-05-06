using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkSpace
{
    public partial class frmWork : Form
    {
        Employee myEmployee;
        Officer myOfficer;
        Employee myEmpOff;
        public frmWork()
        {
            InitializeComponent();
        }

        private void frmWork_Load(object sender, EventArgs e)
        {
            myOfficer = new Officer();
            myOfficer.SetBonus(1000);
            myOfficer.SetName("Tommy");
            myOfficer.SetSalary(90000);
            myEmployee = new Employee();
            myEmployee.SetName("Timmy");
            myEmployee.SetSalary(70000);
            myEmpOff = myOfficer;
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            lblDes.Text = myEmployee.GetDescription();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            lblOff.Text = myOfficer.GetDescription();
        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            lblOr.Text = myEmpOff.GetDescription();
        }
    }
}
