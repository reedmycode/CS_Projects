using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordProcesseses
{
    public partial class frmWord : Form
    {
        public frmWord()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fdResult = fdMain.ShowDialog();
            if (fdResult == DialogResult.OK)
            {
                fdMain_Apply(sender, e);
            }
        }

        private void fdMain_Apply(object sender, EventArgs e)
        {
            rtbMain.SelectionFont = fdMain.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cdMain.ShowDialog();
            rtbMain.SelectionColor = cdMain.Color;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                sfdMain.ShowDialog();
                rtbMain.SaveFile(sfdMain.FileName);
            }
            catch (ArgumentException)
            { }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtbMain.SaveFile(sfdMain.FileName);
                MessageBox.Show(String.Format("Saved file as {0}", sfdMain.FileName),"Save Successful",MessageBoxButtons.OK);
            }
            catch (Exception) 
            { }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdMain.ShowDialog();
        }

        private void ofdMain_FileOk(object sender, CancelEventArgs e)
        {
            rtbMain.LoadFile(ofdMain.FileName);
            sfdMain.FileName = ofdMain.FileName;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.Clear();
            sfdMain.FileName = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.SelectAll();
        }

        private void bulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.SelectionBullet = !rtbMain.SelectionBullet;
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cdMain.ShowDialog();
            rtbMain.BackColor = cdMain.Color;
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult fdResult = fdMenu.ShowDialog();
            if (fdResult == DialogResult.OK)
            {
                fdMenu_Apply(sender, e);
            }
        }

        private void fdMenu_Apply(object sender, EventArgs e)
        {
            msMain.Font = fdMenu.Font;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cdMain.ShowDialog();
            msMain.ForeColor = cdMain.Color;
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cdMain.ShowDialog();
            msMain.BackColor = cdMain.Color;
        }
    }
}
