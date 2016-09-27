namespace StudentWork
{
    partial class AdminPanel
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
            this.DelBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.lbTeachers = new System.Windows.Forms.ListBox();
            this.editteacher = new System.Windows.Forms.Button();
            this.delteacher = new System.Windows.Forms.Button();
            this.addteacher = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.delteach = new System.Windows.Forms.Button();
            this.delstudents = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(272, 317);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(130, 39);
            this.DelBtn.TabIndex = 7;
            this.DelBtn.Text = "Изменить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(142, 317);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(130, 39);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "Удалить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // lbStudents
            // 
            this.lbStudents.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 16;
            this.lbStudents.Location = new System.Drawing.Point(12, 19);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(390, 292);
            this.lbStudents.TabIndex = 5;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 317);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(130, 39);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // lbTeachers
            // 
            this.lbTeachers.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTeachers.FormattingEnabled = true;
            this.lbTeachers.ItemHeight = 16;
            this.lbTeachers.Location = new System.Drawing.Point(12, 19);
            this.lbTeachers.Name = "lbTeachers";
            this.lbTeachers.Size = new System.Drawing.Size(360, 292);
            this.lbTeachers.TabIndex = 8;
            // 
            // editteacher
            // 
            this.editteacher.Location = new System.Drawing.Point(252, 317);
            this.editteacher.Name = "editteacher";
            this.editteacher.Size = new System.Drawing.Size(120, 39);
            this.editteacher.TabIndex = 11;
            this.editteacher.Text = "Изменить";
            this.editteacher.UseVisualStyleBackColor = true;
            this.editteacher.Click += new System.EventHandler(this.editteacher_Click);
            // 
            // delteacher
            // 
            this.delteacher.Location = new System.Drawing.Point(132, 317);
            this.delteacher.Name = "delteacher";
            this.delteacher.Size = new System.Drawing.Size(120, 39);
            this.delteacher.TabIndex = 10;
            this.delteacher.Text = "Удалить";
            this.delteacher.UseVisualStyleBackColor = true;
            this.delteacher.Click += new System.EventHandler(this.delteacher_Click);
            // 
            // addteacher
            // 
            this.addteacher.Location = new System.Drawing.Point(12, 317);
            this.addteacher.Name = "addteacher";
            this.addteacher.Size = new System.Drawing.Size(120, 39);
            this.addteacher.TabIndex = 9;
            this.addteacher.Text = "Добавить";
            this.addteacher.UseVisualStyleBackColor = true;
            this.addteacher.Click += new System.EventHandler(this.addteacher_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DelBtn);
            this.groupBox1.Controls.Add(this.EditBtn);
            this.groupBox1.Controls.Add(this.lbStudents);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 366);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Студенты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.editteacher);
            this.groupBox2.Controls.Add(this.delteacher);
            this.groupBox2.Controls.Add(this.addteacher);
            this.groupBox2.Controls.Add(this.lbTeachers);
            this.groupBox2.Location = new System.Drawing.Point(431, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 366);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Преподаватели";
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(709, 414);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(106, 34);
            this.exitbtn.TabIndex = 14;
            this.exitbtn.Text = "Назад";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // delteach
            // 
            this.delteach.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delteach.Location = new System.Drawing.Point(148, 409);
            this.delteach.Name = "delteach";
            this.delteach.Size = new System.Drawing.Size(130, 44);
            this.delteach.TabIndex = 17;
            this.delteach.Text = "Очистить базу преподавателей";
            this.delteach.UseVisualStyleBackColor = true;
            this.delteach.Click += new System.EventHandler(this.delteach_Click);
            // 
            // delstudents
            // 
            this.delstudents.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delstudents.Location = new System.Drawing.Point(12, 409);
            this.delstudents.Name = "delstudents";
            this.delstudents.Size = new System.Drawing.Size(130, 44);
            this.delstudents.TabIndex = 15;
            this.delstudents.Text = "Очистить базу студентов";
            this.delstudents.UseVisualStyleBackColor = true;
            this.delstudents.Click += new System.EventHandler(this.delstudents_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 460);
            this.Controls.Add(this.delteach);
            this.Controls.Add(this.delstudents);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button EditBtn;
        public System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button AddBtn;
        public System.Windows.Forms.ListBox lbTeachers;
        private System.Windows.Forms.Button editteacher;
        private System.Windows.Forms.Button delteacher;
        private System.Windows.Forms.Button addteacher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button delteach;
        private System.Windows.Forms.Button delstudents;
    }
}