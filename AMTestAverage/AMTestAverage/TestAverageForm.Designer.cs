namespace AMTestAverage
{
    partial class TestAverageForm
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
            this.lblTest1 = new System.Windows.Forms.Label();
            this.txtBoxTest1 = new System.Windows.Forms.TextBox();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.lblTest3 = new System.Windows.Forms.Label();
            this.txtBoxTest2 = new System.Windows.Forms.TextBox();
            this.txtBoxTest3 = new System.Windows.Forms.TextBox();
            this.lblAvgResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalcAvg = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDisclaim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest1.Location = new System.Drawing.Point(42, 16);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(78, 25);
            this.lblTest1.TabIndex = 0;
            this.lblTest1.Text = "Test 1*";
            // 
            // txtBoxTest1
            // 
            this.txtBoxTest1.Location = new System.Drawing.Point(143, 21);
            this.txtBoxTest1.Name = "txtBoxTest1";
            this.txtBoxTest1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTest1.TabIndex = 1;
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest2.Location = new System.Drawing.Point(42, 61);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(78, 25);
            this.lblTest2.TabIndex = 0;
            this.lblTest2.Text = "Test 2*";
            // 
            // lblTest3
            // 
            this.lblTest3.AutoSize = true;
            this.lblTest3.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest3.Location = new System.Drawing.Point(42, 106);
            this.lblTest3.Name = "lblTest3";
            this.lblTest3.Size = new System.Drawing.Size(78, 25);
            this.lblTest3.TabIndex = 3;
            this.lblTest3.Text = "Test 3*";
            // 
            // txtBoxTest2
            // 
            this.txtBoxTest2.Location = new System.Drawing.Point(143, 66);
            this.txtBoxTest2.Name = "txtBoxTest2";
            this.txtBoxTest2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTest2.TabIndex = 2;
            // 
            // txtBoxTest3
            // 
            this.txtBoxTest3.Location = new System.Drawing.Point(143, 111);
            this.txtBoxTest3.Name = "txtBoxTest3";
            this.txtBoxTest3.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTest3.TabIndex = 3;
            // 
            // lblAvgResult
            // 
            this.lblAvgResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAvgResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgResult.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgResult.Location = new System.Drawing.Point(27, 276);
            this.lblAvgResult.Name = "lblAvgResult";
            this.lblAvgResult.Size = new System.Drawing.Size(230, 38);
            this.lblAvgResult.TabIndex = 3;
            this.lblAvgResult.Text = "Result";
            this.lblAvgResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Average Score";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(210, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalcAvg
            // 
            this.btnCalcAvg.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcAvg.Location = new System.Drawing.Point(48, 166);
            this.btnCalcAvg.Name = "btnCalcAvg";
            this.btnCalcAvg.Size = new System.Drawing.Size(188, 41);
            this.btnCalcAvg.TabIndex = 4;
            this.btnCalcAvg.Text = "Calculate Average";
            this.btnCalcAvg.UseVisualStyleBackColor = true;
            this.btnCalcAvg.Click += new System.EventHandler(this.btnCalcAvg_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDisclaim
            // 
            this.lblDisclaim.AutoSize = true;
            this.lblDisclaim.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaim.Location = new System.Drawing.Point(9, 147);
            this.lblDisclaim.Name = "lblDisclaim";
            this.lblDisclaim.Size = new System.Drawing.Size(266, 16);
            this.lblDisclaim.TabIndex = 0;
            this.lblDisclaim.Text = "*Enter numbers in percentages (without %)";
            // 
            // TestAverageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 391);
            this.Controls.Add(this.lblDisclaim);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcAvg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAvgResult);
            this.Controls.Add(this.lblTest3);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.txtBoxTest3);
            this.Controls.Add(this.txtBoxTest2);
            this.Controls.Add(this.txtBoxTest1);
            this.Controls.Add(this.lblTest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TestAverageForm";
            this.Text = "Adrien\'s Grader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.TextBox txtBoxTest1;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.Label lblTest3;
        private System.Windows.Forms.TextBox txtBoxTest2;
        private System.Windows.Forms.TextBox txtBoxTest3;
        private System.Windows.Forms.Label lblAvgResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalcAvg;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDisclaim;
    }
}

