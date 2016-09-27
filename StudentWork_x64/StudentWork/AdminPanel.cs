using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }       
        private void AddBtn_Click(object sender, EventArgs e)
        {
            isEdit = false;
            new EditStudent { Owner = this }.ShowDialog();
        }
        public void Ref()
        {
            DBUtils.StudentDataSource();
            DBUtils.TeacherDataSource();
            lbStudents.DataSource = Students.Items.ToList();
            lbTeachers.DataSource = Teachers.Items.ToList();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = lbStudents.SelectedItem as Students;
            if (selectedItem == null) return;
            DBUtils.DeleteTable(selectedItem.Name, "students", DBUtils.Studentconn);
            DBUtils.DeleteTable(selectedItem.Name, "studentmark", DBUtils.Markconn);
            Ref();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            isEdit = true;
            new EditStudent { Owner = this }.ShowDialog();
        }
        public bool isEdit = false;
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            if (!File.Exists(DBUtils.DB[0]))
            {
                DBUtils.CreateNewDatabase(DBUtils.DB[0]);
            }
            //TODO: Run once :  DBUtils.CreateTable(DBUtils.QuerryStudent, DBUtils.StudentSqLiteConnection);
            //TODO: Run once :  DBUtils.CreateTable(DBUtils.QuerryTeachers, DBUtils.Teacherconn);
            
            DBUtils.StudentDataSource();
            DBUtils.TeacherDataSource();
            Ref();
        }

        private void editteacher_Click(object sender, EventArgs e)
        {
            isEdit = true;
            new EditTeacher { Owner = this }.ShowDialog();
        }

        private void delteacher_Click(object sender, EventArgs e)
        {
            var selectedItem = lbTeachers.SelectedItem as Teachers;
            if (selectedItem == null) return;
            DBUtils.DeleteTable(selectedItem.Name, "teacher", DBUtils.Teacherconn);
            Ref();
        }

        private void addteacher_Click(object sender, EventArgs e)
        {
            isEdit = false;
            new EditTeacher { Owner = this }.ShowDialog();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Process.Start("StudentWork.exe");
        }

        private void DropBase(string basename, SQLiteConnection s)
        {
            var result = MessageBox.Show(string.Format("Вы действительно хотите удалить базу '{0}'", basename),
                @"Подтверждение", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                DBUtils.Insert(string.Format("DELETE FROM '{0}'", basename), s);
                new Thread(() =>
                {
                    Thread.Sleep(1000);
                    Invoke((Action)(() => { MessageBox.Show(string.Format("База {0} успешно удалена!", basename)); Ref(); }));
                }).Start();
            }
        }

        private void delteach_Click(object sender, EventArgs e)
        {
            DropBase("teacher", DBUtils.Teacherconn);
        }
        private void delstudents_Click(object sender, EventArgs e)
        {
            DropBase("students", DBUtils.Studentconn);
            DropBase("studentmark", DBUtils.Markconn);
        }
    }
}
