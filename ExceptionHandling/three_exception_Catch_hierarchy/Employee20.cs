using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Exception_CatchBlock_understanding
{
    internal class Employee20
    {
        int num1 = 10;

        int num2 = 0;


        public void divide_advance()
        {
            // put all code that can throw error or cause issue/exception inside try block 
            try
            {
                int f = 2 + 6 * 8;

                // divide by 
                int c = num1 / num2; // error - divide by zero

                string ss = "dd" + "dd";

            }           
            


            catch (DivideByZeroException ex) // If any error occur in try block then catch block will be executed/called
            {

            }

            catch (ArithmeticException ex) // If any error occur in try block then catch block will be executed/called
            {

            }

            catch (SystemException ex) // If any error occur in try block then catch block will be executed/called
            {

            }

            catch (Exception ex) // If any error occur in try block then catch block will be executed/called
            {

            }
            // in exception hurarchy
            // >> always child exception  will be written first and parent  exception will be written last
            // >> why we will right parent at the last 

        }
    }
}
