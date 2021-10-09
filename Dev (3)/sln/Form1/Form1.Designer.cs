
namespace Form1
{
    partial class buttonBinary2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTextFile = new System.Windows.Forms.Button();
            this.buttonTextFile2 = new System.Windows.Forms.Button();
            this.buttonBinary1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBinary3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTextFile
            // 
            this.buttonTextFile.Location = new System.Drawing.Point(40, 41);
            this.buttonTextFile.Name = "buttonTextFile";
            this.buttonTextFile.Size = new System.Drawing.Size(211, 90);
            this.buttonTextFile.TabIndex = 0;
            this.buttonTextFile.Text = "TextFile1";
            this.buttonTextFile.UseVisualStyleBackColor = true;
            this.buttonTextFile.Click += new System.EventHandler(this.buttonTextFile_Click);
            // 
            // buttonTextFile2
            // 
            this.buttonTextFile2.Location = new System.Drawing.Point(40, 171);
            this.buttonTextFile2.Name = "buttonTextFile2";
            this.buttonTextFile2.Size = new System.Drawing.Size(211, 90);
            this.buttonTextFile2.TabIndex = 1;
            this.buttonTextFile2.Text = "TextFile2";
            this.buttonTextFile2.UseVisualStyleBackColor = true;
            this.buttonTextFile2.Click += new System.EventHandler(this.buttonTextFile2_Click);
            // 
            // buttonBinary1
            // 
            this.buttonBinary1.Location = new System.Drawing.Point(451, 41);
            this.buttonBinary1.Name = "buttonBinary1";
            this.buttonBinary1.Size = new System.Drawing.Size(211, 90);
            this.buttonBinary1.TabIndex = 2;
            this.buttonBinary1.Text = "Binary1";
            this.buttonBinary1.UseVisualStyleBackColor = true;
            this.buttonBinary1.Click += new System.EventHandler(this.buttonBinary1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "Binary2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBinary3
            // 
            this.buttonBinary3.Location = new System.Drawing.Point(451, 301);
            this.buttonBinary3.Name = "buttonBinary3";
            this.buttonBinary3.Size = new System.Drawing.Size(211, 90);
            this.buttonBinary3.TabIndex = 4;
            this.buttonBinary3.Text = "Binary3";
            this.buttonBinary3.UseVisualStyleBackColor = true;
            this.buttonBinary3.Click += new System.EventHandler(this.buttonBinary3_Click);
            // 
            // buttonBinary2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBinary3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBinary1);
            this.Controls.Add(this.buttonTextFile2);
            this.Controls.Add(this.buttonTextFile);
            this.Name = "buttonBinary2";
            this.Text = "Binary2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTextFile;
        private System.Windows.Forms.Button buttonTextFile2;
        private System.Windows.Forms.Button buttonBinary1;
        private System.Windows.Forms.Button buttonBinary3;
        private System.Windows.Forms.Button button2;
    }
}

