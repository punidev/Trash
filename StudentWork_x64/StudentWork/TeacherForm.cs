using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        public string TeacherName { get; set; }
        public bool isEdit = false;
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(DBUtils.DB[0]))
            {
                DBUtils.CreateNewDatabase(DBUtils.DB[0]);
            }
            label1.Text = string.Format("Вы вошли как: {0}", TeacherName);
            //TODO: Run once :  DBUtils.CreateTable(DBUtils.QuerryStudent,DBUtils.StudentSqLiteConnection);
            DBUtils.StudentDataSource();
            Ref();
        }

        public void Ref()
        {
            DBUtils.StudentDataSource();
            lbStudents.DataSource = Students.Items.ToList();
        }

        private void Infobtn_Click(object sender, EventArgs e)
        {
            new Marks{Owner=this}.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Process.Start("StudentWork.exe");
        }
    }
}
