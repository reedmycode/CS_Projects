namespace Favorites
{
    partial class frmFav
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstFav = new System.Windows.Forms.ListBox();
            this.lblFav = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFav
            // 
            this.lstFav.FormattingEnabled = true;
            this.lstFav.ItemHeight = 16;
            this.lstFav.Location = new System.Drawing.Point(25, 48);
            this.lstFav.Name = "lstFav";
            this.lstFav.Size = new System.Drawing.Size(222, 100);
            this.lstFav.TabIndex = 2;
            this.lstFav.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblFav
            // 
            this.lblFav.AutoSize = true;
            this.lblFav.Location = new System.Drawing.Point(13, 198);
            this.lblFav.Name = "lblFav";
            this.lblFav.Size = new System.Drawing.Size(0, 17);
            this.lblFav.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(9, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(261, 17);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Here are my favorites, what do you like?";
            // 
            // frmFav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblFav);
            this.Controls.Add(this.lstFav);
            this.Name = "frmFav";
            this.Text = "Favorites!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFav;
        private System.Windows.Forms.Label lblFav;
        private System.Windows.Forms.Label lblWelcome;
    }
}

