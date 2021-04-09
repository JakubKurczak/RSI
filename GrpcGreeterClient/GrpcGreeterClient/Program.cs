using System;
using System.Net.Http;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
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

            var polynomialRequest = new PolynomialRequest();
            polynomialRequest.X = 3;
            polynomialRequest.BaseArray.Add(3);
            polynomialRequest.BaseArray.Add(2);
            using var channel = GrpcChannel.ForAddress("http://localhost:5001", new GrpcChannelOptions { HttpHandler = httpHandler });
            var client = new Greeter.GreeterClient(channel);
            var reply = client.CalculatePolynomial(polynomialRequest);
                            
            Console.WriteLine("Wynik to: " + reply.Result);
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }


}
//