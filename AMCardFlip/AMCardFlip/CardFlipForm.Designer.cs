namespace AMCardFlip
{
    partial class CardFlipForm
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
            this.grpBoxDeck = new System.Windows.Forms.GroupBox();
            this.picBoxBack = new System.Windows.Forms.PictureBox();
            this.picBoxFace = new System.Windows.Forms.PictureBox();
            this.btnCardFace = new System.Windows.Forms.Button();
            this.btnCardBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxDeck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFace)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxDeck
            // 
            this.grpBoxDeck.Controls.Add(this.picBoxBack);
            this.grpBoxDeck.Controls.Add(this.picBoxFace);
            this.grpBoxDeck.Location = new System.Drawing.Point(33, 35);
            this.grpBoxDeck.Name = "grpBoxDeck";
            this.grpBoxDeck.Size = new System.Drawing.Size(489, 283);
            this.grpBoxDeck.TabIndex = 0;
            this.grpBoxDeck.TabStop = false;
            this.grpBoxDeck.Text = "My Deck";
            // 
            // picBoxBack
            // 
            this.picBoxBack.Image = global::AMCardFlip.Properties.Resources.Backface_Blue;
            this.picBoxBack.Location = new System.Drawing.Point(157, 29);
            this.picBoxBack.Name = "picBoxBack";
            this.picBoxBack.Size = new System.Drawing.Size(174, 233);
            this.picBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBack.TabIndex = 0;
            this.picBoxBack.TabStop = false;
            // 
            // picBoxFace
            // 
            this.picBoxFace.Image = global::AMCardFlip.Properties.Resources.Ace_Spades;
            this.picBoxFace.Location = new System.Drawing.Point(157, 29);
            this.picBoxFace.Name = "picBoxFace";
            this.picBoxFace.Size = new System.Drawing.Size(174, 233);
            this.picBoxFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFace.TabIndex = 0;
            this.picBoxFace.TabStop = false;
            this.picBoxFace.Visible = false;
            // 
            // btnCardFace
            // 
            this.btnCardFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardFace.Location = new System.Drawing.Point(62, 324);
            this.btnCardFace.Name = "btnCardFace";
            this.btnCardFace.Size = new System.Drawing.Size(174, 46);
            this.btnCardFace.TabIndex = 1;
            this.btnCardFace.Text = "Show Card Face";
            this.btnCardFace.UseVisualStyleBackColor = true;
            this.btnCardFace.Click += new System.EventHandler(this.btnCardFace_Click);
            // 
            // btnCardBack
            // 
            this.btnCardBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardBack.Location = new System.Drawing.Point(318, 324);
            this.btnCardBack.Name = "btnCardBack";
            this.btnCardBack.Size = new System.Drawing.Size(174, 46);
            this.btnCardBack.TabIndex = 1;
            this.btnCardBack.Text = "Show Card Back";
            this.btnCardBack.UseVisualStyleBackColor = true;
            this.btnCardBack.Click += new System.EventHandler(this.btnCardBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(238, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CardFlipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 445);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCardBack);
            this.Controls.Add(this.btnCardFace);
            this.Controls.Add(this.grpBoxDeck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CardFlipForm";
            this.Text = "Adrien\'s Card Flip";
            this.grpBoxDeck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxDeck;
        private System.Windows.Forms.PictureBox picBoxBack;
        private System.Windows.Forms.PictureBox picBoxFace;
        private System.Windows.Forms.Button btnCardFace;
        private System.Windows.Forms.Button btnCardBack;
        private System.Windows.Forms.Button btnExit;
    }
}

