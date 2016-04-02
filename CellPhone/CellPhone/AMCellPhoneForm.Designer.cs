namespace CellPhone
{
    partial class AMCellPhoneForm
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
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.txtBoxBrand = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.btnCreatePhone = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.objectGroupBox = new System.Windows.Forms.GroupBox();
            this.lblResultPrice = new System.Windows.Forms.Label();
            this.lblResultModel = new System.Windows.Forms.Label();
            this.lblResultBrand = new System.Windows.Forms.Label();
            this.priceObjLabel = new System.Windows.Forms.Label();
            this.modelObjLabel = new System.Windows.Forms.Label();
            this.brandObjLabel = new System.Windows.Forms.Label();
            this.dataGroupBox.SuspendLayout();
            this.objectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.txtBoxPrice);
            this.dataGroupBox.Controls.Add(this.txtBoxModel);
            this.dataGroupBox.Controls.Add(this.txtBoxBrand);
            this.dataGroupBox.Controls.Add(this.priceLabel);
            this.dataGroupBox.Controls.Add(this.modelLabel);
            this.dataGroupBox.Controls.Add(this.brandLabel);
            this.dataGroupBox.Location = new System.Drawing.Point(31, 25);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(192, 152);
            this.dataGroupBox.TabIndex = 0;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Enter Cell Phone Data";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(75, 99);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrice.TabIndex = 5;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(75, 60);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModel.TabIndex = 4;
            // 
            // txtBoxBrand
            // 
            this.txtBoxBrand.Location = new System.Drawing.Point(75, 25);
            this.txtBoxBrand.Name = "txtBoxBrand";
            this.txtBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBrand.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(7, 99);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(7, 63);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(7, 32);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(35, 13);
            this.brandLabel.TabIndex = 0;
            this.brandLabel.Text = "Brand";
            // 
            // btnCreatePhone
            // 
            this.btnCreatePhone.Location = new System.Drawing.Point(70, 340);
            this.btnCreatePhone.Name = "btnCreatePhone";
            this.btnCreatePhone.Size = new System.Drawing.Size(123, 34);
            this.btnCreatePhone.TabIndex = 1;
            this.btnCreatePhone.Text = "Create Phone";
            this.btnCreatePhone.UseVisualStyleBackColor = true;
            this.btnCreatePhone.Click += new System.EventHandler(this.btnCreatePhone_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(89, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // objectGroupBox
            // 
            this.objectGroupBox.Controls.Add(this.lblResultPrice);
            this.objectGroupBox.Controls.Add(this.lblResultModel);
            this.objectGroupBox.Controls.Add(this.lblResultBrand);
            this.objectGroupBox.Controls.Add(this.priceObjLabel);
            this.objectGroupBox.Controls.Add(this.modelObjLabel);
            this.objectGroupBox.Controls.Add(this.brandObjLabel);
            this.objectGroupBox.Location = new System.Drawing.Point(31, 200);
            this.objectGroupBox.Name = "objectGroupBox";
            this.objectGroupBox.Size = new System.Drawing.Size(192, 134);
            this.objectGroupBox.TabIndex = 3;
            this.objectGroupBox.TabStop = false;
            this.objectGroupBox.Text = "Object Properties";
            // 
            // lblResultPrice
            // 
            this.lblResultPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultPrice.Location = new System.Drawing.Point(83, 99);
            this.lblResultPrice.Name = "lblResultPrice";
            this.lblResultPrice.Size = new System.Drawing.Size(100, 23);
            this.lblResultPrice.TabIndex = 5;
            // 
            // lblResultModel
            // 
            this.lblResultModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultModel.Location = new System.Drawing.Point(83, 61);
            this.lblResultModel.Name = "lblResultModel";
            this.lblResultModel.Size = new System.Drawing.Size(100, 23);
            this.lblResultModel.TabIndex = 4;
            // 
            // lblResultBrand
            // 
            this.lblResultBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultBrand.Location = new System.Drawing.Point(83, 23);
            this.lblResultBrand.Name = "lblResultBrand";
            this.lblResultBrand.Size = new System.Drawing.Size(100, 23);
            this.lblResultBrand.TabIndex = 3;
            // 
            // priceObjLabel
            // 
            this.priceObjLabel.AutoSize = true;
            this.priceObjLabel.Location = new System.Drawing.Point(7, 104);
            this.priceObjLabel.Name = "priceObjLabel";
            this.priceObjLabel.Size = new System.Drawing.Size(31, 13);
            this.priceObjLabel.TabIndex = 2;
            this.priceObjLabel.Text = "Price";
            // 
            // modelObjLabel
            // 
            this.modelObjLabel.AutoSize = true;
            this.modelObjLabel.Location = new System.Drawing.Point(7, 63);
            this.modelObjLabel.Name = "modelObjLabel";
            this.modelObjLabel.Size = new System.Drawing.Size(36, 13);
            this.modelObjLabel.TabIndex = 1;
            this.modelObjLabel.Text = "Model";
            // 
            // brandObjLabel
            // 
            this.brandObjLabel.AutoSize = true;
            this.brandObjLabel.Location = new System.Drawing.Point(7, 26);
            this.brandObjLabel.Name = "brandObjLabel";
            this.brandObjLabel.Size = new System.Drawing.Size(35, 13);
            this.brandObjLabel.TabIndex = 0;
            this.brandObjLabel.Text = "Brand";
            // 
            // AMCellPhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 427);
            this.Controls.Add(this.objectGroupBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreatePhone);
            this.Controls.Add(this.dataGroupBox);
            this.Name = "AMCellPhoneForm";
            this.Text = "Adrien\'s Cell Phone Test";
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.objectGroupBox.ResumeLayout(false);
            this.objectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.TextBox txtBoxBrand;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Button btnCreatePhone;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox objectGroupBox;
        private System.Windows.Forms.Label lblResultPrice;
        private System.Windows.Forms.Label lblResultModel;
        private System.Windows.Forms.Label lblResultBrand;
        private System.Windows.Forms.Label priceObjLabel;
        private System.Windows.Forms.Label modelObjLabel;
        private System.Windows.Forms.Label brandObjLabel;
    }
}

