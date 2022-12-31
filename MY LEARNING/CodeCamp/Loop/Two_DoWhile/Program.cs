using System;

class Do_While
{
    static void Main()
    {
        int num1 = 20;
        do
        {
            Console.WriteLine(num1);
            num1++;
  // condition false but looping done once 
        } while (num1 <= 10);

        Console.ReadLine();

    }
}