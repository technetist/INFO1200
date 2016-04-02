namespace ReadWrite
{
    partial class writeReadForm
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
            this.lblTitleCountry = new System.Windows.Forms.Label();
            this.lstBoxWrite = new System.Windows.Forms.ListBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.lstBoxRead = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleCountry
            // 
            this.lblTitleCountry.AutoSize = true;
            this.lblTitleCountry.Location = new System.Drawing.Point(23, 28);
            this.lblTitleCountry.Name = "lblTitleCountry";
            this.lblTitleCountry.Size = new System.Drawing.Size(135, 13);
            this.lblTitleCountry.TabIndex = 0;
            this.lblTitleCountry.Text = "Countries of South America";
            // 
            // lstBoxWrite
            // 
            this.lstBoxWrite.FormattingEnabled = true;
            this.lstBoxWrite.Items.AddRange(new object[] {
            "Argentina",
            "Bolivia",
            "Brazil",
            "Chile",
            "Columbia",
            "Ecuador",
            "Falkland Islands",
            "French Guiana",
            "Guyana",
            "Paraguay",
            "Peru",
            "Suriname",
            "Uruguay",
            "Venezuela"});
            this.lstBoxWrite.Location = new System.Drawing.Point(38, 55);
            this.lstBoxWrite.Name = "lstBoxWrite";
            this.lstBoxWrite.Size = new System.Drawing.Size(200, 108);
            this.lstBoxWrite.TabIndex = 1;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(70, 202);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write to File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // lstBoxRead
            // 
            this.lstBoxRead.FormattingEnabled = true;
            this.lstBoxRead.Location = new System.Drawing.Point(303, 67);
            this.lstBoxRead.Name = "lstBoxRead";
            this.lstBoxRead.Size = new System.Drawing.Size(170, 95);
            this.lstBoxRead.TabIndex = 3;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(343, 202);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(93, 23);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Read from File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "txt";
            this.openFile.FileName = "Countries.txt";
            this.openFile.InitialDirectory = "C:\\Users\\10574447\\Documents\\Visual Studio 2015\\Projects\\AMReadWrite\\ReadWrite\\bin" +
    "\\Debug";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(194, 202);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(107, 23);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "Open a file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // writeReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 265);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lstBoxRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.lstBoxWrite);
            this.Controls.Add(this.lblTitleCountry);
            this.Name = "writeReadForm";
            this.Text = "Read and Write";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleCountry;
        private System.Windows.Forms.ListBox lstBoxWrite;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.ListBox lstBoxRead;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnOpenFile;
    }
}

