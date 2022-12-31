//What is static or class var ?
//...variables declared with the static modifier
//these variables are declared like instance variable(inside the class) BUTTT this uses static as its not seen in insatnce variable.
//static variables are created at the start of the program
// we will have to access the static variables with the help of class NOT TO MAKE THE OBJECT OF CLASS.


using System;
class Employee
{
    static double Salary;
    static string employeeName = "Bhola's";

    public static void Main(string[] args)
    {
        Employee.Salary = 100000;
        Console.WriteLine("employeeName {0} salary is :{1} ", employeeName, Salary);
    }





}