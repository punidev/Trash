using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace tcp_client_server
{
    public class Client
    {
        private const int Port = 11000;
        private const string Server = "127.0.0.1";

        public static void Main()
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(Server, Port);

                var data = new byte[256];
                var response = new StringBuilder();
                var stream = client.GetStream();

                new Thread(SenderThead).Start(stream);

                do
                {
                    var bytes = stream.Read(data, 0, data.Length);
                    response = new StringBuilder(Encoding.UTF8.GetString(data, 0, bytes));
                    Console.WriteLine(response.ToString());
                    if (response.ToString() == "exit")
                    {
                        break;
                    }
                } while (true);

                stream.Close();
                client.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            Console.WriteLine("Запрос завершен...");
            Console.Read();
        }

        private static void SenderThead(object obj)
        {
            var stream = (NetworkStream) obj;
            var writer = new StreamWriter(stream)
            {
                AutoFlush = true
            };
            while (true)
            {
                
                var input = Console.ReadLine();
                writer.WriteLine(input);
                writer.Flush();
                if (input == "exit")
                {
                    stream.Close(); // можно сразу закрыть
                    return;
                }
            }
        }
    }
}