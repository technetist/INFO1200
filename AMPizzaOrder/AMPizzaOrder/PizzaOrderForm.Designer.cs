namespace AMPizzaOrder
{
    partial class PizzaOrderForm
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
            this.grpBoxCrust = new System.Windows.Forms.GroupBox();
            this.rbtnThin = new System.Windows.Forms.RadioButton();
            this.rbtnPan = new System.Windows.Forms.RadioButton();
            this.grpBoxTopping = new System.Windows.Forms.GroupBox();
            this.chkBoxPepperoni = new System.Windows.Forms.CheckBox();
            this.chkBoxPineapple = new System.Windows.Forms.CheckBox();
            this.chkBoxCheese = new System.Windows.Forms.CheckBox();
            this.lblDeliverCity = new System.Windows.Forms.Label();
            this.lstBoxCities = new System.Windows.Forms.ListBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxCrust.SuspendLayout();
            this.grpBoxTopping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxCrust
            // 
            this.grpBoxCrust.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxCrust.Controls.Add(this.rbtnThin);
            this.grpBoxCrust.Controls.Add(this.rbtnPan);
            this.grpBoxCrust.Font = new System.Drawing.Font("Humnst777 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCrust.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpBoxCrust.Location = new System.Drawing.Point(210, 76);
            this.grpBoxCrust.Name = "grpBoxCrust";
            this.grpBoxCrust.Size = new System.Drawing.Size(95, 117);
            this.grpBoxCrust.TabIndex = 0;
            this.grpBoxCrust.TabStop = false;
            this.grpBoxCrust.Text = "Crust";
            // 
            // rbtnThin
            // 
            this.rbtnThin.AutoSize = true;
            this.rbtnThin.ForeColor = System.Drawing.Color.Navy;
            this.rbtnThin.Location = new System.Drawing.Point(16, 67);
            this.rbtnThin.Name = "rbtnThin";
            this.rbtnThin.Size = new System.Drawing.Size(61, 24);
            this.rbtnThin.TabIndex = 0;
            this.rbtnThin.TabStop = true;
            this.rbtnThin.Text = "Thin";
            this.rbtnThin.UseVisualStyleBackColor = true;
            // 
            // rbtnPan
            // 
            this.rbtnPan.AutoSize = true;
            this.rbtnPan.Checked = true;
            this.rbtnPan.ForeColor = System.Drawing.Color.Navy;
            this.rbtnPan.Location = new System.Drawing.Point(16, 37);
            this.rbtnPan.Name = "rbtnPan";
            this.rbtnPan.Size = new System.Drawing.Size(55, 24);
            this.rbtnPan.TabIndex = 0;
            this.rbtnPan.TabStop = true;
            this.rbtnPan.Text = "Pan";
            this.rbtnPan.UseVisualStyleBackColor = true;
            // 
            // grpBoxTopping
            // 
            this.grpBoxTopping.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxTopping.Controls.Add(this.chkBoxPepperoni);
            this.grpBoxTopping.Controls.Add(this.chkBoxPineapple);
            this.grpBoxTopping.Controls.Add(this.chkBoxCheese);
            this.grpBoxTopping.Font = new System.Drawing.Font("Humnst777 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTopping.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpBoxTopping.Location = new System.Drawing.Point(341, 76);
            this.grpBoxTopping.Name = "grpBoxTopping";
            this.grpBoxTopping.Size = new System.Drawing.Size(136, 117);
            this.grpBoxTopping.TabIndex = 1;
            this.grpBoxTopping.TabStop = false;
            this.grpBoxTopping.Text = "Topping";
            // 
            // chkBoxPepperoni
            // 
            this.chkBoxPepperoni.AutoSize = true;
            this.chkBoxPepperoni.ForeColor = System.Drawing.Color.Navy;
            this.chkBoxPepperoni.Location = new System.Drawing.Point(15, 56);
            this.chkBoxPepperoni.Name = "chkBoxPepperoni";
            this.chkBoxPepperoni.Size = new System.Drawing.Size(109, 24);
            this.chkBoxPepperoni.TabIndex = 0;
            this.chkBoxPepperoni.Text = "Pepperoni";
            this.chkBoxPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkBoxPineapple
            // 
            this.chkBoxPineapple.AutoSize = true;
            this.chkBoxPineapple.ForeColor = System.Drawing.Color.Navy;
            this.chkBoxPineapple.Location = new System.Drawing.Point(15, 87);
            this.chkBoxPineapple.Name = "chkBoxPineapple";
            this.chkBoxPineapple.Size = new System.Drawing.Size(106, 24);
            this.chkBoxPineapple.TabIndex = 0;
            this.chkBoxPineapple.Text = "Pineapple";
            this.chkBoxPineapple.UseVisualStyleBackColor = true;
            // 
            // chkBoxCheese
            // 
            this.chkBoxCheese.AutoSize = true;
            this.chkBoxCheese.ForeColor = System.Drawing.Color.Navy;
            this.chkBoxCheese.Location = new System.Drawing.Point(15, 26);
            this.chkBoxCheese.Name = "chkBoxCheese";
            this.chkBoxCheese.Size = new System.Drawing.Size(84, 24);
            this.chkBoxCheese.TabIndex = 0;
            this.chkBoxCheese.Text = "Cheese";
            this.chkBoxCheese.UseVisualStyleBackColor = true;
            // 
            // lblDeliverCity
            // 
            this.lblDeliverCity.AutoSize = true;
            this.lblDeliverCity.Font = new System.Drawing.Font("Humnst777 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliverCity.Location = new System.Drawing.Point(235, 218);
            this.lblDeliverCity.Name = "lblDeliverCity";
            this.lblDeliverCity.Size = new System.Drawing.Size(83, 20);
            this.lblDeliverCity.TabIndex = 2;
            this.lblDeliverCity.Text = "Deliver to:";
            // 
            // lstBoxCities
            // 
            this.lstBoxCities.Font = new System.Drawing.Font("Humnst777 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxCities.FormattingEnabled = true;
            this.lstBoxCities.ItemHeight = 20;
            this.lstBoxCities.Items.AddRange(new object[] {
            "Lehi",
            "American Fork",
            "Orem",
            "Provo"});
            this.lstBoxCities.Location = new System.Drawing.Point(324, 218);
            this.lstBoxCities.Name = "lstBoxCities";
            this.lstBoxCities.Size = new System.Drawing.Size(120, 84);
            this.lstBoxCities.TabIndex = 3;
            // 
            // lblOrder
            // 
            this.lblOrder.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrder.Font = new System.Drawing.Font("Humnst777 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(91, 373);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(497, 46);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Humnst777 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(230, 318);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 43);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Humnst777 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(350, 318);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(98, 43);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Humnst777 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(592, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Humnst777 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(191, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 36);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Maranville Pizzaria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AMPizzaOrder.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(-75, -53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1090, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // PizzaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 483);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lstBoxCities);
            this.Controls.Add(this.lblDeliverCity);
            this.Controls.Add(this.grpBoxTopping);
            this.Controls.Add(this.grpBoxCrust);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PizzaOrderForm";
            this.Text = "Adrien\'s Pizza Application";
            this.Load += new System.EventHandler(this.PizzaOrderForm_Load);
            this.grpBoxCrust.ResumeLayout(false);
            this.grpBoxCrust.PerformLayout();
            this.grpBoxTopping.ResumeLayout(false);
            this.grpBoxTopping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCrust;
        private System.Windows.Forms.RadioButton rbtnThin;
        private System.Windows.Forms.RadioButton rbtnPan;
        private System.Windows.Forms.GroupBox grpBoxTopping;
        private System.Windows.Forms.CheckBox chkBoxPepperoni;
        private System.Windows.Forms.CheckBox chkBoxPineapple;
        private System.Windows.Forms.CheckBox chkBoxCheese;
        private System.Windows.Forms.Label lblDeliverCity;
        private System.Windows.Forms.ListBox lstBoxCities;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

