using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Uri baseAddress = new Uri("http://localhost:10001/Service1");

            ServiceHost mojHost = new ServiceHost(typeof(MojKalkulator), baseAddress);

            WSHttpBinding mojBanding = new WSHttpBinding();
            ServiceEndpoint endpoint1 = mojHost.AddServiceEndpoint(typeof(IKalkulator), mojBanding, "endpoint_1");

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();

            smb.HttpGetEnabled = true;
            mojHost.Description.Behaviors.Add(smb);

            BasicHttpBinding basicHttpBinding2 = new BasicHttpBinding();
            ServiceEndpoint endpoint2 = mojHost.AddServiceEndpoint(typeof(IKalkulator), basicHttpBinding2, "endpoint_2");

            ServiceEndpoint endpoint3 = mojHost.Description.Endpoints.Find(new Uri("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Service1/mex/endpoint3"));

            try
            {
                mojHost.Open();
                Console.WriteLine("Serwis uruchomiony.");
                Console.WriteLine("Nacisnij Enter aby zakonczyc");
                Console.WriteLine();

                Console.WriteLine("\n---> Endpointy:");
                Console.WriteLine("\nService endpoint {0}: ", endpoint1.Name);
                Console.WriteLine("Binding: {0}", endpoint1.Binding.ToString());
                Console.WriteLine("ListenUri: {0}", endpoint1.ListenUri.ToString());

                Console.WriteLine("\n---> Endpointy:");
                Console.WriteLine("\nService endpoint {0}: ", endpoint2.Name);
                Console.WriteLine("Binding: {0}", endpoint2.Binding.ToString());
                Console.WriteLine("ListenUri: {0}", endpoint2.ListenUri.ToString());

                Console.WriteLine("\n---> Endpointy:");
                Console.WriteLine("\nService endpoint {0}: ", endpoint3.Name);
                Console.WriteLine("Binding: {0}", endpoint3.Binding.ToString());
                Console.WriteLine("ListenUri: {0}", endpoint3.ListenUri.ToString());

                Console.ReadLine();
                mojHost.Close();
            }catch(CommunicationException e)
            {
                Console.WriteLine(e.Message);
                mojHost.Abort();
            }
        }
    }
}
