using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Używamy frameworka .net 5.0
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine("Maciej Ryś");
            Console.WriteLine("Jakub Kurczak");
            var httpHandler = new HttpClientHandler();
            // Return true to allow certificates that are untrusted/invalid
            httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;


            using var channel = GrpcChannel.ForAddress("https://25.28.162.104:5001", new GrpcChannelOptions { HttpHandler = httpHandler });
            //the port number(5001) must match the port of the grpc server.
            //using var channel = GrpcChannel.ForAddress("https://25.28.162.104:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "greeterclient" });
            Console.WriteLine("greeting: " + reply.Message);
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}