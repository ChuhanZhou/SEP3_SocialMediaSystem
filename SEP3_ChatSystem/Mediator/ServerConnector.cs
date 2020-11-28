using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SEP3_ChatSystem.Data;

namespace SEP3_ChatSystem.Mediator
{
    public class ServerConnector
    {
        private IChatModel chatModel;
        private string HOST = "localhost";
        private int PORT = 3010;

        public ServerConnector(IChatModel chatModel)
        {
            this.chatModel = chatModel;
        }

        public void Start()
        {
            Console.WriteLine("Starting ChatSystem server...");
            
            IPAddress ip = IPAddress.Parse(HOST);
            TcpListener listener = new TcpListener(ip, PORT);
            listener.Start();

            Console.WriteLine("Server started...");

            while (true)
            {
                Console.WriteLine("Wait for a client...");
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Connect to a client...");
                new Thread(()=>new ServerHandler(chatModel,client)).Start();
            }
        }
    }
}