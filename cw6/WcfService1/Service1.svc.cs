using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie, usłudze i pliku konfiguracji.
    // UWAGA: aby uruchomić klienta testowego WCF w celu przetestowania tej usługi, wybierz plik Service1.svc lub Service1.svc.cs w eksploratorze rozwiązań i rozpocznij debugowanie.
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class Service1 : IRestService
    {
        private static List<Book> Books = new List<Book> { new Book("Lalka", "Bolesław Prus", 560), new Book("Tango", "Sławomir Mrożek", 200) };

        public string addJson(Book book)
        {
            Books.Add(book);
            return "książka została dodana";
        }

        public string addXml(Book book)
        {
            Books.Add(book);
            return "książka została dodana";
        }

        public string deleteJson(Book book)
        {
            if (Books.Remove(book))
            {
                return "książka została usunięta";
            }
            else
            {
                return "książka nie istnieje";
            }
        }

        public string deleteXml(Book book)
        {
            if (Books.Remove(book))
            {
                return "książka została usunięta";
            }
            else
            {
                return "książka nie istnieje";
            }

        }

        public List<Book> getAllJson()
        {
            return Books;
        }

        public List<Book> getAllXml()
        {
            return Books;
        }

        public Book getByIdJson(string Id)
        {
            return Books.Where(x => x.id == Int32.Parse(Id)).First();
        }

        public Book getByIdXml(string Id)
        {
            return Books.Where(x => x.id == Int32.Parse(Id)).First();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Book GetDataUsingDataContract(Book composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }

            return composite;
        }

        public string borrowBookJson(string Id)
        {
            var book = Books.Where(x => x.id == Int32.Parse(Id) && x.IsBorrow == false).First();
            if (book != null)
            {
                book.IsBorrow = true;
                return "książka wypożyczona";
            }
            else
            {
                return "nie można wypożyczyć";
            }

        }

        public string borrowBookXml(string Id)
        {
            var book = Books.Where(x => x.id == Int32.Parse(Id) && x.IsBorrow == false).First();
            if (book != null)
            {
                book.IsBorrow = true;
                return "książka wypożyczona";
            }
            else
            {
                return "nie można wypożyczyć";
            }
        }

        public string updateByIdJson(string Id, string Title, string Author, int Pages)
        {
            var book = Books.Where(x => x.id == Int32.Parse(Id)).First();
            if (book != null)
            {
                book.Author = Author;
                book.Pages = Pages;
                book.Title = Title;
                return "książka zaktualizowana";
            }
            else
            {
                return "książka nie istnieje";
            }

        }

        public string updateByIdXml(string Id, string Title, string Author, int Pages)
        {
            var book = Books.Where(x => x.id == Int32.Parse(Id)).First();
            if (book != null)
            {
                book.Author = Author;
                book.Pages = Pages;
                book.Title = Title;
                return "książka zaktualizowana";
            }
            else
            {
                return "książka nie istnieje";
            }
        }
    }
}
