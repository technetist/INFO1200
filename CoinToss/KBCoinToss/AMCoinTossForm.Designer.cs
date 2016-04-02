namespace CoinToss
{
    partial class AMCoinTossForm
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
            this.lstBoxResults = new System.Windows.Forms.ListBox();
            this.coinLabel = new System.Windows.Forms.Label();
            this.btnToss5 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnToss1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxResults
            // 
            this.lstBoxResults.FormattingEnabled = true;
            this.lstBoxResults.Location = new System.Drawing.Point(70, 32);
            this.lstBoxResults.Name = "lstBoxResults";
            this.lstBoxResults.Size = new System.Drawing.Size(120, 95);
            this.lstBoxResults.TabIndex = 0;
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.Location = new System.Drawing.Point(67, 16);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(66, 13);
            this.coinLabel.TabIndex = 1;
            this.coinLabel.Text = "Toss Result:";
            // 
            // btnToss5
            // 
            this.btnToss5.Location = new System.Drawing.Point(56, 155);
            this.btnToss5.Name = "btnToss5";
            this.btnToss5.Size = new System.Drawing.Size(148, 38);
            this.btnToss5.TabIndex = 2;
            this.btnToss5.Text = "Toss Coin 5 Times";
            this.btnToss5.UseVisualStyleBackColor = true;
            this.btnToss5.Click += new System.EventHandler(this.btnToss5_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(33, 259);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(152, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnToss1
            // 
            this.btnToss1.Location = new System.Drawing.Point(93, 199);
            this.btnToss1.Name = "btnToss1";
            this.btnToss1.Size = new System.Drawing.Size(75, 31);
            this.btnToss1.TabIndex = 5;
            this.btnToss1.Text = "Flip Once";
            this.btnToss1.UseVisualStyleBackColor = true;
            this.btnToss1.Click += new System.EventHandler(this.btnToss1_Click);
            // 
            // AMCoinTossForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 313);
            this.Controls.Add(this.btnToss1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnToss5);
            this.Controls.Add(this.coinLabel);
            this.Controls.Add(this.lstBoxResults);
            this.Name = "AMCoinTossForm";
            this.Text = "Adrien\'s Coin Toss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxResults;
        private System.Windows.Forms.Label coinLabel;
        private System.Windows.Forms.Button btnToss5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnToss1;
    }
}

