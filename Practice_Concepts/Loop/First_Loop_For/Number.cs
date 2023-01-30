using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace First_Loop_For
{
    //Write a program in C that uses a for loop to print the numbers from 1 to 10.
    class Number
    {
        ///Write a program that prints the numbers from 5 to 50, <summary>
        ///incrementing by 5 each time using a for loop.
        /// </summary>

        //int i = 10;
        //public static void DisplayNumber()
        //{
        //    for(int i=0;i<=10;i++)

        //    Console.WriteLine("Numbers are " + i);
        //}

        //public int i = 50;
        //public void BholaQ()
        //{
        //    for (int i=5;i<=50;i+=5)
        //   Console.WriteLine("Your Numbers are {0}",i);
        //}

        ///......3) Q/ Write a program that prints
        ///      out all the prime numbers between 1 and 100 using a for loop.

        public  int i = 100;

        public static void DisplayNumber()
        {
            for (int i=2;i<=100;i+=2)
            Console.WriteLine(i);
        }


    }
}
