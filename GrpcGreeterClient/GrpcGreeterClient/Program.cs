﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //the port number(5001) must match the port of the grpc server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "greeterclient" });
            Console.WriteLine("greeting: " + reply.Message);
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}