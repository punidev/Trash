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
    public partial class EditTeacher : Form
    {
        public EditTeacher()
        {
            InitializeComponent();
        }
        private AdminPanel parrent;
        private Teachers std;
        private void Addbtnt_Click(object sender, EventArgs e)
        {
            if (parrent.isEdit)
            {
                DBUtils.Insert(string.Format("UPDATE teacher SET name = '{0}', login = '{1}',passwd = '{2}' WHERE name ='{0}'",tName.Text, tbLogin.Text, tbPasswd.Text), DBUtils.Teacherconn);
                parrent.Ref();
                Close();
            }
            else
            {
                DBUtils.Insert(string.Format("INSERT INTO teacher (name,login,passwd) VALUES ('{0}','{1}','{2}')", tName.Text, tbLogin.Text, tbPasswd.Text), DBUtils.Teacherconn);
                parrent.Ref();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditTeacher_Load(object sender, EventArgs e)
        {
            parrent=(AdminPanel)Owner;
            if (parrent.isEdit)
            {
                Text = @"Изменить преподавателя";
                Addbtnt.Text = @"Изменить";
                std = (Teachers)parrent.lbTeachers.SelectedItem;
                tName.Text = std.Name;
                tbLogin.Text = std.Login;
                tbPasswd.Text = std.Password;
            }
            else {
                Text = @"Добавить преподавателя";
            Addbtnt.Text = @"Добавить";
        }
        }
    }
}
