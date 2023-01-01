using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number :");

        int userNUmber= int.Parse( Console.ReadLine() ); 

        if ( userNUmber == 200 )
        {
            Console.WriteLine("Your enterd number is 200");

        }

        else
        {
            Console.WriteLine("Entered number is Invalid:");

        }

        Console.ReadLine();
    }
}
