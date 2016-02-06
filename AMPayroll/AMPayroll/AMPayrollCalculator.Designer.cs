namespace AMPayroll
{
    partial class AMPayrollCalculator
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
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblHourlyPay = new System.Windows.Forms.Label();
            this.txtBoxHoursWorked = new System.Windows.Forms.TextBox();
            this.txtBoxHourlyPay = new System.Windows.Forms.TextBox();
            this.lblTitleResults = new System.Windows.Forms.Label();
            this.lblCalcResults = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(17, 67);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(195, 29);
            this.lblHoursWorked.TabIndex = 0;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // lblHourlyPay
            // 
            this.lblHourlyPay.AutoSize = true;
            this.lblHourlyPay.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyPay.Location = new System.Drawing.Point(60, 115);
            this.lblHourlyPay.Name = "lblHourlyPay";
            this.lblHourlyPay.Size = new System.Drawing.Size(152, 29);
            this.lblHourlyPay.TabIndex = 0;
            this.lblHourlyPay.Text = "Hourly Pay:";
            // 
            // txtBoxHoursWorked
            // 
            this.txtBoxHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHoursWorked.Location = new System.Drawing.Point(218, 68);
            this.txtBoxHoursWorked.Name = "txtBoxHoursWorked";
            this.txtBoxHoursWorked.Size = new System.Drawing.Size(100, 31);
            this.txtBoxHoursWorked.TabIndex = 1;
            // 
            // txtBoxHourlyPay
            // 
            this.txtBoxHourlyPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHourlyPay.Location = new System.Drawing.Point(218, 116);
            this.txtBoxHourlyPay.Name = "txtBoxHourlyPay";
            this.txtBoxHourlyPay.Size = new System.Drawing.Size(100, 31);
            this.txtBoxHourlyPay.TabIndex = 2;
            // 
            // lblTitleResults
            // 
            this.lblTitleResults.AutoSize = true;
            this.lblTitleResults.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleResults.Location = new System.Drawing.Point(112, 175);
            this.lblTitleResults.Name = "lblTitleResults";
            this.lblTitleResults.Size = new System.Drawing.Size(111, 29);
            this.lblTitleResults.TabIndex = 0;
            this.lblTitleResults.Text = "Results:";
            // 
            // lblCalcResults
            // 
            this.lblCalcResults.BackColor = System.Drawing.SystemColors.Info;
            this.lblCalcResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalcResults.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcResults.Location = new System.Drawing.Point(43, 216);
            this.lblCalcResults.Name = "lblCalcResults";
            this.lblCalcResults.Size = new System.Drawing.Size(248, 29);
            this.lblCalcResults.TabIndex = 0;
            this.lblCalcResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(272, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(49, 266);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(104, 47);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "&Calulate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(182, 266);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 47);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AMPayroll.Properties.Resources.finance2;
            this.pictureBox1.Location = new System.Drawing.Point(22, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AMPayrollCalculator
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(334, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtBoxHourlyPay);
            this.Controls.Add(this.txtBoxHoursWorked);
            this.Controls.Add(this.lblHourlyPay);
            this.Controls.Add(this.lblCalcResults);
            this.Controls.Add(this.lblTitleResults);
            this.Controls.Add(this.lblHoursWorked);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AMPayrollCalculator";
            this.Text = "Adrien\'s Payroll Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblHourlyPay;
        private System.Windows.Forms.TextBox txtBoxHoursWorked;
        private System.Windows.Forms.TextBox txtBoxHourlyPay;
        private System.Windows.Forms.Label lblTitleResults;
        private System.Windows.Forms.Label lblCalcResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

