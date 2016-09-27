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
    public partial class LoginTeacher : Form
    {
        public LoginTeacher()
        {
            InitializeComponent();
        }
        private static string _login;
        private static string _passwd;
        private void button1_Click_1(object sender, EventArgs e)
        {
            _login = tbLogin.Text;
            _passwd = tbPasswd.Text;
            try
            {
                if (DBUtils.CheckLoginTeacher(_login, _passwd))
                {
                    Visible = false;
                    new TeacherForm
                    {
                        TeacherName = DBUtils.FindTeacherName(_login, _passwd)
                    }.ShowDialog();
                    Close();
                }
                else MessageBox.Show(string.Format("Пользователь с логином {0} не найден!", tbLogin.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
