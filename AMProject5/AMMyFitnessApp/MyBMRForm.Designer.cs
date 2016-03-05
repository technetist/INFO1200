namespace AMMyFitnessApp
{
    partial class MyBMRForm
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
            this.btnBMRCalc = new System.Windows.Forms.Button();
            this.btnBMRClose = new System.Windows.Forms.Button();
            this.lstBoxActivityLevel = new System.Windows.Forms.ListBox();
            this.grpBoxGender = new System.Windows.Forms.GroupBox();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.rBtnFemale = new System.Windows.Forms.RadioButton();
            this.lblTitleActivityLevel = new System.Windows.Forms.Label();
            this.lblTitleBMR = new System.Windows.Forms.Label();
            this.txtBoxBMR = new System.Windows.Forms.TextBox();
            this.grpBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBMRCalc
            // 
            this.btnBMRCalc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBMRCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBMRCalc.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBMRCalc.FlatAppearance.BorderSize = 2;
            this.btnBMRCalc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBMRCalc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBMRCalc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMRCalc.Location = new System.Drawing.Point(202, 182);
            this.btnBMRCalc.Name = "btnBMRCalc";
            this.btnBMRCalc.Size = new System.Drawing.Size(96, 53);
            this.btnBMRCalc.TabIndex = 2;
            this.btnBMRCalc.Text = "Calculate &BMR";
            this.btnBMRCalc.UseVisualStyleBackColor = false;
            this.btnBMRCalc.Click += new System.EventHandler(this.btnBMRCalc_Click);
            // 
            // btnBMRClose
            // 
            this.btnBMRClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBMRClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBMRClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBMRClose.FlatAppearance.BorderSize = 2;
            this.btnBMRClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBMRClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBMRClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMRClose.Location = new System.Drawing.Point(392, 207);
            this.btnBMRClose.Name = "btnBMRClose";
            this.btnBMRClose.Size = new System.Drawing.Size(53, 28);
            this.btnBMRClose.TabIndex = 3;
            this.btnBMRClose.Text = "&Close";
            this.btnBMRClose.UseVisualStyleBackColor = false;
            this.btnBMRClose.Click += new System.EventHandler(this.btnBMRClose_Click);
            // 
            // lstBoxActivityLevel
            // 
            this.lstBoxActivityLevel.FormattingEnabled = true;
            this.lstBoxActivityLevel.Items.AddRange(new object[] {
            "Little to no exercise",
            "Light exercise (1–3 days per week)",
            "Moderate exercise (3–5 days per week)",
            "Heavy exercise (6–7 days per week)",
            "Very heavy exercise (twice per day, extra heavy workouts) "});
            this.lstBoxActivityLevel.Location = new System.Drawing.Point(14, 36);
            this.lstBoxActivityLevel.Name = "lstBoxActivityLevel";
            this.lstBoxActivityLevel.Size = new System.Drawing.Size(284, 95);
            this.lstBoxActivityLevel.TabIndex = 1;
            // 
            // grpBoxGender
            // 
            this.grpBoxGender.Controls.Add(this.rBtnFemale);
            this.grpBoxGender.Controls.Add(this.rBtnMale);
            this.grpBoxGender.Location = new System.Drawing.Point(317, 36);
            this.grpBoxGender.Name = "grpBoxGender";
            this.grpBoxGender.Size = new System.Drawing.Size(127, 91);
            this.grpBoxGender.TabIndex = 20;
            this.grpBoxGender.TabStop = false;
            this.grpBoxGender.Text = "Gender";
            // 
            // rBtnMale
            // 
            this.rBtnMale.AutoSize = true;
            this.rBtnMale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBtnMale.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMale.Location = new System.Drawing.Point(43, 22);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(57, 22);
            this.rBtnMale.TabIndex = 0;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Male";
            this.rBtnMale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBtnMale.UseMnemonic = false;
            this.rBtnMale.UseVisualStyleBackColor = true;
            // 
            // rBtnFemale
            // 
            this.rBtnFemale.AutoSize = true;
            this.rBtnFemale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBtnFemale.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnFemale.Location = new System.Drawing.Point(24, 50);
            this.rBtnFemale.Name = "rBtnFemale";
            this.rBtnFemale.Size = new System.Drawing.Size(76, 22);
            this.rBtnFemale.TabIndex = 1;
            this.rBtnFemale.TabStop = true;
            this.rBtnFemale.Text = "Female";
            this.rBtnFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblTitleActivityLevel
            // 
            this.lblTitleActivityLevel.AutoSize = true;
            this.lblTitleActivityLevel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleActivityLevel.Location = new System.Drawing.Point(14, 15);
            this.lblTitleActivityLevel.Name = "lblTitleActivityLevel";
            this.lblTitleActivityLevel.Size = new System.Drawing.Size(174, 18);
            this.lblTitleActivityLevel.TabIndex = 21;
            this.lblTitleActivityLevel.Text = "Choose your activity level:";
            // 
            // lblTitleBMR
            // 
            this.lblTitleBMR.AutoSize = true;
            this.lblTitleBMR.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBMR.Location = new System.Drawing.Point(122, 147);
            this.lblTitleBMR.Name = "lblTitleBMR";
            this.lblTitleBMR.Size = new System.Drawing.Size(55, 23);
            this.lblTitleBMR.TabIndex = 18;
            this.lblTitleBMR.Text = "BMR:";
            // 
            // txtBoxBMR
            // 
            this.txtBoxBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBMR.Location = new System.Drawing.Point(183, 143);
            this.txtBoxBMR.Name = "txtBoxBMR";
            this.txtBoxBMR.Size = new System.Drawing.Size(151, 31);
            this.txtBoxBMR.TabIndex = 0;
            this.txtBoxBMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MyBMRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 247);
            this.Controls.Add(this.txtBoxBMR);
            this.Controls.Add(this.lblTitleActivityLevel);
            this.Controls.Add(this.grpBoxGender);
            this.Controls.Add(this.lstBoxActivityLevel);
            this.Controls.Add(this.lblTitleBMR);
            this.Controls.Add(this.btnBMRClose);
            this.Controls.Add(this.btnBMRCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MyBMRForm";
            this.Text = "My BMR";
            this.grpBoxGender.ResumeLayout(false);
            this.grpBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBMRCalc;
        private System.Windows.Forms.Button btnBMRClose;
        private System.Windows.Forms.ListBox lstBoxActivityLevel;
        private System.Windows.Forms.GroupBox grpBoxGender;
        private System.Windows.Forms.RadioButton rBtnFemale;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.Label lblTitleActivityLevel;
        private System.Windows.Forms.Label lblTitleBMR;
        private System.Windows.Forms.TextBox txtBoxBMR;
    }
}