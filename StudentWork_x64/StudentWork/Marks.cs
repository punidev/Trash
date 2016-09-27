using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class Marks : Form
    {
        public Marks()
        {
            InitializeComponent();
        }
        private TeacherForm _parrent;
        private Students _client;

        public void UpdateTab(DataGridView data)
        {
            var ds = new DataSet();
            var sql = string.Format("Select * From 'studentmark' WHERE name = '{0}'", SniffingName);
            var connectionString = string.Format("Data Source={0};Version=3;", DBUtils.DB[1]);
            var conn = new SQLiteConnection(connectionString);
            var da = new SQLiteDataAdapter(sql, conn);
            da.Fill(ds);
            data.DataSource = ds.Tables[0].DefaultView;
        }
        private string SniffingName;
        private void Marks_Load(object sender, EventArgs e)
        {
            //TODO: RUN ONCE DBUtils.CreateTable(DBUtils.QuerryMarks,DBUtils.MarkSqLiteConnection);
            _parrent = (TeacherForm)Owner;
            _client = (Students)_parrent.lbStudents.SelectedItem;
            SniffingName = _client.Name;
            UpdateTab(dgvMarks);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
