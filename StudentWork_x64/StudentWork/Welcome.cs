using System;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            DBUtils.ConnectToDatabase(DBUtils.Studentconn);
            DBUtils.ConnectToDatabase(DBUtils.Markconn);
            DBUtils.ConnectToDatabase(DBUtils.Teacherconn);
        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            Visible = false;
            DialogResult r;
            using (var f = new LoginTeacher()) r = f.ShowDialog();
            if (r == DialogResult.OK) new TeacherForm().ShowDialog();
            Close();
        }

        private void stud_Click(object sender, EventArgs e)
        {
            Visible = false;
            DialogResult r;
            using (var f = new LoginStudent()) r = f.ShowDialog();
            if (r == DialogResult.OK) new StudentForm().ShowDialog();
            Close();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            DialogResult r;
            using (var f = new LoginAdmin()) r = f.ShowDialog();
            if (r == DialogResult.OK) new AdminPanel().ShowDialog();
            Close();
        }
    }
}
