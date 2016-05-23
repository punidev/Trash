namespace StudentWork
{
    partial class StudLog
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbOOP = new System.Windows.Forms.RadioButton();
            this.rbASD = new System.Windows.Forms.RadioButton();
            this.tName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accept = new System.Windows.Forms.Button();
            this.cbPart = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать в систему оценки\r\nкачества знаний студентов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbOOP
            // 
            this.rbOOP.AutoSize = true;
            this.rbOOP.Location = new System.Drawing.Point(68, 93);
            this.rbOOP.Name = "rbOOP";
            this.rbOOP.Size = new System.Drawing.Size(49, 17);
            this.rbOOP.TabIndex = 2;
            this.rbOOP.TabStop = true;
            this.rbOOP.Text = "ООП";
            this.rbOOP.UseVisualStyleBackColor = true;
            this.rbOOP.CheckedChanged += new System.EventHandler(this.rbOOP_CheckedChanged);
            // 
            // rbASD
            // 
            this.rbASD.AutoSize = true;
            this.rbASD.Location = new System.Drawing.Point(394, 93);
            this.rbASD.Name = "rbASD";
            this.rbASD.Size = new System.Drawing.Size(54, 17);
            this.rbASD.TabIndex = 3;
            this.rbASD.TabStop = true;
            this.rbASD.Text = "АиСД";
            this.rbASD.UseVisualStyleBackColor = true;
            this.rbASD.CheckedChanged += new System.EventHandler(this.rbASD_CheckedChanged);
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(68, 154);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(380, 20);
            this.tName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(153, 191);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(175, 34);
            this.accept.TabIndex = 6;
            this.accept.Text = "Подтвердить";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // cbPart
            // 
            this.cbPart.FormattingEnabled = true;
            this.cbPart.Location = new System.Drawing.Point(68, 127);
            this.cbPart.Name = "cbPart";
            this.cbPart.Size = new System.Drawing.Size(380, 21);
            this.cbPart.TabIndex = 7;
            this.cbPart.Text = "Выберите главу";
            // 
            // StudLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 374);
            this.Controls.Add(this.cbPart);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.rbASD);
            this.Controls.Add(this.rbOOP);
            this.Controls.Add(this.label1);
            this.Name = "StudLog";
            this.Text = "StudLog";
            this.Load += new System.EventHandler(this.StudLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbOOP;
        private System.Windows.Forms.RadioButton rbASD;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.ComboBox cbPart;

    }
}