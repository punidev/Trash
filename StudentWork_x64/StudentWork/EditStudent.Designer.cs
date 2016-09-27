namespace StudentWork
{
    partial class EditStudent
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
            this.tName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tGroup = new System.Windows.Forms.TextBox();
            this.tSpec = new System.Windows.Forms.TextBox();
            this.Addbtnt = new System.Windows.Forms.Button();
            this.tMark = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(12, 34);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(274, 20);
            this.tName.TabIndex = 0;
            this.tName.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Значение";
            // 
            // tGroup
            // 
            this.tGroup.Location = new System.Drawing.Point(12, 60);
            this.tGroup.Name = "tGroup";
            this.tGroup.Size = new System.Drawing.Size(274, 20);
            this.tGroup.TabIndex = 3;
            this.tGroup.Text = "группа";
            // 
            // tSpec
            // 
            this.tSpec.Location = new System.Drawing.Point(12, 86);
            this.tSpec.Name = "tSpec";
            this.tSpec.Size = new System.Drawing.Size(274, 20);
            this.tSpec.TabIndex = 4;
            this.tSpec.Text = "специальность";
            // 
            // Addbtnt
            // 
            this.Addbtnt.Location = new System.Drawing.Point(49, 196);
            this.Addbtnt.Name = "Addbtnt";
            this.Addbtnt.Size = new System.Drawing.Size(75, 23);
            this.Addbtnt.TabIndex = 5;
            this.Addbtnt.Text = "Добавть";
            this.Addbtnt.UseVisualStyleBackColor = true;
            this.Addbtnt.Click += new System.EventHandler(this.Addbtnt_Click);
            // 
            // tMark
            // 
            this.tMark.Location = new System.Drawing.Point(12, 112);
            this.tMark.Name = "tMark";
            this.tMark.Size = new System.Drawing.Size(274, 20);
            this.tMark.TabIndex = 6;
            this.tMark.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPasswd
            // 
            this.tbPasswd.Location = new System.Drawing.Point(12, 164);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.Size = new System.Drawing.Size(274, 20);
            this.tbPasswd.TabIndex = 9;
            this.tbPasswd.Text = "пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(12, 138);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(274, 20);
            this.tbLogin.TabIndex = 8;
            this.tbLogin.Text = "Логин";
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 231);
            this.Controls.Add(this.tbPasswd);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tMark);
            this.Controls.Add(this.Addbtnt);
            this.Controls.Add(this.tSpec);
            this.Controls.Add(this.tGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tName);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tGroup;
        private System.Windows.Forms.TextBox tSpec;
        private System.Windows.Forms.Button Addbtnt;
        private System.Windows.Forms.TextBox tMark;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPasswd;
        private System.Windows.Forms.TextBox tbLogin;
    }
}