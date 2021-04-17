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

            KalkulatorClient kalkulatorClient1 = new KalkulatorClient("mojEndpoint3");
            KalkulatorClient kalkulatorClient2 = new KalkulatorClient("WSHttpBinding_IKalkulator");
            KalkulatorClient kalkulatorClient3 = new KalkulatorClient("BasicHttpBinding_IKalkulator");

            Console.WriteLine("Klient 1:");
            
            Console.WriteLine("Wynik Dodaj {0} i {1}: {2}", 2.3,3.3, kalkulatorClient1.Dodaj(2.3, 3.3));
            Console.WriteLine("Wynik Odejmij {0} i {1}: {2}", 2.3, 3.3, kalkulatorClient1.Odejmij(2.3, 3.3));
            Console.WriteLine("Wynik Pomnoz {0} i {1}: {2}", 2.3, 3.3, kalkulatorClient1.Pomnoz(2.3, 3.3));
            Console.WriteLine("Wynik Sumowania {0} : {1}", 2.3, kalkulatorClient1.Sumuj(2.3));
            Console.WriteLine("Wynik wielomianu o x {0} i współczynnikach [{1}] : {2}", 1, string.Join(",", new int[] { 1, 2, 3 }), kalkulatorClient3.RozwiazWielomian(1, new int[] { 1, 2, 3 }));
            Console.WriteLine("Klient 2:");

            Console.WriteLine("Wynik Dodaj {0} i {1}: {2}", 2.3, 3.3, kalkulatorClient2.Dodaj(2.3, 3.3));
            Console.WriteLine("Wynik Odejmij {0} i {1}: {2}", 2.3, 3.3, kalkulatorClient2.Odejmij(2.3, 3.3));
            Console.WriteLine("Wynik Pomnoz {0} i {1}: {2}", 2.3, 3.3, kalkulatorClient2.Pomnoz(2.3, 3.3));
            Console.WriteLine("Wynik Sumowania {0} : {1}", 2.3, kalkulatorClient2.Sumuj(2.3));
            Console.WriteLine("Wynik wielomianu o x {0} i współczynnikach [{1}] : {2}", 2, string.Join(",", new int[] { 1, 2, 3 }), kalkulatorClient3.RozwiazWielomian(2, new int[] { 1, 2, 3 }));
            Console.WriteLine("Klient 3:");

            Console.WriteLine("Wynik Dodaj {0} i {1}: {2}", 2.3, 3.3, kalkulatorClient3.Dodaj(2.3, 3.3));
            Console.WriteLine("Wynik Odejmij {0} i {1}: {2}", 2.3, 3.3, kalkulatorClient3.Odejmij(2.3, 3.3));
            Console.WriteLine("Wynik Pomnoz {0} i {1}: {2}", 2.3, 3.3, kalkulatorClient3.Pomnoz(2.3, 3.3));
            Console.WriteLine("Wynik Sumowania {0} : {1}", 2.3, kalkulatorClient3.Sumuj(2.3));
            Console.WriteLine("Wynik wielomianu o x {0} i współczynnikach [{1}] : {2}", 3,string.Join(",",new int[] { 1, 2, 3 }), kalkulatorClient3.RozwiazWielomian(3, new int[] { 1, 2, 3 }));
            Console.ReadLine();


            kalkulatorClient1.Close();
            kalkulatorClient2.Close();
            kalkulatorClient3.Close();
        }
    }
}
