namespace StudentWork
{
    partial class EditTeacher
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
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Addbtnt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPasswd
            // 
            this.tbPasswd.Location = new System.Drawing.Point(11, 80);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.Size = new System.Drawing.Size(274, 20);
            this.tbPasswd.TabIndex = 18;
            this.tbPasswd.Text = "пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(11, 54);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(274, 20);
            this.tbLogin.TabIndex = 17;
            this.tbLogin.Text = "Логин";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Addbtnt
            // 
            this.Addbtnt.Location = new System.Drawing.Point(11, 106);
            this.Addbtnt.Name = "Addbtnt";
            this.Addbtnt.Size = new System.Drawing.Size(136, 33);
            this.Addbtnt.TabIndex = 14;
            this.Addbtnt.Text = "Добавить";
            this.Addbtnt.UseVisualStyleBackColor = true;
            this.Addbtnt.Click += new System.EventHandler(this.Addbtnt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Значение";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(11, 28);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(274, 20);
            this.tName.TabIndex = 10;
            this.tName.Text = "Имя";
            // 
            // EditTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 155);
            this.Controls.Add(this.tbPasswd);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Addbtnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tName);
            this.Name = "EditTeacher";
            this.Text = "EditTeacher";
            this.Load += new System.EventHandler(this.EditTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPasswd;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Addbtnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tName;
    }
}