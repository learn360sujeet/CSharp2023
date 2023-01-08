using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eight_method_PassByRef_PassByValue_passByout
{
    public class EmployeeV6
    {

        // Pass by value - If method parameter is primitive data type int double byte flot 
        public void Display(int num1, int num2)
        {
            num1 = num1+50;
            num2 = 100;

            Console.WriteLine("Inside Method -" + num1);
            Console.WriteLine("Inside Method -" + num2);
        }


        // Pass by ref - changing the parameter value in calling method will impact the caller variable value 
        public void DisplayPassByref(ref int num1, ref int num2)//calling method
        {
            num1 =  50;
            num2 = 100;

            Console.WriteLine("Inside DisplayPassByref -" + num1); // out put 50
            Console.WriteLine("Inside DisplayPassByref -" + num2);// output 100
        }

        // Pass by out 
        public void DisplayPassByout(out int num1)
        {
            num1 = 500;         

            Console.WriteLine("Inside DisplayPassByout -" + num1); // out put 500
        }
    }
}
