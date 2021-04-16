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

            Uri baseAddress = new Uri("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Service1/mex");

            ServiceHost mojHost = new ServiceHost(typeof(MojKalkulator), baseAddress);

            WSHttpBinding mojBanding = new WSHttpBinding();
            mojHost.AddServiceEndpoint(typeof(IKalkulator), mojBanding, "endpoint_1");

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();

            smb.HttpGetEnabled = true;
            mojHost.Description.Behaviors.Add(smb);

            try
            {
                mojHost.Open();
                Console.WriteLine("Serwis uruchomiony.");
                Console.WriteLine("Nacisnij Enter aby zakonczyc");
                Console.WriteLine();
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
