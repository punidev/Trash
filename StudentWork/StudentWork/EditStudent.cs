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
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private MainForm parrent;
        private Students std;
        private void Addbtnt_Click(object sender, EventArgs e)
        {
            if (parrent.isEdit)
            {
                DBUtils.Insert("UPDATE students SET name = '" + tName.Text + "',gr='" + tGroup.Text + "',specialty='" + tSpec.Text + "', mark='" + tMark.Text + "' WHERE name ='" + std.Name + "'");
                parrent.Ref();
                Close();
            }
            else { 

            DBUtils.Insert("INSERT INTO students (name,gr,specialty,mark) VALUES ('" + tName.Text + "','" + tGroup.Text + "','" + tSpec.Text + "', '"+tMark.Text+"')");
            parrent.Ref();
            Close();}
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            parrent=(MainForm)Owner;
            if (parrent.isEdit)
            {
                Text = @"Изменить студента";
                Addbtnt.Text = @"Изменить";
                std = (Students)parrent.lbStudents.SelectedItem;
                tName.Text = std.Name;
                tGroup.Text = std.Group;
                tSpec.Text = std.Speciality;
                tMark.Text = std.Mark.ToString();
            }
            else { 
            Text = @"Добавить студента";
            Addbtnt.Text = @"Добавить";
        }}
    }
}
