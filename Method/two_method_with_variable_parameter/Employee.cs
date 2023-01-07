
// namespace given by framework to utilize it 
using System;

// blue - that is given by framework 
public class Employee
{

    string name;
    double mobile;
    string email;

    // parameterised method - variable parameterised method 
    public void Display(string strname, int _mobile, string _email)
    {
        // why we storing method value in instance variable - so that we can use it in other method or other place
        name = strname;
        mobile = _mobile;
        email = _email;

        //Console.WriteLine(name);
        Console.WriteLine(mobile);
        Console.WriteLine(email);

       

    }

    // We assiging value in name variabe in display method and using here 
    public void DisplayNext()
    {

        Console.WriteLine(name);

    }
}

