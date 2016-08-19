using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestProject
{
    public partial class UserException : Form
    {
        public UserException()
        {
            InitializeComponent();
        }

        public string Http { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            var screenSize = Screen.PrimaryScreen.Bounds.Size;
            this.Width = screenSize.Width;
            this.Height = screenSize.Height;
            Location = new Point(0,0);
            Text = Http;
            webBrowser1.Navigate("https://www.google.com.ua/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=" + Http);
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
