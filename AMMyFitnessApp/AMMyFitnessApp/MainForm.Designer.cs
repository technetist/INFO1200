namespace AMMyFitnessApp
{
    partial class mainForm
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
            this.btnDisplayWelcome = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(26, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(288, 41);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Adrien!";
            // 
            // btnDisplayWelcome
            // 
            this.btnDisplayWelcome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDisplayWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayWelcome.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDisplayWelcome.FlatAppearance.BorderSize = 2;
            this.btnDisplayWelcome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDisplayWelcome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisplayWelcome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayWelcome.Location = new System.Drawing.Point(218, 103);
            this.btnDisplayWelcome.Name = "btnDisplayWelcome";
            this.btnDisplayWelcome.Size = new System.Drawing.Size(96, 41);
            this.btnDisplayWelcome.TabIndex = 1;
            this.btnDisplayWelcome.Text = "Welcome";
            this.btnDisplayWelcome.UseVisualStyleBackColor = false;
            this.btnDisplayWelcome.Click += new System.EventHandler(this.btnDisplayWelcome_Click);
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
            this.btnProfile.Location = new System.Drawing.Point(33, 103);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(96, 41);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMainExit
            // 
            this.btnMainExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMainExit.FlatAppearance.BorderSize = 2;
            this.btnMainExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMainExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMainExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainExit.Location = new System.Drawing.Point(126, 170);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(96, 41);
            this.btnMainExit.TabIndex = 1;
            this.btnMainExit.Text = "Exit";
            this.btnMainExit.UseVisualStyleBackColor = false;
            this.btnMainExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 223);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnDisplayWelcome);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "mainForm";
            this.Text = "My Fitness App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnDisplayWelcome;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnMainExit;
    }
}

