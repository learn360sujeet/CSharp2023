
// namespace given by framework to utilize it 
using System;
using three_method_class_paramter;

// blue - that is given by framework 
public class EmployeeV2
{

    string name;
    double mobile;
    string email;

    // parameterised method - variable parameterised method 
    public void Display(EmployeeDetails employeeDetails)
    {
        // why we storing method value in instance variable - so that we can use it in other method or other place
        
        mobile = employeeDetails._mobile;
        email = employeeDetails._email;

        Console.WriteLine(employeeDetails.strname);// directly using 
        Console.WriteLine(mobile); // using with the help of instance varibale 
        Console.WriteLine(email);       

    }
}

