namespace AMMyFitnessApp
{
    partial class MyTimerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.lblDisplayExercise = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxRest = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.lstBoxTime = new System.Windows.Forms.ListBox();
            this.lstBoxExercise = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.txtBoxExercise = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDisplayTime);
            this.panel1.Controls.Add(this.lblDisplayExercise);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnTimerStart);
            this.panel1.Location = new System.Drawing.Point(27, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 303);
            this.panel1.TabIndex = 1;
            // 
            // lblDisplayTime
            // 
            this.lblDisplayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayTime.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTime.Location = new System.Drawing.Point(17, 108);
            this.lblDisplayTime.Name = "lblDisplayTime";
            this.lblDisplayTime.Size = new System.Drawing.Size(166, 60);
            this.lblDisplayTime.TabIndex = 6;
            this.lblDisplayTime.Text = "00:00";
            this.lblDisplayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayExercise
            // 
            this.lblDisplayExercise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayExercise.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayExercise.Location = new System.Drawing.Point(36, 63);
            this.lblDisplayExercise.Name = "lblDisplayExercise";
            this.lblDisplayExercise.Size = new System.Drawing.Size(129, 37);
            this.lblDisplayExercise.TabIndex = 5;
            this.lblDisplayExercise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(63, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 26);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Timer:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(73, 225);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTimerStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimerStart.Enabled = false;
            this.btnTimerStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTimerStart.FlatAppearance.BorderSize = 2;
            this.btnTimerStart.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTimerStart.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimerStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerStart.Location = new System.Drawing.Point(52, 176);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(96, 41);
            this.btnTimerStart.TabIndex = 0;
            this.btnTimerStart.Text = "&Start";
            this.btnTimerStart.UseVisualStyleBackColor = false;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBoxRest);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSumbit);
            this.panel2.Controls.Add(this.lstBoxTime);
            this.panel2.Controls.Add(this.lstBoxExercise);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtBoxTime);
            this.panel2.Controls.Add(this.txtBoxExercise);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(249, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 303);
            this.panel2.TabIndex = 1;
            // 
            // txtBoxRest
            // 
            this.txtBoxRest.Location = new System.Drawing.Point(38, 239);
            this.txtBoxRest.Name = "txtBoxRest";
            this.txtBoxRest.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRest.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Rest Interval:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(185, 275);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 25);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSumbit
            // 
            this.btnSumbit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSumbit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumbit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSumbit.FlatAppearance.BorderSize = 2;
            this.btnSumbit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSumbit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSumbit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumbit.Location = new System.Drawing.Point(154, 230);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(85, 36);
            this.btnSumbit.TabIndex = 5;
            this.btnSumbit.Text = "Submit";
            this.btnSumbit.UseVisualStyleBackColor = false;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // lstBoxTime
            // 
            this.lstBoxTime.FormattingEnabled = true;
            this.lstBoxTime.Location = new System.Drawing.Point(152, 113);
            this.lstBoxTime.Name = "lstBoxTime";
            this.lstBoxTime.Size = new System.Drawing.Size(71, 95);
            this.lstBoxTime.TabIndex = 15;
            // 
            // lstBoxExercise
            // 
            this.lstBoxExercise.FormattingEnabled = true;
            this.lstBoxExercise.Location = new System.Drawing.Point(31, 113);
            this.lstBoxExercise.Name = "lstBoxExercise";
            this.lstBoxExercise.Size = new System.Drawing.Size(103, 95);
            this.lstBoxExercise.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Time:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Exercise List:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Exercise:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(188, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Location = new System.Drawing.Point(118, 68);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(55, 20);
            this.txtBoxTime.TabIndex = 2;
            // 
            // txtBoxExercise
            // 
            this.txtBoxExercise.Location = new System.Drawing.Point(12, 68);
            this.txtBoxExercise.Name = "txtBoxExercise";
            this.txtBoxExercise.Size = new System.Drawing.Size(100, 20);
            this.txtBoxExercise.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Timer Setup:";
            // 
            // MyTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 359);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MyTimerForm";
            this.Text = "Timer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTimerStart;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Label lblDisplayExercise;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxTime;
        private System.Windows.Forms.TextBox txtBoxExercise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBoxTime;
        private System.Windows.Forms.ListBox lstBoxExercise;
        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBoxRest;
        private System.Windows.Forms.Label label7;
    }
}