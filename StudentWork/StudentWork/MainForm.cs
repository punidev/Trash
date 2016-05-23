using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public bool isEdit = false;
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(DBUtils.Path))
            {
                DBUtils.CreateNewDatabase();
            }
            DBUtils.ConnectToDatabase();
           
            //TODO: Run once :  DBUtils.CreateTable();
            DBUtils.DataSource();
            Ref();
        }

        public void Ref()
        {
            DBUtils.DataSource();
            lbStudents.DataSource = Students.Items.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isEdit = false;
            new EditStudent{Owner = this}.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = lbStudents.SelectedItem as Students;
            if (selectedItem == null) return;
            DBUtils.DeleteTable(selectedItem.Name);
            Ref();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            isEdit = true;
            new EditStudent { Owner = this }.ShowDialog();
        }
    }
}
