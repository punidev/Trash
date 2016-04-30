namespace DotaCrasher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.exec = new System.Windows.Forms.Button();
            this.tYear = new System.Windows.Forms.TextBox();
            this.tbTimenow = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tMonth = new System.Windows.Forms.TextBox();
            this.tDay = new System.Windows.Forms.TextBox();
            this.tHour = new System.Windows.Forms.TextBox();
            this.tMin = new System.Windows.Forms.TextBox();
            this.tSec = new System.Windows.Forms.TextBox();
            this.now = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pkill = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.startgame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exec
            // 
            this.exec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exec.BackgroundImage")));
            this.exec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.exec.FlatAppearance.BorderSize = 0;
            this.exec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.exec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.exec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exec.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exec.Location = new System.Drawing.Point(113, 187);
            this.exec.Name = "exec";
            this.exec.Size = new System.Drawing.Size(118, 34);
            this.exec.TabIndex = 0;
            this.exec.Text = "Активация";
            this.exec.UseVisualStyleBackColor = true;
            this.exec.Click += new System.EventHandler(this.exec_Click);
            // 
            // tYear
            // 
            this.tYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.tYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tYear.ForeColor = System.Drawing.SystemColors.Info;
            this.tYear.Location = new System.Drawing.Point(34, 107);
            this.tYear.Name = "tYear";
            this.tYear.Size = new System.Drawing.Size(71, 20);
            this.tYear.TabIndex = 1;
            // 
            // tbTimenow
            // 
            this.tbTimenow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.tbTimenow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTimenow.ForeColor = System.Drawing.SystemColors.Info;
            this.tbTimenow.Location = new System.Drawing.Point(34, 133);
            this.tbTimenow.Name = "tbTimenow";
            this.tbTimenow.Size = new System.Drawing.Size(413, 20);
            this.tbTimenow.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tMonth
            // 
            this.tMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.tMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tMonth.ForeColor = System.Drawing.SystemColors.Info;
            this.tMonth.Location = new System.Drawing.Point(111, 107);
            this.tMonth.Name = "tMonth";
            this.tMonth.Size = new System.Drawing.Size(41, 20);
            this.tMonth.TabIndex = 3;
            // 
            // tDay
            // 
            this.tDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.tDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tDay.ForeColor = System.Drawing.SystemColors.Info;
            this.tDay.Location = new System.Drawing.Point(158, 107);
            this.tDay.Name = "tDay";
            this.tDay.Size = new System.Drawing.Size(45, 20);
            this.tDay.TabIndex = 4;
            // 
            // tHour
            // 
            this.tHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.tHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tHour.ForeColor = System.Drawing.SystemColors.Info;
            this.tHour.Location = new System.Drawing.Point(222, 107);
            this.tHour.Name = "tHour";
            this.tHour.Size = new System.Drawing.Size(71, 20);
            this.tHour.TabIndex = 5;
            // 
            // tMin
            // 
            this.tMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.tMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tMin.ForeColor = System.Drawing.SystemColors.Info;
            this.tMin.Location = new System.Drawing.Point(299, 107);
            this.tMin.Name = "tMin";
            this.tMin.Size = new System.Drawing.Size(71, 20);
            this.tMin.TabIndex = 6;
            // 
            // tSec
            // 
            this.tSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.tSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSec.ForeColor = System.Drawing.SystemColors.Info;
            this.tSec.Location = new System.Drawing.Point(376, 107);
            this.tSec.Name = "tSec";
            this.tSec.Size = new System.Drawing.Size(71, 20);
            this.tSec.TabIndex = 7;
            // 
            // now
            // 
            this.now.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.now.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.now.ForeColor = System.Drawing.SystemColors.Info;
            this.now.Location = new System.Drawing.Point(34, 29);
            this.now.Name = "now";
            this.now.Size = new System.Drawing.Size(413, 20);
            this.now.TabIndex = 8;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pkill
            // 
            this.pkill.AutoSize = true;
            this.pkill.BackColor = System.Drawing.Color.Transparent;
            this.pkill.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pkill.ForeColor = System.Drawing.Color.White;
            this.pkill.Location = new System.Drawing.Point(32, 159);
            this.pkill.Name = "pkill";
            this.pkill.Size = new System.Drawing.Size(103, 22);
            this.pkill.TabIndex = 9;
            this.pkill.TabStop = true;
            this.pkill.Text = "Process Killer";
            this.pkill.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Текущее время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Год";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(110, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Месяц";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(158, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "День";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(219, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Час";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(296, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Минута";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(373, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Секунда";
            // 
            // startgame
            // 
            this.startgame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startgame.BackgroundImage")));
            this.startgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startgame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.startgame.FlatAppearance.BorderSize = 0;
            this.startgame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.startgame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.startgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startgame.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startgame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startgame.Location = new System.Drawing.Point(237, 187);
            this.startgame.Name = "startgame";
            this.startgame.Size = new System.Drawing.Size(118, 34);
            this.startgame.TabIndex = 19;
            this.startgame.Text = "Запустить";
            this.startgame.UseVisualStyleBackColor = true;
            this.startgame.Click += new System.EventHandler(this.startgame_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 230);
            this.Controls.Add(this.startgame);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pkill);
            this.Controls.Add(this.now);
            this.Controls.Add(this.tSec);
            this.Controls.Add(this.tMin);
            this.Controls.Add(this.tHour);
            this.Controls.Add(this.tDay);
            this.Controls.Add(this.tMonth);
            this.Controls.Add(this.tbTimenow);
            this.Controls.Add(this.tYear);
            this.Controls.Add(this.exec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Dota Crasher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exec;
        private System.Windows.Forms.TextBox tYear;
        private System.Windows.Forms.TextBox tbTimenow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tMonth;
        private System.Windows.Forms.TextBox tDay;
        private System.Windows.Forms.TextBox tHour;
        private System.Windows.Forms.TextBox tMin;
        private System.Windows.Forms.TextBox tSec;
        private System.Windows.Forms.TextBox now;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton pkill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button startgame;
    }
}

