using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven_method_overloading
{
    public class Calculator
    {

        // Method Overloading - having more than one method with same name in same class with different parameter/ different signature
        public void Add(int n1 , int n2)
        {

            Console.Write(n1+n2);          

        }

        public void Add(int n1, int n2, int n3)
        {

            Console.Write(n1 + n2);

        }

        public void Add(double n1, int n2, int n3)
        {

            Console.Write(n1 + n2);

        }


    }
}
