namespace CommissionCalc
{
    partial class CommissionCalc
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
            this.btnExt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblPerc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExt
            // 
            this.btnExt.Location = new System.Drawing.Point(12, 120);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(75, 23);
            this.btnExt.TabIndex = 4;
            this.btnExt.Text = "Calculate";
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(128, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(243, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(115, 31);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(100, 22);
            this.txtSales.TabIndex = 1;
            this.txtSales.Click += new System.EventHandler(this.txtName_Enter);
            this.txtSales.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(115, 75);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 22);
            this.txtTax.TabIndex = 3;
            this.txtTax.Click += new System.EventHandler(this.txtSales_Enter);
            this.txtTax.Enter += new System.EventHandler(this.txtSales_Enter);
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(29, 36);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(80, 17);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Sale Amt: $";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(74, 78);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(35, 17);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax:";
            // 
            // lblPerc
            // 
            this.lblPerc.AutoSize = true;
            this.lblPerc.Location = new System.Drawing.Point(211, 78);
            this.lblPerc.Name = "lblPerc";
            this.lblPerc.Size = new System.Drawing.Size(20, 17);
            this.lblPerc.TabIndex = 7;
            this.lblPerc.Text = "%";
            // 
            // CommissionCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 171);
            this.Controls.Add(this.lblPerc);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.lblSales);
            this.Name = "CommissionCalc";
            this.Text = "Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblPerc;
    }
}

