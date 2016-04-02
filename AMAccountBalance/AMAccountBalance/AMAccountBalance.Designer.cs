namespace AMAccountBalance
{
    partial class AMAccountBalance
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
            this.lblTitleStart = new System.Windows.Forms.Label();
            this.lblTitleNumMonths = new System.Windows.Forms.Label();
            this.lblTitleEndBalance = new System.Windows.Forms.Label();
            this.txtBoxStart = new System.Windows.Forms.TextBox();
            this.txtBoxNumMonths = new System.Windows.Forms.TextBox();
            this.lblEndBalance = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitleHeadline = new System.Windows.Forms.Label();
            this.lstBoxMonthlyBalance = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleStart
            // 
            this.lblTitleStart.AutoSize = true;
            this.lblTitleStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitleStart.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitleStart.Location = new System.Drawing.Point(64, 111);
            this.lblTitleStart.Name = "lblTitleStart";
            this.lblTitleStart.Size = new System.Drawing.Size(185, 29);
            this.lblTitleStart.TabIndex = 0;
            this.lblTitleStart.Text = "Starting Balance";
            // 
            // lblTitleNumMonths
            // 
            this.lblTitleNumMonths.AutoSize = true;
            this.lblTitleNumMonths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitleNumMonths.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleNumMonths.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitleNumMonths.Location = new System.Drawing.Point(38, 157);
            this.lblTitleNumMonths.Name = "lblTitleNumMonths";
            this.lblTitleNumMonths.Size = new System.Drawing.Size(211, 29);
            this.lblTitleNumMonths.TabIndex = 0;
            this.lblTitleNumMonths.Text = "Number of Months";
            // 
            // lblTitleEndBalance
            // 
            this.lblTitleEndBalance.AutoSize = true;
            this.lblTitleEndBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitleEndBalance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEndBalance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitleEndBalance.Location = new System.Drawing.Point(76, 227);
            this.lblTitleEndBalance.Name = "lblTitleEndBalance";
            this.lblTitleEndBalance.Size = new System.Drawing.Size(173, 29);
            this.lblTitleEndBalance.TabIndex = 0;
            this.lblTitleEndBalance.Text = "Ending Balance";
            // 
            // txtBoxStart
            // 
            this.txtBoxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStart.Location = new System.Drawing.Point(299, 111);
            this.txtBoxStart.Name = "txtBoxStart";
            this.txtBoxStart.Size = new System.Drawing.Size(134, 31);
            this.txtBoxStart.TabIndex = 1;
            // 
            // txtBoxNumMonths
            // 
            this.txtBoxNumMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumMonths.Location = new System.Drawing.Point(299, 157);
            this.txtBoxNumMonths.Name = "txtBoxNumMonths";
            this.txtBoxNumMonths.Size = new System.Drawing.Size(134, 31);
            this.txtBoxNumMonths.TabIndex = 2;
            // 
            // lblEndBalance
            // 
            this.lblEndBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEndBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEndBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndBalance.Location = new System.Drawing.Point(293, 207);
            this.lblEndBalance.Name = "lblEndBalance";
            this.lblEndBalance.Size = new System.Drawing.Size(148, 100);
            this.lblEndBalance.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(312, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 39);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(312, 313);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(104, 39);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(651, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AMAccountBalance.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(162, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 95);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitleHeadline
            // 
            this.lblTitleHeadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(81)))), ((int)(((byte)(168)))));
            this.lblTitleHeadline.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHeadline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleHeadline.Location = new System.Drawing.Point(173, 21);
            this.lblTitleHeadline.Name = "lblTitleHeadline";
            this.lblTitleHeadline.Size = new System.Drawing.Size(118, 75);
            this.lblTitleHeadline.TabIndex = 5;
            this.lblTitleHeadline.Text = "Account Balance";
            // 
            // lstBoxMonthlyBalance
            // 
            this.lstBoxMonthlyBalance.FormattingEnabled = true;
            this.lstBoxMonthlyBalance.Location = new System.Drawing.Point(457, 125);
            this.lstBoxMonthlyBalance.Name = "lstBoxMonthlyBalance";
            this.lstBoxMonthlyBalance.Size = new System.Drawing.Size(253, 160);
            this.lstBoxMonthlyBalance.TabIndex = 6;
            // 
            // AMAccountBalance
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(96)))), ((int)(((byte)(183)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(722, 421);
            this.Controls.Add(this.lstBoxMonthlyBalance);
            this.Controls.Add(this.lblTitleHeadline);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblEndBalance);
            this.Controls.Add(this.txtBoxNumMonths);
            this.Controls.Add(this.txtBoxStart);
            this.Controls.Add(this.lblTitleEndBalance);
            this.Controls.Add(this.lblTitleNumMonths);
            this.Controls.Add(this.lblTitleStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AMAccountBalance";
            this.Text = "Adrien\'s Account Balance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleStart;
        private System.Windows.Forms.Label lblTitleNumMonths;
        private System.Windows.Forms.Label lblTitleEndBalance;
        private System.Windows.Forms.TextBox txtBoxStart;
        private System.Windows.Forms.TextBox txtBoxNumMonths;
        private System.Windows.Forms.Label lblEndBalance;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitleHeadline;
        private System.Windows.Forms.ListBox lstBoxMonthlyBalance;
    }
}

