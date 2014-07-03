using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCode070214
{
    class Program
    {
        static void Main(string{} args)
        {
            var smallest = SmallerValue(56, 35);

            Console.WriteLine(smallest);
        }

        private static object SmallerValue(int left, int right)
        {
            return Math.Min(left, right);
        }
    }
}

//Question1: Write a console application that has a method that takes in 2 intergers as parameters and returns the smallest of the two intergers
