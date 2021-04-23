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
using Client.ServiceReference5;

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
            Console.WriteLine("...calling Factorial({0})...", value1);
            superCalcClient.Factorial(value1);

            int value2 = 5;
            Console.WriteLine("...calling DoSomething...");
            superCalcClient.DoSomething(value2);

            Console.WriteLine("--> Client must wait for results");
            Console.WriteLine("Press <ENTER> after receiving all results");
            Console.ReadLine();
            superCalcClient.Close();
            Console.WriteLine("CLIENT3 - STOP");

            //--------------------------------------------------------------------

            Console.WriteLine("CLIENT3 - START(Callback service)");
            LibraryCallbackImpl libraryCallback = new LibraryCallbackImpl();
            InstanceContext instanceContext_1 = new InstanceContext(libraryCallback);
            LibraryClient library = new LibraryClient(instanceContext_1);
            var programOn = true;
            while (programOn)
            {


                Console.WriteLine("Wybierz polecenie");
                Console.WriteLine("1. Dodaj książke");
                Console.WriteLine("2. Wypożycz książke");
                Console.WriteLine("3. Znajdź książke po tytule");
                Console.WriteLine("4. Wypisz książki");
                Console.WriteLine("5. Znajdź tytuł po id");
                Console.WriteLine("0. Wyjście");
                var enter = Console.ReadLine();
                Int32 func;
                if (!Int32.TryParse(enter, out func))
                {
                    if (func == 1)
                    {
                        Console.WriteLine("Podaj Tytuł");
                        string title = Console.ReadLine();
                        Console.WriteLine("Podaj karę");
                        string fee = Console.ReadLine();
                        double convertFee;
                        if (double.TryParse(fee, out convertFee))
                        {
                            var book = new Book();
                            book.id = 1;
                            book.fee = convertFee;
                            book.isBorrowed = false;
                            book.title = title;
                            library.add(book);
                        }
                        else
                        {
                            Console.WriteLine("kara być liczbą");
                        }
                        //LibraryImpl.books;
                    }
                    else if (func == 2)
                    {
                        Console.WriteLine("podaj id książki do wypożyczenia");
                        var enter2 = Console.ReadLine();
                        Int32 id2;
                        if (Int32.TryParse(enter2, out id2))
                        {
                            library.borrow(id2);
                        }
                        else
                        {
                            Console.WriteLine("id musi być liczbą");
                        }

                    }
                    else if (func == 3)
                    {
                        Console.WriteLine("podaj tytuł książki do znalezienia");
                        var enter3 = Console.ReadLine();
                        library.findByTitle(enter3);
                    }
                    else if (func == 4)
                    {
                        library.getAllBooks();
                    }
                    else if (func == 5)
                    {
                        Console.WriteLine("podaj id książki, której tytuł potrzebujesz");
                        var enter5 = Console.ReadLine();
                        Int32 id5;
                        if (Int32.TryParse(enter5, out id5))
                        {
                            library.getTitleById(id5);
                        }
                        else
                        {
                            Console.WriteLine("id musi być liczbą");
                        }

                    }
                    else if (func == 0)
                    {
                        programOn = false;
                    }
                    else
                    {
                        Console.WriteLine("niepoprawny numer");
                    };
                }
                else
                {
                    Console.WriteLine("To nie liczba");
                }
            }
            superCalcClient.Close();
            Console.WriteLine("CLIENT3 - STOP");
        }
    }
}
