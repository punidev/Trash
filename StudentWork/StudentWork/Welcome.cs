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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            Visible = false;
            new MainForm().ShowDialog();
            Close();
        }

        private void stud_Click(object sender, EventArgs e)
        {
            Visible = false;
            new StudLog().ShowDialog();
            Close();
        }
    }
}
