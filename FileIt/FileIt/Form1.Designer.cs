namespace FileIt
{
    partial class fileIt
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
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblRead = new System.Windows.Forms.Label();
            this.ofdRead = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAssign = new System.Windows.Forms.Label();
            this.lblAsk = new System.Windows.Forms.Label();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.btnIndex = new System.Windows.Forms.Button();
            this.lblAssignOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(31, 12);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(175, 22);
            this.tbAdd.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(230, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add It!";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(31, 54);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read It!";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Location = new System.Drawing.Point(28, 113);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(0, 17);
            this.lblRead.TabIndex = 3;
            // 
            // ofdRead
            // 
            this.ofdRead.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save It!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAssign
            // 
            this.lblAssign.AutoSize = true;
            this.lblAssign.Location = new System.Drawing.Point(96, 218);
            this.lblAssign.Name = "lblAssign";
            this.lblAssign.Size = new System.Drawing.Size(147, 17);
            this.lblAssign.TabIndex = 5;
            this.lblAssign.Text = "Testing for exceptions";
            // 
            // lblAsk
            // 
            this.lblAsk.AutoSize = true;
            this.lblAsk.Location = new System.Drawing.Point(12, 253);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.Size = new System.Drawing.Size(180, 17);
            this.lblAsk.TabIndex = 6;
            this.lblAsk.Text = "Please enter an index(0-4):";
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(198, 253);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(72, 22);
            this.tbIndex.TabIndex = 7;
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(300, 250);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(75, 23);
            this.btnIndex.TabIndex = 8;
            this.btnIndex.Text = "Index It!";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // lblAssignOut
            // 
            this.lblAssignOut.AutoSize = true;
            this.lblAssignOut.Location = new System.Drawing.Point(158, 288);
            this.lblAssignOut.Name = "lblAssignOut";
            this.lblAssignOut.Size = new System.Drawing.Size(0, 17);
            this.lblAssignOut.TabIndex = 9;
            // 
            // fileIt
            // 
            this.AcceptButton = this.btnIndex;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 332);
            this.Controls.Add(this.lblAssignOut);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.lblAsk);
            this.Controls.Add(this.lblAssign);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRead);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAdd);
            this.Name = "fileIt";
            this.Text = "File It!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.OpenFileDialog ofdRead;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAssign;
        private System.Windows.Forms.Label lblAsk;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Label lblAssignOut;
    }
}

