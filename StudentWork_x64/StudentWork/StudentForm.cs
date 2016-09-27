using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        public string NameStudent { get; set; }

        private void accept_Click(object sender, EventArgs e)
        {
            var p = cbPart.SelectedIndex;
            if (p < 0) return;
            var result = MessageBox.Show(string.Format("Хотите начать прохождения теста по {0} у вас на все есть 10 минут.",
                rbOOP.Checked ? "ООП" : "АиСД"),
                @"Подтверджение начала теста",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes) return;
            Visible = false;
            new Test
            {
                Subject = rbOOP.Checked ? "ООП" + (p + 1) : "АиСД" + (p + 1),
                NameS = NameStudent,
                Partof = p,
                IsOop = rbOOP.Checked
            }.ShowDialog();
        }

        private void StudLog_Load(object sender, EventArgs e)
        {
            label2.Text = NameStudent;
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.White;
            AsdFill();
            OopFill();
        }

        private void OopFill()
        {
            cbPart.Items.AddRange(Students.OopObjects);
        }
        private void AsdFill()
        {
            cbPart.Items.AddRange(Students.AsdObjects);
        }

        private void rbOOP_CheckedChanged(object sender, EventArgs e)
        {
            cbPart.Items.Clear();
            OopFill();
        }

        private void rbASD_CheckedChanged(object sender, EventArgs e)
        {
            cbPart.Items.Clear();
            AsdFill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Process.Start("StudentWork.exe");
        }

        
    }
}
