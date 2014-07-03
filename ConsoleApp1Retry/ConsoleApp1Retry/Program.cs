using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Retry
{
    class Program
    {
        public static void Main(string[] args)                             //create public method of Main containing string of arguments.  The arguments are btw the {}
                                                          
        {
            int number1;                                                    //declare number 1
            int number2;                                                    //declare number 2
            Console.WriteLine("Please enter a number");                     //Prompt user for first number
            number1 = int.Parse(Console.ReadLine());                        //Method of int.Parse: used to convert strings into intergers; converts number 1 to interger
            Console.WriteLine("Please enter a second number");              //Prompt user for second number
            number2 = int.Parse(Console.ReadLine());                        //Method of int.Parse: used to convert strings into intergers; converts number 2 to interger
            BiggerNumber(number1, number2);                                 //Calls BiggerNumber method from below, using number 1 & number 2 entered by user
            Console.ReadLine();                                             //Show bigger number from "bigger number"
        }

        public static void BiggerNumber(int first, int second)              //creates a public class of BiggerNumber with an interger; set intergers of first and second
        {
            if (first < second)                                             //if 1st number is < 2nd number, then state that the 1st number is smaller of the 2 numbers entered
            {
                Console.WriteLine(first + " is the smaller number of the numbers you entered");
                Console.ReadLine();                                         //if statement is found true, loop will stop; if false, loop will advance to next step.
            }
            else if (second < first)                                        //if first < second is false, test to see if the 2nd number is > 1st number
                                                                            //if statement is true, return that the 2nd number is the smaller of the 2 numbers entered
            {
                Console.WriteLine(second + " is the smaller number of the numbers you entered");
                Console.ReadLine();
            }
             
        }
    }
}