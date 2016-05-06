using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Favorites
{
    public partial class frmFav : Form
    {
        string[] aryFav = new string[10];
        string strFav = "candy chicken cars games money movies soccer soccer soccer soccer";
   
        public frmFav()
        {
            
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFav.Text = String.Format("I love {0} too", aryFav[lstFav.SelectedIndex]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < aryFav.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        aryFav[i] = "candy";
                        break;
                    case 1:
                        aryFav[i] = "chicken";
                        break;
                    case 2:
                        aryFav[i] = "movies";
                        break;
                    case 3:
                        aryFav[i] = "money";
                        break;
                    case 4:
                        aryFav[i] = "waterfalls";
                        break;
                    case 5:
                        aryFav[i] = "coding";
                        break;
                    case 6:
                        aryFav[i] = "soccer";
                        break;
                    case 7:
                        aryFav[i] = "soccer";
                        break;
                    case 8:
                        aryFav[i] = "soccer";
                        break;
                    case 9:
                        aryFav[i] = "soccer";
                        break;
                    default:
                        break;
                }
                lstFav.Items.Add(aryFav[i]);
            }
        
        }
              
    }
}
