using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Book other)
        {
            return Price.CompareTo(other.Price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Book1 = new Book();
            Book1.Price = 5.99M;
            var Book2 = new Book();
            Book2.Price = 7;

            var answer = Book1.CompareTo(Book2);

            Console.WriteLine(answer);

        }
    }
}