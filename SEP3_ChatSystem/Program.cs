using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using SEP3_ChatSystem.Data;
using SEP3_ChatSystem.Mediator;

namespace SEP3_ChatSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ChatModelManager chatModelManager = new ChatModelManager();
            ServerConnector server = new ServerConnector(chatModelManager,3010,"127.0.0.1");
            server.Start();
        }
    }
}
