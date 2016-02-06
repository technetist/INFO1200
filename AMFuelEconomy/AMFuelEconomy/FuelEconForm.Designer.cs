namespace AMFuelEconomy
{
    partial class FuelEconForm
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
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblGallons = new System.Windows.Forms.Label();
            this.lblTitleMPG = new System.Windows.Forms.Label();
            this.lblMPGResult = new System.Windows.Forms.Label();
            this.btnCalcMPG = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBoxMiles = new System.Windows.Forms.TextBox();
            this.txtBoxGallons = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiles.Location = new System.Drawing.Point(42, 22);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(82, 31);
            this.lblMiles.TabIndex = 0;
            this.lblMiles.Text = "Miles";
            // 
            // lblGallons
            // 
            this.lblGallons.AutoSize = true;
            this.lblGallons.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGallons.Location = new System.Drawing.Point(166, 22);
            this.lblGallons.Name = "lblGallons";
            this.lblGallons.Size = new System.Drawing.Size(113, 31);
            this.lblGallons.TabIndex = 1;
            this.lblGallons.Text = "Gallons";
            // 
            // lblTitleMPG
            // 
            this.lblTitleMPG.AutoSize = true;
            this.lblTitleMPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMPG.Location = new System.Drawing.Point(109, 182);
            this.lblTitleMPG.Name = "lblTitleMPG";
            this.lblTitleMPG.Size = new System.Drawing.Size(87, 31);
            this.lblTitleMPG.TabIndex = 2;
            this.lblTitleMPG.Text = "MPG:";
            // 
            // lblMPGResult
            // 
            this.lblMPGResult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMPGResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMPGResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPGResult.Location = new System.Drawing.Point(64, 218);
            this.lblMPGResult.Name = "lblMPGResult";
            this.lblMPGResult.Size = new System.Drawing.Size(187, 44);
            this.lblMPGResult.TabIndex = 2;
            this.lblMPGResult.Text = "MPG Result";
            this.lblMPGResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcMPG
            // 
            this.btnCalcMPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcMPG.Location = new System.Drawing.Point(83, 97);
            this.btnCalcMPG.Name = "btnCalcMPG";
            this.btnCalcMPG.Size = new System.Drawing.Size(137, 76);
            this.btnCalcMPG.TabIndex = 3;
            this.btnCalcMPG.Text = "Calculate MPG";
            this.btnCalcMPG.UseVisualStyleBackColor = true;
            this.btnCalcMPG.Click += new System.EventHandler(this.btnCalcMPG_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(221, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBoxMiles
            // 
            this.txtBoxMiles.Location = new System.Drawing.Point(28, 56);
            this.txtBoxMiles.Name = "txtBoxMiles";
            this.txtBoxMiles.Size = new System.Drawing.Size(110, 20);
            this.txtBoxMiles.TabIndex = 5;
            // 
            // txtBoxGallons
            // 
            this.txtBoxGallons.Location = new System.Drawing.Point(163, 56);
            this.txtBoxGallons.Name = "txtBoxGallons";
            this.txtBoxGallons.Size = new System.Drawing.Size(120, 20);
            this.txtBoxGallons.TabIndex = 6;
            // 
            // FuelEconForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 312);
            this.Controls.Add(this.txtBoxGallons);
            this.Controls.Add(this.txtBoxMiles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalcMPG);
            this.Controls.Add(this.lblMPGResult);
            this.Controls.Add(this.lblTitleMPG);
            this.Controls.Add(this.lblGallons);
            this.Controls.Add(this.lblMiles);
            this.Name = "FuelEconForm";
            this.Text = "Adrien\'s Fuel Economy Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblGallons;
        private System.Windows.Forms.Label lblTitleMPG;
        private System.Windows.Forms.Label lblMPGResult;
        private System.Windows.Forms.Button btnCalcMPG;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBoxMiles;
        private System.Windows.Forms.TextBox txtBoxGallons;
    }
}

