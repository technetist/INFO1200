﻿namespace AMMyFitnessApp
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
            this.btnMyTimer = new System.Windows.Forms.Button();
            this.btnBMR = new System.Windows.Forms.Button();
            this.btnExerciseLog = new System.Windows.Forms.Button();
            this.btnWaterLog = new System.Windows.Forms.Button();
            this.btnFoodLog = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnProfile.Location = new System.Drawing.Point(11, 141);
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
            this.btnMainExit.Location = new System.Drawing.Point(275, 297);
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
            // btnMyTimer
            // 
            this.btnMyTimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMyTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyTimer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMyTimer.FlatAppearance.BorderSize = 2;
            this.btnMyTimer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMyTimer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMyTimer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyTimer.Location = new System.Drawing.Point(232, 141);
            this.btnMyTimer.Name = "btnMyTimer";
            this.btnMyTimer.Size = new System.Drawing.Size(96, 41);
            this.btnMyTimer.TabIndex = 4;
            this.btnMyTimer.Text = "My &Timer";
            this.btnMyTimer.UseVisualStyleBackColor = false;
            this.btnMyTimer.Click += new System.EventHandler(this.btnMyTimer_Click);
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
            this.btnBMR.Location = new System.Drawing.Point(122, 141);
            this.btnBMR.Name = "btnBMR";
            this.btnBMR.Size = new System.Drawing.Size(96, 41);
            this.btnBMR.TabIndex = 2;
            this.btnBMR.Text = "My &BMR";
            this.btnBMR.UseVisualStyleBackColor = false;
            this.btnBMR.Click += new System.EventHandler(this.btnBMR_Click);
            // 
            // btnExerciseLog
            // 
            this.btnExerciseLog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExerciseLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExerciseLog.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExerciseLog.FlatAppearance.BorderSize = 2;
            this.btnExerciseLog.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExerciseLog.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExerciseLog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExerciseLog.Location = new System.Drawing.Point(230, 188);
            this.btnExerciseLog.Name = "btnExerciseLog";
            this.btnExerciseLog.Size = new System.Drawing.Size(100, 41);
            this.btnExerciseLog.TabIndex = 5;
            this.btnExerciseLog.Text = "&Exercise Log";
            this.btnExerciseLog.UseVisualStyleBackColor = false;
            this.btnExerciseLog.Click += new System.EventHandler(this.btnExerciseLog_Click);
            // 
            // btnWaterLog
            // 
            this.btnWaterLog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWaterLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWaterLog.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnWaterLog.FlatAppearance.BorderSize = 2;
            this.btnWaterLog.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnWaterLog.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWaterLog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaterLog.Location = new System.Drawing.Point(12, 188);
            this.btnWaterLog.Name = "btnWaterLog";
            this.btnWaterLog.Size = new System.Drawing.Size(96, 41);
            this.btnWaterLog.TabIndex = 6;
            this.btnWaterLog.Text = "&Water Log";
            this.btnWaterLog.UseVisualStyleBackColor = false;
            this.btnWaterLog.Click += new System.EventHandler(this.btnWaterLog_Click);
            // 
            // btnFoodLog
            // 
            this.btnFoodLog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFoodLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodLog.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFoodLog.FlatAppearance.BorderSize = 2;
            this.btnFoodLog.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFoodLog.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFoodLog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodLog.Location = new System.Drawing.Point(122, 188);
            this.btnFoodLog.Name = "btnFoodLog";
            this.btnFoodLog.Size = new System.Drawing.Size(96, 41);
            this.btnFoodLog.TabIndex = 7;
            this.btnFoodLog.Text = "&Food Log";
            this.btnFoodLog.UseVisualStyleBackColor = false;
            this.btnFoodLog.Click += new System.EventHandler(this.btnFoodLog_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(122, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Meal &Plan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMainExit;
            this.ClientSize = new System.Drawing.Size(340, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFoodLog);
            this.Controls.Add(this.btnWaterLog);
            this.Controls.Add(this.btnExerciseLog);
            this.Controls.Add(this.btnMyTimer);
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
        private System.Windows.Forms.Button btnMyTimer;
        private System.Windows.Forms.Button btnBMR;
        private System.Windows.Forms.Button btnExerciseLog;
        private System.Windows.Forms.Button btnWaterLog;
        private System.Windows.Forms.Button btnFoodLog;
        private System.Windows.Forms.Button button1;
    }
}

