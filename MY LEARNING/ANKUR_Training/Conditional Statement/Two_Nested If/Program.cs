using System;

class Nested_If
{
    static void Main()
    {
        Console.Write("Enter the Number of your choice :");

        int userNumber = int.Parse(Console.ReadLine()); 

        if(userNumber == 100 ) 
        {
            Console.WriteLine("Entered number is 100");
        }

        else if(userNumber==300)
        {
            Console.WriteLine("Entered number is 300");

        }

        else
        {
            Console.WriteLine("Number is Invalid :");

        }
        Console.ReadLine();
    }
}