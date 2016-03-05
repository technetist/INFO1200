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
            this.lblMaleBMR = new System.Windows.Forms.Label();
            this.lblFemaleBMR = new System.Windows.Forms.Label();
            this.lblTitleFemaleBMR = new System.Windows.Forms.Label();
            this.lblTitleMaleBMR = new System.Windows.Forms.Label();
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
            this.btnBMRCalc.Location = new System.Drawing.Point(94, 118);
            this.btnBMRCalc.Name = "btnBMRCalc";
            this.btnBMRCalc.Size = new System.Drawing.Size(96, 53);
            this.btnBMRCalc.TabIndex = 3;
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
            this.btnBMRClose.Location = new System.Drawing.Point(219, 184);
            this.btnBMRClose.Name = "btnBMRClose";
            this.btnBMRClose.Size = new System.Drawing.Size(53, 28);
            this.btnBMRClose.TabIndex = 4;
            this.btnBMRClose.Text = "&Close";
            this.btnBMRClose.UseVisualStyleBackColor = false;
            this.btnBMRClose.Click += new System.EventHandler(this.btnBMRClose_Click);
            // 
            // lblMaleBMR
            // 
            this.lblMaleBMR.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblMaleBMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaleBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaleBMR.Location = new System.Drawing.Point(118, 29);
            this.lblMaleBMR.Name = "lblMaleBMR";
            this.lblMaleBMR.Size = new System.Drawing.Size(140, 22);
            this.lblMaleBMR.TabIndex = 1;
            this.lblMaleBMR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFemaleBMR
            // 
            this.lblFemaleBMR.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblFemaleBMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFemaleBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemaleBMR.Location = new System.Drawing.Point(118, 71);
            this.lblFemaleBMR.Name = "lblFemaleBMR";
            this.lblFemaleBMR.Size = new System.Drawing.Size(140, 22);
            this.lblFemaleBMR.TabIndex = 2;
            this.lblFemaleBMR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleFemaleBMR
            // 
            this.lblTitleFemaleBMR.AutoSize = true;
            this.lblTitleFemaleBMR.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFemaleBMR.Location = new System.Drawing.Point(15, 73);
            this.lblTitleFemaleBMR.Name = "lblTitleFemaleBMR";
            this.lblTitleFemaleBMR.Size = new System.Drawing.Size(97, 18);
            this.lblTitleFemaleBMR.TabIndex = 18;
            this.lblTitleFemaleBMR.Text = "Female BMR:";
            // 
            // lblTitleMaleBMR
            // 
            this.lblTitleMaleBMR.AutoSize = true;
            this.lblTitleMaleBMR.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMaleBMR.Location = new System.Drawing.Point(34, 31);
            this.lblTitleMaleBMR.Name = "lblTitleMaleBMR";
            this.lblTitleMaleBMR.Size = new System.Drawing.Size(78, 18);
            this.lblTitleMaleBMR.TabIndex = 18;
            this.lblTitleMaleBMR.Text = "Male BMR:";
            // 
            // MyBMRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 224);
            this.Controls.Add(this.lblTitleMaleBMR);
            this.Controls.Add(this.lblTitleFemaleBMR);
            this.Controls.Add(this.lblFemaleBMR);
            this.Controls.Add(this.lblMaleBMR);
            this.Controls.Add(this.btnBMRClose);
            this.Controls.Add(this.btnBMRCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MyBMRForm";
            this.Text = "My BMR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBMRCalc;
        private System.Windows.Forms.Button btnBMRClose;
        private System.Windows.Forms.Label lblMaleBMR;
        private System.Windows.Forms.Label lblFemaleBMR;
        private System.Windows.Forms.Label lblTitleFemaleBMR;
        private System.Windows.Forms.Label lblTitleMaleBMR;
    }
}