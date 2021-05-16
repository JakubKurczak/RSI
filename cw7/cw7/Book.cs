using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw7
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Book()
        {

        }
        public Book(int id, string title, string author, int year, double price)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Year = year;
            this.Price = price;
        }

    }
}
