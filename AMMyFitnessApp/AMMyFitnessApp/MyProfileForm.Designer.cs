namespace AMMyFitnessApp
{
    partial class myProfileForm
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
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblPreferredName = new System.Windows.Forms.Label();
            this.txtBoxPreferredName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProfileClose
            // 
            this.btnProfileClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfileClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfileClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProfileClose.FlatAppearance.BorderSize = 2;
            this.btnProfileClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProfileClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfileClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileClose.Location = new System.Drawing.Point(102, 132);
            this.btnProfileClose.Name = "btnProfileClose";
            this.btnProfileClose.Size = new System.Drawing.Size(96, 41);
            this.btnProfileClose.TabIndex = 2;
            this.btnProfileClose.Text = "Close";
            this.btnProfileClose.UseVisualStyleBackColor = false;
            this.btnProfileClose.Click += new System.EventHandler(this.btnProfileExit_Click);
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(138, 26);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(140, 22);
            this.txtBoxFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(49, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 19);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(50, 58);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 19);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(138, 59);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(140, 22);
            this.txtBoxLastName.TabIndex = 6;
            // 
            // lblPreferredName
            // 
            this.lblPreferredName.AutoSize = true;
            this.lblPreferredName.CausesValidation = false;
            this.lblPreferredName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferredName.Location = new System.Drawing.Point(17, 89);
            this.lblPreferredName.Name = "lblPreferredName";
            this.lblPreferredName.Size = new System.Drawing.Size(115, 19);
            this.lblPreferredName.TabIndex = 9;
            this.lblPreferredName.Text = "Preferred Name:";
            // 
            // txtBoxPreferredName
            // 
            this.txtBoxPreferredName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxPreferredName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPreferredName.Location = new System.Drawing.Point(138, 89);
            this.txtBoxPreferredName.Name = "txtBoxPreferredName";
            this.txtBoxPreferredName.Size = new System.Drawing.Size(140, 22);
            this.txtBoxPreferredName.TabIndex = 8;
            // 
            // myProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 189);
            this.Controls.Add(this.lblPreferredName);
            this.Controls.Add(this.txtBoxPreferredName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.btnProfileClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "myProfileForm";
            this.Text = "My Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProfileClose;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblPreferredName;
        private System.Windows.Forms.TextBox txtBoxPreferredName;
    }
}