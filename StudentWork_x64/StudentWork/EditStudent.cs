using System;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private AdminPanel parrent;
        private Students std;
        private void Addbtnt_Click(object sender, EventArgs e)
        {
            if (parrent.isEdit)
            {
                DBUtils.Insert(string.Format(@"UPDATE students SET
                    login = '{0}',
                    passwd = '{1}',
                    name = '{2}',
                    gr = '{3}',
                    specialty = '{4}',
                    mark = '{5}'
                    WHERE name = '{6}'",
                tbLogin.Text, tbPasswd.Text,
                tName.Text, tGroup.Text,
                tSpec.Text, tMark.Text, std.Name),DBUtils.Studentconn);
                parrent.Ref();
                Close();
            }
            else
            {
                DBUtils.Insert(string.Format("INSERT INTO students (login,passwd,name,gr,specialty,mark) VALUES ('{0}','{1}','{2}','{3}','{4}', '{5}')",
                                   tbLogin.Text, tbPasswd.Text, tName.Text, tGroup.Text, tSpec.Text, tMark.Text), DBUtils.Studentconn);
                for (var i = 0; i < Students.OopObjects.Length; i++)
                {
                    DBUtils.Insert(string.Format("INSERT INTO studentmark (name,subject, part, mark) VALUES ('{0}','ООП','{1}','0')",
                                       tName.Text, Students.OopObjects[i]), DBUtils.Markconn);
                }
                for (var j = 0; j < Students.OopObjects.Length; j++)
                {
                    DBUtils.Insert(string.Format("INSERT INTO studentmark (name,subject, part, mark) VALUES ('{0}','АиСД','{1}','0')",
                                       tName.Text,Students.AsdObjects[j]), DBUtils.Markconn);
                }
                parrent.Ref();
                Close();
            }
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
       
            parrent=(AdminPanel)Owner;
            if (parrent.isEdit)
            {
                Text = @"Изменить студента";
                Addbtnt.Text = @"Изменить";
                std = (Students)parrent.lbStudents.SelectedItem;
                tName.Text = std.Name;
                tGroup.Text = std.Group;
                tSpec.Text = std.Speciality;
                tbLogin.Text = std.Login;
                tbPasswd.Text = std.Password;
            }
            else { 
            Text = @"Добавить студента";
            Addbtnt.Text = @"Добавить";
        }}

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
