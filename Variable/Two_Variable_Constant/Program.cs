
using System;

/// <summary>
/// https://www.educba.com/variables-in-c-sharp/
/// </summary>
class Program_A
{

    // Constant Variable must not chnage once value is assigned at the time declaration
    // Mandatory to put value in constant variable at the of declaration
    const float maxValue = 75; 
    public static void Main()
    {       
        // To access constanct variable , you do not need to create object of class 
        Console.WriteLine("Value of max " + Program_A.maxValue);
    }
}