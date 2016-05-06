namespace Groceries
{
    partial class frmGrocery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrocery));
            this.lstGrocery = new System.Windows.Forms.ListBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstGrocery
            // 
            this.lstGrocery.FormattingEnabled = true;
            this.lstGrocery.ItemHeight = 16;
            this.lstGrocery.Location = new System.Drawing.Point(97, 131);
            this.lstGrocery.Name = "lstGrocery";
            this.lstGrocery.Size = new System.Drawing.Size(165, 100);
            this.lstGrocery.Sorted = true;
            this.lstGrocery.TabIndex = 0;
            this.lstGrocery.SelectedIndexChanged += new System.EventHandler(this.lstGrocery_SelectedIndexChanged);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(12, 36);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(165, 22);
            this.txtItem.TabIndex = 1;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(12, 77);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(165, 22);
            this.txtRemove.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(202, 35);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(111, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Item";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(202, 77);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(131, 266);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 17);
            this.lblOutput.TabIndex = 5;
            // 
            // frmGrocery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 308);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lstGrocery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGrocery";
            this.Text = "Groceries!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGrocery;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblOutput;
    }
}

