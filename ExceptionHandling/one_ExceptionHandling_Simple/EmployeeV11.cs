using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_ExceptionHandling_Simple
{
    internal class EmployeeV11
    {

        int num1 = 10;

        int num2 = 0;

        // what is exception - Exception is an error at run time 
        // How to handle exception - try and catch 

        public void divide()
        {
            // put all code that can throw error or cause issue/exception inside try block 
            try
            {
                // divide by 
                int c = num1 / num2; // error - divide by zero

                string ss;
                int hh;

                int ggg;
            }
            catch // If any error occur in try block then catch block will be executed/called
            {

                Console.WriteLine("Some issue happended , please try again");


            }


        }

        public void divide_advance()
        {
            // put all code that can throw error or cause issue/exception inside try block 
            try
            {
                // divide by 
                int c = num1 / num2; // error - divide by zero

                string ss;
                int hh;

                int ggg;
            }
            catch(Exception ex) // If any error occur in try block then catch block will be executed/called
            {
                // Exception class is base class of all exception 
                // exception  class give message property which contains a description of the error,
                // exception  class  give StackTrace property, which contains the call stack at the time the exception was thrown
                Console.WriteLine("Some issue happended , please try again");
            }


        }
    }
}
