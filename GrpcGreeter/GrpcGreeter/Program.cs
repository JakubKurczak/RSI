using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcGreeter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine("Maciej Ry?");
            Console.WriteLine("Jakub Kurczak");
            CreateHostBuilder(args).Build().Run();
        }

        // Additional configuration is required to successfully run gRPC on macOS.
        // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
