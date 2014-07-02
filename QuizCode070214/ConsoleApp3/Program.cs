using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            for (int i = 0; i < number; i++)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}

for(int i=1; i<100; i++)
{
    if(i is a multiple of 3)
    {
        MessageBox.Show("Fizz");
    }
        
    else if(i is a multiple of 5)
    {
        MessageBox.Show("Buzz");
    }

}

//Notes:
//Do an array within a loop?



//int[] values = Enumerable.Range(0, 100).ToArray();


//Write a console application that writes to the console the numbers from 1 t0 100.  
//But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz"
//For numbers which are multiples of both three and five print "FizzBizz"

