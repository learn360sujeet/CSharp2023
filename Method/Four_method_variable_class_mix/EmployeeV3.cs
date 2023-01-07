using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_method_variable_class_mix
{
    internal class EmployeeV3
    {

        string name;
        double mobile;
        string email;

        // parameterised method - variable parameterised method 
        public void DisplayV2(string strname, int _mobile, string _email)
        {
            // why we storing method value in instance variable - so that we can use it in other method or other place
            name = strname;
            mobile = _mobile;
            email = _email;

            Console.WriteLine(strname); // direct
            Console.WriteLine(mobile);
            Console.WriteLine(email);
        }

        public void ShowMe(EmployeeDetails employeeDetails)
        {
            // why we storing method value in instance variable - so that we can use it in other method or other place

            mobile = employeeDetails._mobile;
            email = employeeDetails._email;

            Console.WriteLine(employeeDetails.strname);// directly using 
            Console.WriteLine(mobile); // using with the help of instance varibale 
            Console.WriteLine(email);

        }

        public void DisplayDemo(EmployeeDetails employeeDetails , string state, string country)
        {
            // why we storing method value in instance variable - so that we can use it in other method or other place

            mobile = employeeDetails._mobile;
            email = employeeDetails._email;

            Console.WriteLine(employeeDetails.strname);// directly using 
            Console.WriteLine(mobile); // using with the help of instance varibale 
            Console.WriteLine(email);

        }


    }
}

