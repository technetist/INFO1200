namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.txtBoxEngineSound = new System.Windows.Forms.TextBox();
            this.txtBoxDoorCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxEngineSound
            // 
            this.txtBoxEngineSound.Location = new System.Drawing.Point(92, 147);
            this.txtBoxEngineSound.Name = "txtBoxEngineSound";
            this.txtBoxEngineSound.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEngineSound.TabIndex = 0;
            // 
            // txtBoxDoorCount
            // 
            this.txtBoxDoorCount.Location = new System.Drawing.Point(93, 74);
            this.txtBoxDoorCount.Name = "txtBoxDoorCount";
            this.txtBoxDoorCount.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDoorCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many doors does your car have?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "What sound does your engine make?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxDoorCount);
            this.Controls.Add(this.txtBoxEngineSound);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxEngineSound;
        private System.Windows.Forms.TextBox txtBoxDoorCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

