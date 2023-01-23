using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_access_Specifier
{
    // Default is internal for class 
    class Employee_AccessSpecifier
    {
        // Default private for variable 
        int age;

        // Other class should not access this method
        // private - private member of class is not accessed outside of class
        private void Display()
        {
            Console.Write("sdfhbkjsd");

        }




    }
}
