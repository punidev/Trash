using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace server
{
    public class Server
    {
        private Connect connetions;
        private const int Port = 11000;
        
        private static void Main()
        {
            TcpListener server = null;
            try
            {
                var localAddr = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(localAddr, Port);
                server.Start();
                while (true)
                { 
                    Console.WriteLine("Ожидание подключений... ");
                    var client = server.AcceptTcpClient();
                    new Thread(new Connect().ClientServeThread).Start(client);
                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (server != null)
                    server.Stop();
            }
        }
        
       
    }
}