namespace AMBuyingCar
{
    partial class AMBuyCarForm
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
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lstBoxColor = new System.Windows.Forms.ListBox();
            this.lstBoxMake = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoBtnNew = new System.Windows.Forms.RadioButton();
            this.rdoBtnUsed = new System.Windows.Forms.RadioButton();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.btnDesignCar = new System.Windows.Forms.Button();
            this.lblDesignedCar = new System.Windows.Forms.Label();
            this.txtBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(30, 67);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(139, 23);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Choose a color:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(227, 67);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(176, 23);
            this.lblMake.TabIndex = 1;
            this.lblMake.Text = "Choose a car make:";
            // 
            // lstBoxColor
            // 
            this.lstBoxColor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxColor.FormattingEnabled = true;
            this.lstBoxColor.ItemHeight = 19;
            this.lstBoxColor.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Yellow",
            "Blue",
            "Green",
            "White",
            "Silver"});
            this.lstBoxColor.Location = new System.Drawing.Point(34, 93);
            this.lstBoxColor.Name = "lstBoxColor";
            this.lstBoxColor.Size = new System.Drawing.Size(135, 80);
            this.lstBoxColor.TabIndex = 2;
            // 
            // lstBoxMake
            // 
            this.lstBoxMake.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxMake.FormattingEnabled = true;
            this.lstBoxMake.ItemHeight = 19;
            this.lstBoxMake.Items.AddRange(new object[] {
            "Chevrolet",
            "Ford",
            "Toyota",
            "Scion",
            "Subaru",
            "Audi",
            "Lotus"});
            this.lstBoxMake.Location = new System.Drawing.Point(231, 93);
            this.lstBoxMake.Name = "lstBoxMake";
            this.lstBoxMake.Size = new System.Drawing.Size(172, 80);
            this.lstBoxMake.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Condition of Car:";
            // 
            // rdoBtnNew
            // 
            this.rdoBtnNew.AutoSize = true;
            this.rdoBtnNew.Checked = true;
            this.rdoBtnNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnNew.Location = new System.Drawing.Point(34, 229);
            this.rdoBtnNew.Name = "rdoBtnNew";
            this.rdoBtnNew.Size = new System.Drawing.Size(58, 23);
            this.rdoBtnNew.TabIndex = 5;
            this.rdoBtnNew.TabStop = true;
            this.rdoBtnNew.Text = "New";
            this.rdoBtnNew.UseVisualStyleBackColor = true;
            // 
            // rdoBtnUsed
            // 
            this.rdoBtnUsed.AutoSize = true;
            this.rdoBtnUsed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnUsed.Location = new System.Drawing.Point(34, 258);
            this.rdoBtnUsed.Name = "rdoBtnUsed";
            this.rdoBtnUsed.Size = new System.Drawing.Size(62, 23);
            this.rdoBtnUsed.TabIndex = 6;
            this.rdoBtnUsed.Text = "Used";
            this.rdoBtnUsed.UseVisualStyleBackColor = true;
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPrice.Location = new System.Drawing.Point(227, 202);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(97, 23);
            this.lblMaxPrice.TabIndex = 7;
            this.lblMaxPrice.Text = "Max Price:";
            // 
            // btnDesignCar
            // 
            this.btnDesignCar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesignCar.Location = new System.Drawing.Point(93, 312);
            this.btnDesignCar.Name = "btnDesignCar";
            this.btnDesignCar.Size = new System.Drawing.Size(231, 38);
            this.btnDesignCar.TabIndex = 8;
            this.btnDesignCar.Text = "Design Car";
            this.btnDesignCar.UseVisualStyleBackColor = true;
            this.btnDesignCar.Click += new System.EventHandler(this.btnDesignCar_Click);
            // 
            // lblDesignedCar
            // 
            this.lblDesignedCar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDesignedCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesignedCar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignedCar.Location = new System.Drawing.Point(49, 372);
            this.lblDesignedCar.Name = "lblDesignedCar";
            this.lblDesignedCar.Size = new System.Drawing.Size(334, 66);
            this.lblDesignedCar.TabIndex = 10;
            // 
            // txtBoxMaxPrice
            // 
            this.txtBoxMaxPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMaxPrice.Location = new System.Drawing.Point(231, 229);
            this.txtBoxMaxPrice.Name = "txtBoxMaxPrice";
            this.txtBoxMaxPrice.Size = new System.Drawing.Size(135, 27);
            this.txtBoxMaxPrice.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Car Buying Designer";
            // 
            // AMBuyCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMaxPrice);
            this.Controls.Add(this.lblDesignedCar);
            this.Controls.Add(this.btnDesignCar);
            this.Controls.Add(this.lblMaxPrice);
            this.Controls.Add(this.rdoBtnUsed);
            this.Controls.Add(this.rdoBtnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxMake);
            this.Controls.Add(this.lstBoxColor);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblColor);
            this.Name = "AMBuyCarForm";
            this.Text = "Adrien\'s Car Buying Form";
            this.Load += new System.EventHandler(this.AMBuyCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.ListBox lstBoxColor;
        private System.Windows.Forms.ListBox lstBoxMake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoBtnNew;
        private System.Windows.Forms.RadioButton rdoBtnUsed;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.Button btnDesignCar;
        private System.Windows.Forms.Label lblDesignedCar;
        private System.Windows.Forms.TextBox txtBoxMaxPrice;
        private System.Windows.Forms.Label label2;
    }
}

