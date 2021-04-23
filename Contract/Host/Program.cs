using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using CallbackContract;
using Contract;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:1001/MojSerwis");
            ServiceHost serviceHost = new ServiceHost(typeof(MyCCalculator), baseAddress);
            WSHttpBinding binding = new WSHttpBinding();
            ServiceEndpoint endpoint = serviceHost.AddServiceEndpoint(typeof(ICCalculator),binding, "endpoint_1");

            ServiceMetadataBehavior serviceMetadata = new ServiceMetadataBehavior();
            serviceMetadata.HttpGetEnabled = true;
            serviceHost.Description.Behaviors.Add(serviceMetadata);
            
            // ------------------------------------------------------------------------------
            
            Uri asyncBaseAddress = new Uri("http://localhost:1005/MojAsyncSerwis");
            ServiceHost asyncServiceHost = new ServiceHost(typeof(MyAsyncService), asyncBaseAddress);
            BasicHttpBinding asyncBinding = new BasicHttpBinding();
            ServiceEndpoint asyncEndpoint = asyncServiceHost.AddServiceEndpoint(typeof(IAsyncService), asyncBinding, "endpoint_2");
            asyncServiceHost.Description.Behaviors.Add(serviceMetadata);

            // ------------------------------------------------------------------------------

            Uri callbackAddress = new Uri("http://localhost:1006/MojCallbackSerwis");
            ServiceHost callbackServiceHost = new ServiceHost(typeof(MySuperCalc), callbackAddress);
            WSDualHttpBinding callbackBinding = new WSDualHttpBinding();
            ServiceEndpoint callbackEndpoint = callbackServiceHost.AddServiceEndpoint(typeof(ISuperCalc), callbackBinding, "endpoint_3");

            callbackServiceHost.Description.Behaviors.Add(serviceMetadata);

            try
            {
                serviceHost.Open();
                Console.WriteLine("----> ComplexCalculator is running.");
                asyncServiceHost.Open();
                Console.WriteLine("----> asyncServiceHost is running.");
                callbackServiceHost.Open();
                Console.WriteLine("----> callbackServiceHost is running.");

                Console.WriteLine("----> Press <ENTER> to stop.\n");
                Console.ReadLine();
                serviceHost.Close();
                Console.WriteLine("----> ComplexCalculator finished running.");
                asyncServiceHost.Close();
                Console.WriteLine("----> asyncServiceHost finished running.");
                callbackServiceHost.Close();
                Console.WriteLine("----> callbackServiceHost finished running.");
            }
            catch(CommunicationException e)
            {
                Console.WriteLine("Exception occurred: {0}", e.Message);
                serviceHost.Abort();
                asyncServiceHost.Abort();
                callbackServiceHost.Abort();
            }
        }
    }
}
