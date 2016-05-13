using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CryptoCourse
{
    public partial class MainForm : Form
    {
        readonly OpenFileDialog _openfile = new OpenFileDialog();
        public SaveFileDialog SaveEncrypt = new SaveFileDialog();
        public string _ext1;
        public string _ext2;
        private string _fNameEnc, _fNameDec, _fNameobj;
        private static string _fPath;
        public MainForm()
        {
            InitializeComponent();
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            var dest = Path.Combine(Application.StartupPath, "keys",
                Path.GetFileNameWithoutExtension(endfile.Text));

            using (var fs = File.Open(dest, FileMode.Open, FileAccess.Read))
            using (var aes = new AesCryptoServiceProvider())
            {
                byte[] buff0 = new byte[aes.KeySize / 8],
                       buff1 = new byte[16];
                
                var info = Regex.Match(Path.GetFileName(endfile.Text), ".(.*?)?.crypt", RegexOptions.Singleline).Groups[1].Value;
                var filename = Regex.Match(Path.GetFileNameWithoutExtension(endfile.Text), "(.*?)?" + info, RegexOptions.Singleline).Groups[1].Value;
                fs.Read(buff0, 0, buff0.Length);
                fs.Read(buff1, 0, buff1.Length);
                Crypto.DecryptFile(Path.GetDirectoryName(endfile.Text), endfile.Text,
                    filename + info,
                    aes, buff0, buff1);
            }
        }

        private void select1_Click(object sender, EventArgs e)
        {
            if (_openfile.ShowDialog() != DialogResult.OK) return;
            sourcefile.Text = _openfile.FileName;
            _ext1 = Path.GetExtension(sourcefile.Text);
        }

        private void select2_Click(object sender, EventArgs e)
        {
            if (_openfile.ShowDialog() != DialogResult.OK) return;
            endfile.Text = _openfile.FileName;
            _ext2 = Path.GetExtension(endfile.Text);
            _fNameDec = Path.GetFileNameWithoutExtension(_openfile.FileName);
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            var dest = Path.Combine(Application.StartupPath, "keys");
            Directory.CreateDirectory(dest);
            dest = Path.Combine(dest, Path.GetFileName(sourcefile.Text));
            using (var fs = File.Open(dest, FileMode.Create, FileAccess.Write))
            using (var aes = new AesCryptoServiceProvider())
            {
                var rnd = RandomNumberGenerator.Create();
                byte[] buff0 = new byte[aes.KeySize / 8],
                       buff1 = new byte[16];

                rnd.GetNonZeroBytes(buff0);
                rnd.GetNonZeroBytes(buff1);

                fs.Write(buff0, 0, buff0.Length);
                fs.Write(buff1, 0, buff1.Length);

                Crypto.CryptFile(sourcefile.Text, sourcefile.Text, aes, buff0, buff1);
            }
        }
  
    }
}
