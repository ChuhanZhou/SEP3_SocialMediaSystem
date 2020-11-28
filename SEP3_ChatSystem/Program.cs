using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SEP3_ChatSystem.Data;
using SEP3_ChatSystem.Mediator;
using SEP3_ChatSystem.Model.Unit.Message;

namespace SEP3_ChatSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //PrivateMessage a = new PrivateMessage("123","222","zwdzwdzwd");
            //Console.WriteLine(JsonSerializer.Serialize(a));
            
            ChatModelManager chatModelManager = new ChatModelManager();
            ServerConnector server = new ServerConnector(chatModelManager);
            server.Start();
            //CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
