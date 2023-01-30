using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Practice_For
{
    class Loop_Concepts
    {
        /// <summary>
        /// Write a C# program that uses a for loop
        /// to print the first 10 even numbers.

        /// </summary>
        public void Loop_Practice()
        {
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Print all numbers from 1 to 10 using a for loop

        /// </summary>
        public void Loop_Practice1()
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Print all even numbers from 2 to 20 using a while loop

        /// </summary>
        public void Loop_Practice2()
        {
            int i = 2;
            while(i < 21)
            {
                Console.WriteLine(i);
                i +=2;
            }
        }
        /// <summary>
        /// Print every third number from 1 to 30 using a for loop

        /// </summary>
        public void Loop_Practice3 ()
        {
            for (int i=1;i<=30;i+=2)
            {
                Console.WriteLine(i); 
            }
        }
        /// <summary>
        /// Write a C# program that uses a while loop
        /// to find and print the sum of all even numbers between 1 and 100.

        /// </summary>
        public void Loop_Practice4()
        {
            int i =0;
            int j=2;
            while(i <= 50)
            {

                Console.WriteLine( j);
                i +=2;
                j = i + (i += 2);
            }
        }

        /// <summary>
        /// Write a C# program that uses a for loop 
        /// to find and print the product of all odd numbers between 1 and 10.

        /// </summary>
        public void Loop_Practice5()
        {
            for(int i=1;i<=10;i+=2)
            {
                int j = i * i; 
                Console.WriteLine( j);
            }
        }

        /// <summary>
        /// Print all elements in a list of strings using a foreach loop
        /// </summary>
        public void StringName()
        {
            string[] name = { "Bhola", "kumar", "google" };
            foreach(string element in name )
            {
                Console.WriteLine( element );
            }

           
        }

        /// <summary>
        /// Print the sum of all elements in an array of integers using a for loop
        /// </summary>
        public void Name()
        {
            int sum;

            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            for(int i=0;i<=5;i++)
            {
                sum = numbers[0]+ numbers[1] + numbers[2] + numbers[3] + numbers[4];
                Console.WriteLine(sum);
            }
                

        }

    }
}


            

