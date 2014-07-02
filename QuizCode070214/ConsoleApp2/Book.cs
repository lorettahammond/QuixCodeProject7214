using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Book
    {
    }
}

public int bookPrice1 = 24.99;
public int bookPrice2 = 9.99;




if(bookPrice1== bookPrice2 
   {
    MessageBox.Show("1");
   }

if(bookPrice1> bookPrice2 
   {
    MessageBox.Show("Book 1 prices greater than that of Book2");
   }

if(bookPrice1<bookPrice2 
   {
    MessageBox.Show("-1");
   }
//Notes: 
//need if else loop to loop through conditions; 1st iteration to test if prices are the same & stops; 
//2nd: if 1st not true, move to 2nd, which would test if 1st is greater price than 2nd; output of 1
//3rd; if 2nd is not true, move to 3rd, in which test if 1st book is cheaper than second; output of -1



//Write a console application that compares 2 book objects by their price.
//Return 0 if the prices are the same, 1 if the first book is more expensive than the second, and -1 if the first book is cheaper than the second book

