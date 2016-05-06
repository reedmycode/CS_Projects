namespace WorkSpace
{
    partial class frmWork
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
            this.btnDes = new System.Windows.Forms.Button();
            this.lblDes = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.Button();
            this.lblOff = new System.Windows.Forms.Label();
            this.btnOr = new System.Windows.Forms.Button();
            this.lblOr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDes
            // 
            this.btnDes.Location = new System.Drawing.Point(63, 110);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(147, 37);
            this.btnDes.TabIndex = 0;
            this.btnDes.Text = "Get Description";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(12, 52);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(0, 17);
            this.lblDes.TabIndex = 2;
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(63, 196);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(147, 37);
            this.btnOff.TabIndex = 3;
            this.btnOff.Text = "Get Officer Info";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // lblOff
            // 
            this.lblOff.AutoSize = true;
            this.lblOff.Location = new System.Drawing.Point(12, 166);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(0, 17);
            this.lblOff.TabIndex = 4;
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(63, 298);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(147, 37);
            this.btnOr.TabIndex = 5;
            this.btnOr.Text = "Get Info";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(12, 269);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(0, 17);
            this.lblOr.TabIndex = 6;
            // 
            // frmWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 413);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.btnOr);
            this.Controls.Add(this.lblOff);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.btnDes);
            this.Name = "frmWork";
            this.Text = "Get to Work";
            this.Load += new System.EventHandler(this.frmWork_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Label lblOr;
    }
}

