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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
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
                if (_login == "root" ||
                    _passwd == "adminpwd")
                {
                    Visible = false;
                    new AdminPanel().ShowDialog();
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
