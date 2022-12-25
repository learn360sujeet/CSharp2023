
#region Way 1 of using read only 

using System;
class Program_B
{

    //readonly int age = 18; // read-only variable
    //public static void Main()
    //{
    //    Program_B classObject = new Program_B(); // object creation

    //    Console.WriteLine("Value of age : " + classObject.age);

    //    Console.Read();
    //}
}

#endregion


#region Way 2 of using read only variable 
class Program_way2
{

    //// Optional to put value in read only variable 
    //readonly int age;
    //public static void Main()
    //{
    //    Program_way2 classObject = new Program_way2(); // object creation

    //    Console.WriteLine("Value of age : " + classObject.age);

    //    Console.Read();
    //}
}
#endregion


class Program_way3
{

    // Optional to put value in read only variable 
    readonly int age;


    // Constructor - A special method having same name as class 
    Program_way3()
    {
        age = 18;

    }

    public static void Main()
    {
        Program_way3 classObject = new Program_way3(); // object creation

        // To access Read only  variable , you do  need to create object of class 
        Console.WriteLine("Value of age : " + classObject.age);

        Console.Read();
    }
}
