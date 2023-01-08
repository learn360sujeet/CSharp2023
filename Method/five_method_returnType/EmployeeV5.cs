using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace five_method_returnType
{
    public class EmployeeV5
    {
        int result;

        //  void= no return
        //  int - return int value 
        public int Add(int num1, int num2)
        {

            result = num1 + num2;

            Console.WriteLine(result);

            return result;

        }

        public double AddV2(int num1, int num2)
        {

            result = num1 + num2;

            Console.WriteLine(result);

            return result;

        }

        public int []  AddV3(int num1, int num2)
        {

            int[] arr = new int[6];

            return arr;

        }

        //public EmployeeDetails AddDemo(int num1, int num2)
        //{
        //    EmployeeDetails obk = new EmployeeDetails();

        //    return obk;

        //}

    }
}
