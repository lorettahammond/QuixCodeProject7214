using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2Retry
{
    class Program
    {
        static void Main(string[] args)                       //create public method of Main containing string of arguments.  The arguments are btw the {}
        {
            var Book1 = new Book();                           //create new instance of book known as Book1
            Book1.Price =24.99M;                              //set Book1 price to $54.99
            var Book2 = new Book();                           //create new instance of book known as Book2
            Book2.Price = 26.95M;                             //set Book price to $26.95
                                                              //M: take constant & treat as a   decimal	

            var answer = Book1.CompareTo(Book2);              //create variable called answer
                                                              //use method CompareTo created below that compares Book1 to Book2

            Console.WriteLine(answer);

        }

        public class Book : IComparable<Book>               //creates a public class of BiggerNumber with an interger; set intergers of first and second
        {
            public string Title { get; set; }               //gets & sets Book property of title (know its a property by get & set)

            public decimal Price { get; set; }              //gets & sets Book property of title

            public int CompareTo(Book other)                //create a method of Compare to: permits comparison of Book1 & Book2 prices
                                                            //CompareTo acts upon two numbers. It returns an int value. 
                                                            //A negative one indicates the first value is smaller. 
                                                            //A positive one indicates the first value is bigger. 
                                                            //And a zero indicates the two values are equal.

                                                            //Could also do a if/else/else loop. The CompareTo method does this for you.
        {
            return Price.CompareTo(other.Price);           //returns the price
        }
        }
    }
}
