using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nine_constructore
{
    // 1. What is constrcutor 
    // 2. What is condtion to create a object when you have constrcutor with paramter //new EmployeeConstructor(10, 123456789);
    // 3. What is default constrcutor
    // 4. 
    internal class EmployeeConstructor
    {

        private int age;


        public EmployeeConstructor() // whenever you create a object of this class then pass the parameter
        {
          


        }

        // contrcutor is special method which has same name as class name 
        // contrcutor has same name as class name
        // contrcutor does not have return type
        public EmployeeConstructor(int _age) // whenever you create a object of this class then pass the parameter
        {
            age = _age;


        }

        public EmployeeConstructor(int _age , int mobile) // whenever you create a object of this class then pass the parameter
        {
            age = _age;


        }
        public void display()
        {
            Console.WriteLine("Age-" + age);
        }
    }
}
