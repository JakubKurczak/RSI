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


    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class LibraryImpl : Library
    {
        public static List<Book> books = new List<Book> {new Book(0,"Pan Tadeusz",5.55,false), new Book(1, "Wesele", 2.43, false), new Book(2, "Sklepy Cynamonowe", 7.1, false) };
        ILibraryCallback libraryCallback = null;
        public LibraryImpl()
        {
           libraryCallback = OperationContext.Current.GetCallbackChannel<ILibraryCallback>();
                        
        }
        public void add(Book book)
        {
            books.Add(book);
        }

        public void borrow(int id)
        {
            Book temp = books.Find(x => x.id == id);
            if (temp != null && !temp.isBorrowed)
                temp.isBorrowed = true;
        }

        public void findByTitle(string title)
        {
            Thread.Sleep(3000);
            libraryCallback.handleFindByTitle(books.Where(x => x.title.Contains(title) == true).ToList());
        }

        public void getAllBooks()
        {
            libraryCallback.handleFindByTitle(books);
        }

        public string getTitleById(int id)
        {
            return books.Find(x => x.id == id) != null ? books.Find(x => x.id == id).title : "";
        }
    }
}
