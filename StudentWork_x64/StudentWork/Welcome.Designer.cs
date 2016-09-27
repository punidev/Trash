namespace StudentWork
{
    partial class Welcome
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
            this.Teacher = new System.Windows.Forms.Button();
            this.stud = new System.Windows.Forms.Button();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(97, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в систему оценки\r\nкачества знаний студентов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Teacher
            // 
            this.Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Teacher.Location = new System.Drawing.Point(124, 125);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(345, 61);
            this.Teacher.TabIndex = 1;
            this.Teacher.Text = "Преподаватель";
            this.Teacher.UseVisualStyleBackColor = true;
            this.Teacher.Click += new System.EventHandler(this.Teacher_Click);
            // 
            // stud
            // 
            this.stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stud.Location = new System.Drawing.Point(124, 192);
            this.stud.Name = "stud";
            this.stud.Size = new System.Drawing.Size(345, 61);
            this.stud.TabIndex = 2;
            this.stud.Text = "Студент";
            this.stud.UseVisualStyleBackColor = true;
            this.stud.Click += new System.EventHandler(this.stud_Click);
            // 
            // AdminBtn
            // 
            this.AdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminBtn.Location = new System.Drawing.Point(124, 259);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(345, 61);
            this.AdminBtn.TabIndex = 3;
            this.AdminBtn.Text = "Администратор";
            this.AdminBtn.UseVisualStyleBackColor = true;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 382);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.stud);
            this.Controls.Add(this.Teacher);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Teacher;
        private System.Windows.Forms.Button stud;
        private System.Windows.Forms.Button AdminBtn;
    }
}