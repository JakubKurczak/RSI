using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.ServiceReference1;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            KalkulatorClient kalkulatorClient = new KalkulatorClient();

            double result = kalkulatorClient.Dodaj(2.3, 3.3);
            Console.WriteLine("Wynik: " + result);
            Console.ReadLine();
            kalkulatorClient.Close();
        }
    }
}
