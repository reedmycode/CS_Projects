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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath shapeSS = new System.Drawing.Drawing2D.GraphicsPath();
            shapeSS.AddEllipse(15, 30, this.Width - 30, this.Height - 45);
            this.Region = new Region(shapeSS);
        }
    }
}
