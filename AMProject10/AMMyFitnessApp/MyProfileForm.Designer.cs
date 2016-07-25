namespace AMMyFitnessApp
{
    partial class MyProfileForm
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
            this.btnProfileClose = new System.Windows.Forms.Button();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxPreferredName = new System.Windows.Forms.TextBox();
            this.lblPreferredName = new System.Windows.Forms.Label();
            this.grpBoxName = new System.Windows.Forms.GroupBox();
            this.grpBoxStats = new System.Windows.Forms.GroupBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.txtBoxHeight = new System.Windows.Forms.TextBox();
            this.picBoxAfter = new System.Windows.Forms.PictureBox();
            this.picBoxBefore = new System.Windows.Forms.PictureBox();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnAfter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBoxName.SuspendLayout();
            this.grpBoxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBefore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProfileClose
            // 
            this.btnProfileClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfileClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfileClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProfileClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProfileClose.FlatAppearance.BorderSize = 2;
            this.btnProfileClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProfileClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfileClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileClose.Location = new System.Drawing.Point(481, 354);
            this.btnProfileClose.Name = "btnProfileClose";
            this.btnProfileClose.Size = new System.Drawing.Size(53, 28);
            this.btnProfileClose.TabIndex = 10;
            this.btnProfileClose.Text = "&Close";
            this.btnProfileClose.UseVisualStyleBackColor = false;
            this.btnProfileClose.Click += new System.EventHandler(this.btnProfileExit_Click);
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(130, 62);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(140, 22);
            this.txtBoxLastName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(39, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(39, 61);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(130, 29);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(140, 22);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // txtBoxPreferredName
            // 
            this.txtBoxPreferredName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxPreferredName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPreferredName.Location = new System.Drawing.Point(130, 92);
            this.txtBoxPreferredName.Name = "txtBoxPreferredName";
            this.txtBoxPreferredName.Size = new System.Drawing.Size(140, 22);
            this.txtBoxPreferredName.TabIndex = 3;
            // 
            // lblPreferredName
            // 
            this.lblPreferredName.AutoSize = true;
            this.lblPreferredName.CausesValidation = false;
            this.lblPreferredName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferredName.Location = new System.Drawing.Point(4, 92);
            this.lblPreferredName.Name = "lblPreferredName";
            this.lblPreferredName.Size = new System.Drawing.Size(125, 20);
            this.lblPreferredName.TabIndex = 0;
            this.lblPreferredName.Text = "Preferred Name:";
            // 
            // grpBoxName
            // 
            this.grpBoxName.Controls.Add(this.lblPreferredName);
            this.grpBoxName.Controls.Add(this.txtBoxPreferredName);
            this.grpBoxName.Controls.Add(this.txtBoxFirstName);
            this.grpBoxName.Controls.Add(this.lblLastName);
            this.grpBoxName.Controls.Add(this.lblFirstName);
            this.grpBoxName.Controls.Add(this.txtBoxLastName);
            this.grpBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxName.Location = new System.Drawing.Point(13, 13);
            this.grpBoxName.Name = "grpBoxName";
            this.grpBoxName.Size = new System.Drawing.Size(289, 139);
            this.grpBoxName.TabIndex = 0;
            this.grpBoxName.TabStop = false;
            this.grpBoxName.Text = "Name Info:";
            // 
            // grpBoxStats
            // 
            this.grpBoxStats.Controls.Add(this.lblAge);
            this.grpBoxStats.Controls.Add(this.txtBoxAge);
            this.grpBoxStats.Controls.Add(this.lblHeight);
            this.grpBoxStats.Controls.Add(this.lblWeight);
            this.grpBoxStats.Controls.Add(this.txtBoxWeight);
            this.grpBoxStats.Controls.Add(this.txtBoxHeight);
            this.grpBoxStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxStats.Location = new System.Drawing.Point(13, 167);
            this.grpBoxStats.Name = "grpBoxStats";
            this.grpBoxStats.Size = new System.Drawing.Size(289, 139);
            this.grpBoxStats.TabIndex = 1;
            this.grpBoxStats.TabStop = false;
            this.grpBoxStats.Text = "My Stats:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.CausesValidation = false;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(87, 93);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 20);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age:";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAge.Location = new System.Drawing.Point(130, 92);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(140, 22);
            this.txtBoxAge.TabIndex = 3;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(69, 62);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(60, 20);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(66, 29);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(63, 20);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight:";
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWeight.Location = new System.Drawing.Point(130, 29);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(140, 22);
            this.txtBoxWeight.TabIndex = 1;
            // 
            // txtBoxHeight
            // 
            this.txtBoxHeight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHeight.Location = new System.Drawing.Point(130, 62);
            this.txtBoxHeight.Name = "txtBoxHeight";
            this.txtBoxHeight.Size = new System.Drawing.Size(140, 22);
            this.txtBoxHeight.TabIndex = 2;
            // 
            // picBoxAfter
            // 
            this.picBoxAfter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxAfter.Image = global::AMMyFitnessApp.Properties.Resources.After;
            this.picBoxAfter.Location = new System.Drawing.Point(384, 51);
            this.picBoxAfter.Name = "picBoxAfter";
            this.picBoxAfter.Size = new System.Drawing.Size(100, 197);
            this.picBoxAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAfter.TabIndex = 0;
            this.picBoxAfter.TabStop = false;
            this.picBoxAfter.Visible = false;
            // 
            // picBoxBefore
            // 
            this.picBoxBefore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxBefore.Image = global::AMMyFitnessApp.Properties.Resources.before;
            this.picBoxBefore.Location = new System.Drawing.Point(384, 51);
            this.picBoxBefore.Name = "picBoxBefore";
            this.picBoxBefore.Size = new System.Drawing.Size(100, 197);
            this.picBoxBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxBefore.TabIndex = 0;
            this.picBoxBefore.TabStop = false;
            // 
            // btnBefore
            // 
            this.btnBefore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBefore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBefore.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBefore.FlatAppearance.BorderSize = 2;
            this.btnBefore.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBefore.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBefore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBefore.Location = new System.Drawing.Point(336, 265);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(96, 41);
            this.btnBefore.TabIndex = 7;
            this.btnBefore.Text = "&Before";
            this.btnBefore.UseVisualStyleBackColor = false;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnAfter
            // 
            this.btnAfter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAfter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAfter.FlatAppearance.BorderSize = 2;
            this.btnAfter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAfter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAfter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfter.Location = new System.Drawing.Point(438, 265);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(96, 41);
            this.btnAfter.TabIndex = 8;
            this.btnAfter.Text = "&After";
            this.btnAfter.UseVisualStyleBackColor = false;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(13, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 41);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MyProfileForm
            // 
            this.AcceptButton = this.btnProfileClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(546, 394);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAfter);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.grpBoxStats);
            this.Controls.Add(this.btnProfileClose);
            this.Controls.Add(this.grpBoxName);
            this.Controls.Add(this.picBoxBefore);
            this.Controls.Add(this.picBoxAfter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MyProfileForm";
            this.Text = "My Profile";
            this.grpBoxName.ResumeLayout(false);
            this.grpBoxName.PerformLayout();
            this.grpBoxStats.ResumeLayout(false);
            this.grpBoxStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBefore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfileClose;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxPreferredName;
        private System.Windows.Forms.Label lblPreferredName;
        private System.Windows.Forms.GroupBox grpBoxName;
        private System.Windows.Forms.GroupBox grpBoxStats;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.TextBox txtBoxHeight;
        private System.Windows.Forms.PictureBox picBoxBefore;
        private System.Windows.Forms.PictureBox picBoxAfter;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnAfter;
        private System.Windows.Forms.Button btnClear;
    }
}