namespace Hello_World_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMessage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGreeting1 = new System.Windows.Forms.Label();
            this.lblGreeting2 = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMessage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMessage.Location = new System.Drawing.Point(128, 431);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(73, 51);
            this.btnMessage.TabIndex = 4;
            this.btnMessage.Text = "Show Address";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(235, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGreeting1
            // 
            this.lblGreeting1.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGreeting1.Location = new System.Drawing.Point(124, 298);
            this.lblGreeting1.Name = "lblGreeting1";
            this.lblGreeting1.Size = new System.Drawing.Size(184, 31);
            this.lblGreeting1.TabIndex = 7;
            // 
            // lblGreeting2
            // 
            this.lblGreeting2.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGreeting2.Location = new System.Drawing.Point(124, 329);
            this.lblGreeting2.Name = "lblGreeting2";
            this.lblGreeting2.Size = new System.Drawing.Size(184, 31);
            this.lblGreeting2.TabIndex = 9;
            // 
            // lblGreeting
            // 
            this.lblGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGreeting.Location = new System.Drawing.Point(124, 267);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(184, 31);
            this.lblGreeting.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(456, 564);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.lblGreeting2);
            this.Controls.Add(this.lblGreeting1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMessage);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "This is Only a Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGreeting1;
        private System.Windows.Forms.Label lblGreeting2;
        private System.Windows.Forms.Label lblGreeting;
    }
}

