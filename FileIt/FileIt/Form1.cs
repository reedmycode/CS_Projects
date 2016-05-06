using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIt
{
    public partial class fileIt : Form
    {
        private StreamReader inFile = File.OpenText("outfile.txt"); 
        public fileIt()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            StreamWriter outFile = File.AppendText("outfile.txt");
            outFile.WriteLine(tbAdd.Text);
            outFile.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                ofdRead.ShowDialog();
                StreamReader inFile = File.OpenText(ofdRead.FileName);
                lblRead.Text = inFile.ReadLine();
                inFile.Close();
            }
            catch(FileNotFoundException)
            {
                //do nothing
            }
         }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {   
                sfdSave.ShowDialog();
                StreamWriter outFile = File.AppendText(sfdSave.FileName);
                outFile.WriteLine(tbAdd.Text);
                outFile.Close();
            }
            catch(FileNotFoundException)
            {
                //do nothing
            }
        }

        private void tbIndex_MouseClick(object sender, MouseEventArgs e)
        {
            btnIndex_Click(sender,e);
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            string[] abcs = new string[5] { "a", "b", "c", "d", "e" };
            int i;
            try
            {
                i = Convert.ToInt32(tbIndex.Text);
            }
            catch (Exception exc)
            {
                lblAssignOut.Text = exc.Message;
                return;
            }
            try
            {
                lblAssignOut.Text = String.Format("Your index was: {0}.\nYou picked: {1}.", i, abcs[i]);
            }
            catch (IndexOutOfRangeException ior)
            {
                lblAssignOut.Text = ior.Message;
            }
        }
    }
}
