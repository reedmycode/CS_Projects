namespace TimeSpace
{
    partial class FrmTime
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTime));
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.tbMinute = new System.Windows.Forms.TextBox();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHr = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(40, 24);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(68, 17);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "Set Hour:";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(40, 58);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(79, 17);
            this.lblMinute.TabIndex = 1;
            this.lblMinute.Text = "Set Minute:";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(40, 93);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(85, 17);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "Set Second:";
            // 
            // lblSec
            // 
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(137, 63);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(56, 32);
            this.lblSec.TabIndex = 3;
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(145, 24);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(55, 22);
            this.tbHour.TabIndex = 4;
            // 
            // tbMinute
            // 
            this.tbMinute.Location = new System.Drawing.Point(145, 58);
            this.tbMinute.Name = "tbMinute";
            this.tbMinute.Size = new System.Drawing.Size(55, 22);
            this.tbMinute.TabIndex = 5;
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(145, 90);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(55, 22);
            this.tbSecond.TabIndex = 6;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(86, 140);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "Set Time";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(6, 21);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 8;
            this.btnGet.Text = "Tick";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.lblSec);
            this.gbTime.Controls.Add(this.lblMin);
            this.gbTime.Controls.Add(this.label4);
            this.gbTime.Controls.Add(this.label3);
            this.gbTime.Controls.Add(this.lblHr);
            this.gbTime.Controls.Add(this.btnGet);
            this.gbTime.Location = new System.Drawing.Point(43, 189);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(213, 115);
            this.gbTime.TabIndex = 9;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Clock:";
            // 
            // lblMin
            // 
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(82, 63);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(49, 32);
            this.lblMin.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            // 
            // lblHr
            // 
            this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.Location = new System.Drawing.Point(25, 63);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(51, 32);
            this.lblHr.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 328);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.tbMinute);
            this.Controls.Add(this.tbHour);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblHour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTime";
            this.Text = "Got Time?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.TextBox tbMinute;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Timer timer1;
    }
}

