namespace AMMyFitnessApp
{
    partial class MainForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.btnBMR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(26, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(288, 41);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Adrien!";
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProfile.FlatAppearance.BorderSize = 2;
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(67, 138);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(96, 41);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "My &Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMainExit
            // 
            this.btnMainExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMainExit.FlatAppearance.BorderSize = 2;
            this.btnMainExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMainExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMainExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainExit.Location = new System.Drawing.Point(275, 195);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(53, 28);
            this.btnMainExit.TabIndex = 3;
            this.btnMainExit.Text = "&Exit";
            this.btnMainExit.UseVisualStyleBackColor = false;
            this.btnMainExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(61, 74);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(97, 26);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Today is:";
            // 
            // lblShowDate
            // 
            this.lblShowDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowDate.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDate.Location = new System.Drawing.Point(164, 74);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(115, 26);
            this.lblShowDate.TabIndex = 0;
            this.lblShowDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBMR
            // 
            this.btnBMR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBMR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBMR.FlatAppearance.BorderSize = 2;
            this.btnBMR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBMR.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBMR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMR.Location = new System.Drawing.Point(177, 138);
            this.btnBMR.Name = "btnBMR";
            this.btnBMR.Size = new System.Drawing.Size(96, 41);
            this.btnBMR.TabIndex = 2;
            this.btnBMR.Text = "My &BMR";
            this.btnBMR.UseVisualStyleBackColor = false;
            this.btnBMR.Click += new System.EventHandler(this.btnBMR_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMainExit;
            this.ClientSize = new System.Drawing.Size(340, 235);
            this.Controls.Add(this.btnBMR);
            this.Controls.Add(this.lblShowDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "My Fitness App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnMainExit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblShowDate;
        private System.Windows.Forms.Button btnBMR;
    }
}

