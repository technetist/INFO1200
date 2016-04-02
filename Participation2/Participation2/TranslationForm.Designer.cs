namespace Participation2
{
    partial class TranslationForm
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
            this.lblTitleGoodMorning = new System.Windows.Forms.Label();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.btnItalian = new System.Windows.Forms.Button();
            this.btnSpanish = new System.Windows.Forms.Button();
            this.btnGerman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleGoodMorning
            // 
            this.lblTitleGoodMorning.AutoSize = true;
            this.lblTitleGoodMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGoodMorning.Location = new System.Drawing.Point(26, 27);
            this.lblTitleGoodMorning.Name = "lblTitleGoodMorning";
            this.lblTitleGoodMorning.Size = new System.Drawing.Size(582, 31);
            this.lblTitleGoodMorning.TabIndex = 0;
            this.lblTitleGoodMorning.Text = "Click a button and I will say \"Good morning\"";
            // 
            // lblTranslation
            // 
            this.lblTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslation.Location = new System.Drawing.Point(235, 211);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(164, 25);
            this.lblTranslation.TabIndex = 0;
            this.lblTranslation.Text = "Translation";
            this.lblTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnItalian
            // 
            this.btnItalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalian.Location = new System.Drawing.Point(48, 94);
            this.btnItalian.Name = "btnItalian";
            this.btnItalian.Size = new System.Drawing.Size(140, 56);
            this.btnItalian.TabIndex = 1;
            this.btnItalian.Text = "Italian";
            this.btnItalian.UseVisualStyleBackColor = true;
            this.btnItalian.Click += new System.EventHandler(this.btnItalian_Click);
            // 
            // btnSpanish
            // 
            this.btnSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpanish.Location = new System.Drawing.Point(246, 94);
            this.btnSpanish.Name = "btnSpanish";
            this.btnSpanish.Size = new System.Drawing.Size(140, 56);
            this.btnSpanish.TabIndex = 1;
            this.btnSpanish.Text = "Spanish";
            this.btnSpanish.UseVisualStyleBackColor = true;
            this.btnSpanish.Click += new System.EventHandler(this.btnSpanish_Click);
            // 
            // btnGerman
            // 
            this.btnGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerman.Location = new System.Drawing.Point(444, 94);
            this.btnGerman.Name = "btnGerman";
            this.btnGerman.Size = new System.Drawing.Size(140, 56);
            this.btnGerman.TabIndex = 1;
            this.btnGerman.Text = "German";
            this.btnGerman.UseVisualStyleBackColor = true;
            this.btnGerman.Click += new System.EventHandler(this.btnGerman_Click);
            // 
            // TranslationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 272);
            this.Controls.Add(this.btnGerman);
            this.Controls.Add(this.btnSpanish);
            this.Controls.Add(this.btnItalian);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.lblTitleGoodMorning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TranslationForm";
            this.Text = "Adrien\'s Language Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleGoodMorning;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.Button btnItalian;
        private System.Windows.Forms.Button btnSpanish;
        private System.Windows.Forms.Button btnGerman;
    }
}

