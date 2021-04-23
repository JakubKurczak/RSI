using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace Contract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MyCCalculator : ICCalculator
    {       

        public ComplexNum addCNum(ComplexNum n1, ComplexNum n2)
        {
            return new ComplexNum(n1.real + n2.real, n1.imag + n2.imag);
        }
    }

    [ServiceBehavior(ConcurrencyMode= ConcurrencyMode.Multiple)]
    public class MyAsyncService : IAsyncService
    {
        public void Fun1(string s)
        {
            Console.WriteLine("Called Fun1 - start...");
            Thread.Sleep(4 * 1000);
            Console.WriteLine("...Fun1 - stop");
            return;
        }

        public void Fun2(string s)
        {
            Console.WriteLine("Called Fun2 - start...");
            Thread.Sleep(2 * 1000);
            Console.WriteLine("...Fun2 - stop");
            return;
        }
    }
}
