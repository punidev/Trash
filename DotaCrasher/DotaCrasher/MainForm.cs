using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace DotaCrasher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public DateTime Date;
        public static DateTime GetNetworkTime()
        {
            const string ntpServer = "ntp5.stratum1.ru";
            var ntpData = new byte[48];
            ntpData[0] = 0x1B; 
            var addresses = Dns.GetHostEntry(ntpServer).AddressList;
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                socket.Connect(ipEndPoint);
                socket.ReceiveTimeout = 3000;
                socket.Send(ntpData);
                socket.Receive(ntpData);
            }
            const byte serverReplyTime = 40;
            ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);
            ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);
            intPart = Swaptime(intPart);
            fractPart = Swaptime(fractPart);
            var milliseconds = intPart * 1000 + fractPart * 1000 / 0x100000000L;
            var networkDateTime = new DateTime(1900, 1, 1, 0, 0, 0).AddMilliseconds((long)milliseconds);
            return networkDateTime.ToLocalTime();
        }

        public static uint Swaptime(ulong x)
        {
            return (uint)( ((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }
        private void exec_Click(object sender, EventArgs e)
        {
            var time = new int [6] ;
            if (pkill.Checked)
            {
                time[0] = Convert.ToInt32(tYear.Text);
                time[1] = Convert.ToInt32(tMonth.Text);
                time[2] = Convert.ToInt32(tDay.Text);
                time[3] = Convert.ToInt32(tHour.Text);
                time[4] = Convert.ToInt32(tMin.Text);
                time[5] = Convert.ToInt32(tSec.Text);
                var date1 = new DateTime(time[0], time[1], time[2], time[3], time[4], time[5]);
                Date = date1;
                tbTimenow.Text = date1.ToString(CultureInfo.InvariantCulture);
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                tbTimenow.Text = @"Выберите метод!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            now.Text = GetNetworkTime().ToString(CultureInfo.InvariantCulture);
            var d = GetNetworkTime().ToString(CultureInfo.InvariantCulture);
            if (d.CompareTo(Date) == 1)
            {
                timer1.Stop();
                timer1.Enabled = false;
                var proc = Process.GetProcesses();
                foreach (var process in proc.Where(process => process.ProcessName == "dota2"))
                    process.Kill();
            }
        }

        private void SetDate(DateTime date)
        {
            var d = date;
            tYear.Text = d.Year.ToString();
            tMonth.Text = d.Month.ToString();
            tDay.Text = d.Day.ToString();
            tHour.Text = d.Hour.ToString();
            tMin.Text = d.Minute.ToString();
            tSec.Text = d.Second.ToString();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            SetDate(DateTime.Now);
        }

       
        private void timer2_Tick(object sender, EventArgs e)
        {
            now.Text = GetNetworkTime().ToString(CultureInfo.InvariantCulture);
            if (Process.GetProcessesByName("dota2").Length != 0)
            {
                label1.ForeColor = Color.DarkGreen;
                label1.Text = @"Процесс Dota2 : запущен";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = @"Процесс Dota2 : не запущен";
            }

        }
        private void startgame_Click(object sender, EventArgs e)
        {
            Process.Start("steam://rungameid/570");
        }
    }
}
