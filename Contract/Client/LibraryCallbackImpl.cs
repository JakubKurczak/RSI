using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference5;
namespace Client
{
    class LibraryCallbackImpl : LibraryCallback
    {
        
        public void handleFindByTitle(Book[] books)
        {
            Console.WriteLine("Books from LibraryCallback:");
            foreach(Book b in books)
            {
                Console.WriteLine("Id: {0}, Title: {1}, Fee: {2}, isBorrowed: {3}", b.id, b.title, b.fee, b.isBorrowed);
            }
        }
    }
}
