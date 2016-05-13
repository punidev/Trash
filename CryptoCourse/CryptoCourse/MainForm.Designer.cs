namespace CryptoCourse
{
    partial class MainForm
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
            this.select2 = new System.Windows.Forms.Button();
            this.select1 = new System.Windows.Forms.Button();
            this.endfile = new System.Windows.Forms.TextBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.sourcefile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // select2
            // 
            this.select2.Location = new System.Drawing.Point(259, 53);
            this.select2.Name = "select2";
            this.select2.Size = new System.Drawing.Size(75, 23);
            this.select2.TabIndex = 8;
            this.select2.Text = "Выбрать";
            this.select2.UseVisualStyleBackColor = true;
            this.select2.Click += new System.EventHandler(this.select2_Click);
            // 
            // select1
            // 
            this.select1.Location = new System.Drawing.Point(259, 12);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(75, 23);
            this.select1.TabIndex = 9;
            this.select1.Text = "Выбрать";
            this.select1.UseVisualStyleBackColor = true;
            this.select1.Click += new System.EventHandler(this.select1_Click);
            // 
            // endfile
            // 
            this.endfile.Location = new System.Drawing.Point(16, 56);
            this.endfile.Name = "endfile";
            this.endfile.Size = new System.Drawing.Size(221, 20);
            this.endfile.TabIndex = 7;
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(340, 52);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(97, 24);
            this.decryptBtn.TabIndex = 5;
            this.decryptBtn.Text = "Расшифровать";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(340, 12);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(97, 23);
            this.encryptBtn.TabIndex = 6;
            this.encryptBtn.Text = "Шифровать";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // sourcefile
            // 
            this.sourcefile.Location = new System.Drawing.Point(16, 12);
            this.sourcefile.Name = "sourcefile";
            this.sourcefile.Size = new System.Drawing.Size(221, 20);
            this.sourcefile.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 94);
            this.Controls.Add(this.select2);
            this.Controls.Add(this.select1);
            this.Controls.Add(this.endfile);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.sourcefile);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select2;
        private System.Windows.Forms.Button select1;
        private System.Windows.Forms.TextBox endfile;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.TextBox sourcefile;

    }
}

