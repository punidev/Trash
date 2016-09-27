using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWork
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult dResult;
            using (var frmLogining = new Welcome())
            {
                dResult = frmLogining.ShowDialog();
            }

            if (dResult == DialogResult.OK)
            {
                Application.Run(new TeacherForm());
            }
        }
    }
}
