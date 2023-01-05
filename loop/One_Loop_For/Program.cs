using System;
class Program
{
    // break , continue 
    static void Main()
    {
        //for (int i = 0; i < 10; i++)
        //{

        //    Console.WriteLine(i);

        //    if (i > 6)           
        //        break;
         

        //}

        for (int i = 0; i < 10; i++)
        {

            if (i %2==0)
                continue; // below line will be not executed or skipped 
                Console.WriteLine(i);
            
        }


    }
}

