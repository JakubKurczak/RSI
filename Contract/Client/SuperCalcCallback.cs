using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference4;

namespace Client
{
    class SuperCalcCallback : ISuperCalcCallback
    {
        public void doSomethingResult(string res)
        {
            Console.WriteLine(" Calculations: {0}", res);
        }

        public void factorialResult(double res)
        {
            Console.WriteLine("Factorial: {0}", res);
        }
    }
}
