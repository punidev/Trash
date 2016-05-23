using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class StudLog : Form
    {
        public StudLog()
        {
            InitializeComponent();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            label2.Text = DBUtils.CheckUser(tName.Text) ? "Студент найден" : "Студент не найден";
            int p = cbPart.SelectedIndex;
            if (DBUtils.CheckUser(tName.Text) && cbPart.SelectedIndex > 0)
            {
      
                DialogResult result;
                result = MessageBox.Show(string.Format("Хотите начать прохождения теста по {0} у вас на все есть 60 минут.",
                    rbOOP.Checked ? "ООП" : "АиСД"), 
                    @"Подтверджение начала теста",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Visible = false;
                    new Test { Subject = rbOOP.Checked ? "ООП" + p : "АиСД" + p, NameS = tName.Text }.ShowDialog();
                }

            }

        }

        private void StudLog_Load(object sender, EventArgs e)
        {
            DBUtils.ConnectToDatabase();
        }

        private void rbOOP_CheckedChanged(object sender, EventArgs e)
        {
            cbPart.Items.Clear();
            cbPart.Items.AddRange(new object[] {
            "1. Общие ведомости",
            "2. Основы програмирования на С++ 1ч.",
            "3. Операции и методы 1ч.",
            "4. Основы програмирования на С++ 2ч.",
            "5. Операции и методы 2ч."});
        }

        private void rbASD_CheckedChanged(object sender, EventArgs e)
        {
            cbPart.Items.Clear();
            cbPart.Items.AddRange(new object[] {
            "1. Общие ведомости123",
            "2. Основы програмирования на С++ 1ч123.",
            "3. Операции и методы 1ч.",
            "4. Основы програмирования на С++ 2ч.",
            "5. Операции и методы 2ч."});
        }
    }
}
