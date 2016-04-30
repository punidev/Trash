using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace server
{
    class Connect
    {
        public string Name { set; get; }
        private static string _response;
        public static List<NetworkStream> List = new List<NetworkStream>();
        public void ClientServeThread(object obj)
        {
            var client = (TcpClient)obj;
            Console.WriteLine("Подключен клиент. Выполнение запроса...");
            NetworkStream stream = client.GetStream();
            List.Add(stream);
            var reader = new StreamReader(stream);
            var writer = new StreamWriter(stream);
            
           
            while (true)
            {
                _response = reader.ReadLine();
                string nick = Regex.Match(_response, "/name (\\S+)", RegexOptions.Singleline).Groups[1].Value;
                if (_response.StartsWith("/name"))
                {
                    Name = nick;
                }
                if (_response != null)
                {
                    Allreply(List, _response, Name);
                }
                Console.WriteLine("{1} : {0}", _response, Name);
                if (_response == "exit")
                {
                    writer.WriteLine("exit");
                    writer.Flush();
                    break;
                }
            }
            client.Close();
        }

        private static void Allreply(IEnumerable<NetworkStream> list, string res, string Namen)
        {
            foreach (NetworkStream t in list)
            {
                var writer = new StreamWriter(t) { AutoFlush = true };
                writer.WriteLine(Namen + " says " + res);
                writer.Flush();
            }
        }
    }
}
