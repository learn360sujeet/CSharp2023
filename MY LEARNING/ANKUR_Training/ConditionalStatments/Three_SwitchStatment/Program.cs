using System;

class Switch_Concepts
{

    static void Main()
    {
        Console.Write("Enter the Number to show the result outcoome:");

        int userNumber =int.Parse(Console.ReadLine());  

        switch(userNumber)

        {
            case 20:
                {
                    Console.WriteLine("Entered number is 100");
                    break;
                }
            case 200:
                {
                    Console.WriteLine("Entered number is 200");
                    break;
                }

            case 300:
                {
                    Console.WriteLine("Entered number is 300");
                    break;
                }
            default:
                {
                    Console.WriteLine("Its Invalid number");
                    break;
                }



        }
        
    }



}