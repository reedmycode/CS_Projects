namespace BurgerJoint
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
            this.ckbBurger = new System.Windows.Forms.CheckBox();
            this.ckbFries = new System.Windows.Forms.CheckBox();
            this.ckbDrink = new System.Windows.Forms.CheckBox();
            this.rdoCake = new System.Windows.Forms.RadioButton();
            this.rdoIce = new System.Windows.Forms.RadioButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPick = new System.Windows.Forms.Label();
            this.lblDessert = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCO = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckbBurger
            // 
            this.ckbBurger.AutoSize = true;
            this.ckbBurger.Location = new System.Drawing.Point(23, 104);
            this.ckbBurger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbBurger.Name = "ckbBurger";
            this.ckbBurger.Size = new System.Drawing.Size(57, 17);
            this.ckbBurger.TabIndex = 5;
            this.ckbBurger.Text = "Burger";
            this.ckbBurger.UseVisualStyleBackColor = true;
            // 
            // ckbFries
            // 
            this.ckbFries.AutoSize = true;
            this.ckbFries.Location = new System.Drawing.Point(23, 126);
            this.ckbFries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbFries.Name = "ckbFries";
            this.ckbFries.Size = new System.Drawing.Size(48, 17);
            this.ckbFries.TabIndex = 6;
            this.ckbFries.Text = "Fries";
            this.ckbFries.UseVisualStyleBackColor = true;
            // 
            // ckbDrink
            // 
            this.ckbDrink.AutoSize = true;
            this.ckbDrink.Location = new System.Drawing.Point(23, 148);
            this.ckbDrink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbDrink.Name = "ckbDrink";
            this.ckbDrink.Size = new System.Drawing.Size(51, 17);
            this.ckbDrink.TabIndex = 7;
            this.ckbDrink.Text = "Drink";
            this.ckbDrink.UseVisualStyleBackColor = true;
            // 
            // rdoCake
            // 
            this.rdoCake.AutoSize = true;
            this.rdoCake.Checked = true;
            this.rdoCake.Location = new System.Drawing.Point(23, 199);
            this.rdoCake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoCake.Name = "rdoCake";
            this.rdoCake.Size = new System.Drawing.Size(50, 17);
            this.rdoCake.TabIndex = 9;
            this.rdoCake.TabStop = true;
            this.rdoCake.Text = "Cake";
            this.rdoCake.UseVisualStyleBackColor = true;
            // 
            // rdoIce
            // 
            this.rdoIce.AutoSize = true;
            this.rdoIce.Location = new System.Drawing.Point(23, 221);
            this.rdoIce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoIce.Name = "rdoIce";
            this.rdoIce.Size = new System.Drawing.Size(73, 17);
            this.rdoIce.TabIndex = 10;
            this.rdoIce.Text = "Ice Cream";
            this.rdoIce.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(9, 31);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(166, 15);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Burgers not Boogers";
            // 
            // lblPick
            // 
            this.lblPick.AutoSize = true;
            this.lblPick.Location = new System.Drawing.Point(21, 86);
            this.lblPick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPick.Name = "lblPick";
            this.lblPick.Size = new System.Drawing.Size(31, 13);
            this.lblPick.TabIndex = 4;
            this.lblPick.Text = "Pick:";
            // 
            // lblDessert
            // 
            this.lblDessert.AutoSize = true;
            this.lblDessert.Location = new System.Drawing.Point(21, 181);
            this.lblDessert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(113, 13);
            this.lblDessert.TabIndex = 8;
            this.lblDessert.Text = "Choose a free dessert:";
            this.lblDessert.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to:";
            // 
            // btnCO
            // 
            this.btnCO.Location = new System.Drawing.Point(23, 253);
            this.btnCO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCO.Name = "btnCO";
            this.btnCO.Size = new System.Drawing.Size(112, 19);
            this.btnCO.TabIndex = 11;
            this.btnCO.Text = "Check Out";
            this.btnCO.UseVisualStyleBackColor = true;
            this.btnCO.Click += new System.EventHandler(this.btnCO_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblName.Location = new System.Drawing.Point(21, 62);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 288);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDessert);
            this.Controls.Add(this.lblPick);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.rdoIce);
            this.Controls.Add(this.rdoCake);
            this.Controls.Add(this.ckbDrink);
            this.Controls.Add(this.ckbFries);
            this.Controls.Add(this.ckbBurger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Burgers!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbBurger;
        private System.Windows.Forms.CheckBox ckbFries;
        private System.Windows.Forms.CheckBox ckbDrink;
        private System.Windows.Forms.RadioButton rdoCake;
        private System.Windows.Forms.RadioButton rdoIce;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPick;
        private System.Windows.Forms.Label lblDessert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCO;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}

