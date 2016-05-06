namespace CarShop
{
    partial class frmCarShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarShop));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cbWindows = new System.Windows.Forms.CheckBox();
            this.cbAir = new System.Windows.Forms.CheckBox();
            this.cbChrome = new System.Windows.Forms.CheckBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.btnCO = new System.Windows.Forms.Button();
            this.rdoBuis = new System.Windows.Forms.RadioButton();
            this.rdoPers = new System.Windows.Forms.RadioButton();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.gbAcct = new System.Windows.Forms.GroupBox();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.gbAcct.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(39, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(242, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Car Shop.\r\n";
            // 
            // cbWindows
            // 
            this.cbWindows.AutoSize = true;
            this.cbWindows.Checked = true;
            this.cbWindows.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbWindows.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.cbWindows.Location = new System.Drawing.Point(26, 80);
            this.cbWindows.Name = "cbWindows";
            this.cbWindows.Size = new System.Drawing.Size(129, 21);
            this.cbWindows.TabIndex = 2;
            this.cbWindows.Text = "&Power Windows";
            this.cbWindows.UseVisualStyleBackColor = true;
            // 
            // cbAir
            // 
            this.cbAir.AutoSize = true;
            this.cbAir.Checked = true;
            this.cbAir.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbAir.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.cbAir.Location = new System.Drawing.Point(26, 107);
            this.cbAir.Name = "cbAir";
            this.cbAir.Size = new System.Drawing.Size(129, 21);
            this.cbAir.TabIndex = 3;
            this.cbAir.Text = "Air Conditioning";
            this.cbAir.UseVisualStyleBackColor = true;
            // 
            // cbChrome
            // 
            this.cbChrome.AutoSize = true;
            this.cbChrome.Checked = true;
            this.cbChrome.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbChrome.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.cbChrome.Location = new System.Drawing.Point(26, 134);
            this.cbChrome.Name = "cbChrome";
            this.cbChrome.Size = new System.Drawing.Size(83, 21);
            this.cbChrome.TabIndex = 4;
            this.cbChrome.Text = "Chrome ";
            this.cbChrome.UseVisualStyleBackColor = true;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(12, 59);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(160, 17);
            this.lblChoose.TabIndex = 1;
            this.lblChoose.Text = "Choose Your Upgrades:";
            // 
            // btnCO
            // 
            this.btnCO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCO.Location = new System.Drawing.Point(100, 249);
            this.btnCO.Name = "btnCO";
            this.btnCO.Size = new System.Drawing.Size(145, 27);
            this.btnCO.TabIndex = 7;
            this.btnCO.Text = "Check &Out";
            this.btnCO.UseVisualStyleBackColor = true;
            this.btnCO.Click += new System.EventHandler(this.btnCO_Click);
            // 
            // rdoBuis
            // 
            this.rdoBuis.AutoSize = true;
            this.rdoBuis.Location = new System.Drawing.Point(6, 20);
            this.rdoBuis.Name = "rdoBuis";
            this.rdoBuis.Size = new System.Drawing.Size(86, 21);
            this.rdoBuis.TabIndex = 6;
            this.rdoBuis.Text = "Buisness";
            this.rdoBuis.UseVisualStyleBackColor = true;
            // 
            // rdoPers
            // 
            this.rdoPers.AutoSize = true;
            this.rdoPers.Checked = true;
            this.rdoPers.Location = new System.Drawing.Point(7, 47);
            this.rdoPers.Name = "rdoPers";
            this.rdoPers.Size = new System.Drawing.Size(85, 21);
            this.rdoPers.TabIndex = 7;
            this.rdoPers.TabStop = true;
            this.rdoPers.Text = "Personal";
            this.rdoPers.UseVisualStyleBackColor = true;
            // 
            // rdoWhite
            // 
            this.rdoWhite.AutoSize = true;
            this.rdoWhite.Location = new System.Drawing.Point(14, 48);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(65, 21);
            this.rdoWhite.TabIndex = 1;
            this.rdoWhite.TabStop = true;
            this.rdoWhite.Text = "White";
            this.rdoWhite.UseVisualStyleBackColor = true;
            this.rdoWhite.CheckedChanged += new System.EventHandler(this.rdoWhite_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(14, 21);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(57, 21);
            this.rdoBlue.TabIndex = 0;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            // 
            // gbAcct
            // 
            this.gbAcct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbAcct.Controls.Add(this.rdoBuis);
            this.gbAcct.Controls.Add(this.rdoPers);
            this.gbAcct.Location = new System.Drawing.Point(225, 59);
            this.gbAcct.Name = "gbAcct";
            this.gbAcct.Size = new System.Drawing.Size(99, 77);
            this.gbAcct.TabIndex = 5;
            this.gbAcct.TabStop = false;
            this.gbAcct.Text = "&Account:";
            // 
            // gbColor
            // 
            this.gbColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbColor.Controls.Add(this.rdoWhite);
            this.gbColor.Controls.Add(this.rdoBlue);
            this.gbColor.Location = new System.Drawing.Point(225, 142);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(99, 84);
            this.gbColor.TabIndex = 6;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "&Color:";
            // 
            // frmCarShop
            // 
            this.AcceptButton = this.btnCO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(345, 298);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.gbAcct);
            this.Controls.Add(this.btnCO);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.cbChrome);
            this.Controls.Add(this.cbAir);
            this.Controls.Add(this.cbWindows);
            this.Controls.Add(this.lblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCarShop";
            this.Text = "Car Shop";
            this.gbAcct.ResumeLayout(false);
            this.gbAcct.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.CheckBox cbWindows;
        private System.Windows.Forms.CheckBox cbAir;
        private System.Windows.Forms.CheckBox cbChrome;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btnCO;
        private System.Windows.Forms.RadioButton rdoBuis;
        private System.Windows.Forms.RadioButton rdoPers;
        private System.Windows.Forms.RadioButton rdoWhite;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.GroupBox gbAcct;
        private System.Windows.Forms.GroupBox gbColor;
    }
}

