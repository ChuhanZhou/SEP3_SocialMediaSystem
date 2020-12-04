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
        private string host;
        private int port;

        public ServerConnector(IChatModel chatModel,int port = 3010,string host = "127.0.0.1")
        {
            this.chatModel = chatModel;
            this.port = port;
            this.host = host;
        }

        public void Start()
        {
            Console.WriteLine("Starting ChatSystem server...");
            
            IPAddress ip = IPAddress.Parse(host);
            TcpListener listener = new TcpListener(ip, port);
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