namespace AMLoanApplication
{
    partial class AMLoanQualifierForm
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
            this.lblTitleSalary = new System.Windows.Forms.Label();
            this.lblTitleYearsWorked = new System.Windows.Forms.Label();
            this.txtBoxSalary = new System.Windows.Forms.TextBox();
            this.txtBoxYearsWorked = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBoxDeny = new System.Windows.Forms.PictureBox();
            this.picBoxApprove = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDeny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxApprove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleSalary
            // 
            this.lblTitleSalary.AutoSize = true;
            this.lblTitleSalary.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSalary.Location = new System.Drawing.Point(296, 19);
            this.lblTitleSalary.Name = "lblTitleSalary";
            this.lblTitleSalary.Size = new System.Drawing.Size(75, 28);
            this.lblTitleSalary.TabIndex = 0;
            this.lblTitleSalary.Text = "Salary";
            // 
            // lblTitleYearsWorked
            // 
            this.lblTitleYearsWorked.AutoSize = true;
            this.lblTitleYearsWorked.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleYearsWorked.Location = new System.Drawing.Point(252, 99);
            this.lblTitleYearsWorked.Name = "lblTitleYearsWorked";
            this.lblTitleYearsWorked.Size = new System.Drawing.Size(158, 28);
            this.lblTitleYearsWorked.TabIndex = 0;
            this.lblTitleYearsWorked.Text = "Years Worked";
            // 
            // txtBoxSalary
            // 
            this.txtBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSalary.Location = new System.Drawing.Point(190, 50);
            this.txtBoxSalary.Name = "txtBoxSalary";
            this.txtBoxSalary.Size = new System.Drawing.Size(287, 35);
            this.txtBoxSalary.TabIndex = 1;
            // 
            // txtBoxYearsWorked
            // 
            this.txtBoxYearsWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxYearsWorked.Location = new System.Drawing.Point(190, 130);
            this.txtBoxYearsWorked.Name = "txtBoxYearsWorked";
            this.txtBoxYearsWorked.Size = new System.Drawing.Size(287, 35);
            this.txtBoxYearsWorked.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(60, 323);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(111, 65);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(278, 323);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 65);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(496, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 65);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBoxDeny
            // 
            this.picBoxDeny.Image = global::AMLoanApplication.Properties.Resources.ricucyle;
            this.picBoxDeny.Location = new System.Drawing.Point(257, 189);
            this.picBoxDeny.Name = "picBoxDeny";
            this.picBoxDeny.Size = new System.Drawing.Size(153, 107);
            this.picBoxDeny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDeny.TabIndex = 4;
            this.picBoxDeny.TabStop = false;
            this.picBoxDeny.Visible = false;
            // 
            // picBoxApprove
            // 
            this.picBoxApprove.Image = global::AMLoanApplication.Properties.Resources._324415;
            this.picBoxApprove.Location = new System.Drawing.Point(257, 189);
            this.picBoxApprove.Name = "picBoxApprove";
            this.picBoxApprove.Size = new System.Drawing.Size(153, 107);
            this.picBoxApprove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxApprove.TabIndex = 3;
            this.picBoxApprove.TabStop = false;
            this.picBoxApprove.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AMLoanApplication.Properties.Resources.loan_icon;
            this.pictureBox4.Location = new System.Drawing.Point(483, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(220, 252);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AMLoanApplication.Properties.Resources.personal_app1;
            this.pictureBox3.Location = new System.Drawing.Point(-35, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(267, 295);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // AMLoanQualifierForm
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(667, 433);
            this.Controls.Add(this.picBoxDeny);
            this.Controls.Add(this.picBoxApprove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBoxYearsWorked);
            this.Controls.Add(this.txtBoxSalary);
            this.Controls.Add(this.lblTitleYearsWorked);
            this.Controls.Add(this.lblTitleSalary);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AMLoanQualifierForm";
            this.Text = "Adrien\'s Loan Qualifier";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDeny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxApprove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleSalary;
        private System.Windows.Forms.Label lblTitleYearsWorked;
        private System.Windows.Forms.TextBox txtBoxSalary;
        private System.Windows.Forms.TextBox txtBoxYearsWorked;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picBoxApprove;
        private System.Windows.Forms.PictureBox picBoxDeny;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

