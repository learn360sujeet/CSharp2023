using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__Loop
{
    
    class Number_Print
    {
        /// <summary>
        /// Print all numbers from 1 to 10 using a for loop
        /// 
        /// </summary>
        public void DisplayNumber()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Print every third number from 1 to 30 using a for loop
        /// </summary>
        public void Numbers()
        {
            int counter=0;
            
            for (int i=1; i<=30;i++)
            {
                counter++;

               if(counter==3)
                {
                    counter = 0;
                    Console.WriteLine(i);
                }
            }
        }
        /// <summary>
        /// Write a C# program that uses a
        /// while loop to print the numbers from 1 to 10 in reverse order.
        /// </summary>
        public void B()
        {
            int num = 10;
            while(num>=1)
            {
                
                Console.WriteLine(num);
                num--;

            }

        }
    }
}
