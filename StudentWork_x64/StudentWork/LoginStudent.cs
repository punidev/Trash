using System;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class LoginStudent : Form
    {
        public LoginStudent()
        {
            InitializeComponent();
        }
        private static string _login;
        private static string _passwd;
        private void button1_Click(object sender, EventArgs e)
        {
            _login = tbLogin.Text;
            _passwd = tbPasswd.Text;
            try
            {
                if (DBUtils.CheckLoginStudent(_login, _passwd))
                {
                    Visible = false;
                    new StudentForm
                    {
                        NameStudent = DBUtils.FindStudentName(_login, _passwd)
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
