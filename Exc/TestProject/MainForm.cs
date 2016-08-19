using System;
using System.Windows.Forms;

namespace TestProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int[] mass = new int[10];
                // ---> 10
                for (int i = 0; i < 12; i++)
                // ---> 12
                {
                    mass[i] = 1;
                }
            }
            catch (Exception ex)
            {
                new UserException { Http = ex.GetType().Name }.ShowDialog();
            }
        }
    }
}
