using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Client.ServiceReference2;
using Client.ServiceReference3;
using Client.ServiceReference4;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CCalculatorClient client = new CCalculatorClient("WSHttpBinding_ICCalculator1");
            ComplexNum n1 = new ComplexNum();
            n1.real = 1.2;
            n1.imag = 3.4;
            ComplexNum n2 = new ComplexNum();
            n2.real = 5.6;
            n2.imag = 7.8;
            Console.WriteLine("\nCLIENT1 - START");
            Console.WriteLine("calling addNum(...)");
            ComplexNum result = client.addCNum(n1, n2);
            Console.WriteLine("addNum(...) = ({0},{1})", result.real, result.imag);
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
            client.Close();
            Console.WriteLine("CLIENT1 - STOP");

            //--------------------------------------------------------------------

            Console.WriteLine("CLIENT2 - START(Async service)");
            AsyncServiceClient asyncServiceClient = new AsyncServiceClient("BasicHttpBinding_IAsyncService");
            Console.WriteLine("...calling Fun 1");
            asyncServiceClient.Fun1("asyncServiceClient");
            Thread.Sleep(10);
            Console.WriteLine("... continue after Fun 1 call");
            Console.WriteLine("...calling Fun 2");
            asyncServiceClient.Fun2("asyncServiceClient");
            Thread.Sleep(10);
            Console.WriteLine("... continue after Fun 2 call");
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
            asyncServiceClient.Close();
            Console.WriteLine("CLIENT2 - STOP");

            //--------------------------------------------------------------------

            Console.WriteLine("CLIENT3 - START(Callback service)");
            SuperCalcCallback superCalcCallback = new SuperCalcCallback();
            InstanceContext instanceContext = new InstanceContext(superCalcCallback);
            SuperCalcClient superCalcClient = new SuperCalcClient(instanceContext);

            double value1 = 10.0;
            Console.WriteLine("...calling Factorial({0})...",value1);
            superCalcClient.Factorial(value1);

            int value2 = 5;
            Console.WriteLine("...calling DoSomething...");
            superCalcClient.DoSomething(value2);

            Console.WriteLine("--> Client must wait for results");
            Console.WriteLine("Press <ENTER> after receiving all results");
            Console.ReadLine();
            superCalcClient.Close();
            Console.WriteLine("CLIENT3 - STOP");
        }
    }
}
