namespace AMMyFitnessApp
{
    partial class MyExerciseLogForm
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.txtBoxExercise = new System.Windows.Forms.TextBox();
            this.txtBoxDuration = new System.Windows.Forms.TextBox();
            this.txtBoxCalorie = new System.Windows.Forms.TextBox();
            this.lblTitleExercise = new System.Windows.Forms.Label();
            this.lblTitleDuration = new System.Windows.Forms.Label();
            this.lblTitleCalories = new System.Windows.Forms.Label();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.lstBoxExercise = new System.Windows.Forms.ListBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "txt";
            this.openFile.FileName = "ExerciseLog";
            // 
            // lblShowDate
            // 
            this.lblShowDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowDate.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDate.Location = new System.Drawing.Point(12, 9);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(115, 26);
            this.lblShowDate.TabIndex = 0;
            // 
            // txtBoxExercise
            // 
            this.txtBoxExercise.Location = new System.Drawing.Point(13, 69);
            this.txtBoxExercise.Name = "txtBoxExercise";
            this.txtBoxExercise.Size = new System.Drawing.Size(100, 20);
            this.txtBoxExercise.TabIndex = 1;
            // 
            // txtBoxDuration
            // 
            this.txtBoxDuration.Location = new System.Drawing.Point(119, 69);
            this.txtBoxDuration.Name = "txtBoxDuration";
            this.txtBoxDuration.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDuration.TabIndex = 2;
            // 
            // txtBoxCalorie
            // 
            this.txtBoxCalorie.Location = new System.Drawing.Point(225, 69);
            this.txtBoxCalorie.Name = "txtBoxCalorie";
            this.txtBoxCalorie.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCalorie.TabIndex = 3;
            // 
            // lblTitleExercise
            // 
            this.lblTitleExercise.AutoSize = true;
            this.lblTitleExercise.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleExercise.Location = new System.Drawing.Point(12, 49);
            this.lblTitleExercise.Name = "lblTitleExercise";
            this.lblTitleExercise.Size = new System.Drawing.Size(59, 17);
            this.lblTitleExercise.TabIndex = 11;
            this.lblTitleExercise.Text = "Exercise:";
            this.lblTitleExercise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleDuration
            // 
            this.lblTitleDuration.AutoSize = true;
            this.lblTitleDuration.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDuration.Location = new System.Drawing.Point(116, 49);
            this.lblTitleDuration.Name = "lblTitleDuration";
            this.lblTitleDuration.Size = new System.Drawing.Size(101, 17);
            this.lblTitleDuration.TabIndex = 12;
            this.lblTitleDuration.Text = "Duration (min)";
            this.lblTitleDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleCalories
            // 
            this.lblTitleCalories.AutoSize = true;
            this.lblTitleCalories.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCalories.Location = new System.Drawing.Point(222, 49);
            this.lblTitleCalories.Name = "lblTitleCalories";
            this.lblTitleCalories.Size = new System.Drawing.Size(59, 17);
            this.lblTitleCalories.TabIndex = 13;
            this.lblTitleCalories.Text = "Calories:";
            this.lblTitleCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddExercise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddExercise.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddExercise.FlatAppearance.BorderSize = 2;
            this.btnAddExercise.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddExercise.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddExercise.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExercise.Location = new System.Drawing.Point(119, 99);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(100, 25);
            this.btnAddExercise.TabIndex = 4;
            this.btnAddExercise.Text = "Add Exercise";
            this.btnAddExercise.UseVisualStyleBackColor = false;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // lstBoxExercise
            // 
            this.lstBoxExercise.FormattingEnabled = true;
            this.lstBoxExercise.Location = new System.Drawing.Point(15, 134);
            this.lstBoxExercise.Name = "lstBoxExercise";
            this.lstBoxExercise.Size = new System.Drawing.Size(310, 69);
            this.lstBoxExercise.TabIndex = 15;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSaveFile.FlatAppearance.BorderSize = 2;
            this.btnSaveFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSaveFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.Location = new System.Drawing.Point(187, 218);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(77, 28);
            this.btnSaveFile.TabIndex = 5;
            this.btnSaveFile.Text = "Save Log";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
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
            this.btnClose.Location = new System.Drawing.Point(270, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MyExerciseLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 258);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.lstBoxExercise);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.lblTitleCalories);
            this.Controls.Add(this.lblTitleDuration);
            this.Controls.Add(this.lblTitleExercise);
            this.Controls.Add(this.txtBoxCalorie);
            this.Controls.Add(this.txtBoxDuration);
            this.Controls.Add(this.txtBoxExercise);
            this.Controls.Add(this.lblShowDate);
            this.Name = "MyExerciseLogForm";
            this.Text = "My Exercise Log";
            this.Load += new System.EventHandler(this.MyExerciseLogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Label lblShowDate;
        private System.Windows.Forms.TextBox txtBoxExercise;
        private System.Windows.Forms.TextBox txtBoxDuration;
        private System.Windows.Forms.TextBox txtBoxCalorie;
        private System.Windows.Forms.Label lblTitleExercise;
        private System.Windows.Forms.Label lblTitleDuration;
        private System.Windows.Forms.Label lblTitleCalories;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.ListBox lstBoxExercise;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnClose;
    }
}