// WRITELINE (PRINT AND MOVE TO NEXT LINE IN CONSOLE WINDOW .

// WRITE (PRINT AND HOLD ON TO THE CONSOLE WINDOW UNTILL USER INPUT .

class UserInput
{
    static void Main ()
    {
        Console.Write(" KINDLY ENTER YOUR NAME :");

        string  name = Console.ReadLine ();

        Console.WriteLine ("Hello {0}", name );


        Console.ReadLine(); 


    }
}