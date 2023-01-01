using System;

class Constructor_Concepts
{

    //class memeber declaration of variables

    string bookName; 

    int bookNumber;

    public Constructor_Concepts(string myNmae )
    {
        Console.WriteLine(myNmae);
    }

    static void Main(string[] args)

    {
        Constructor_Concepts obj = new Constructor_Concepts("BHOLA");

        obj.bookName = "Programming language ";

        obj.bookNumber = 1; ;

        Console.WriteLine( obj.bookName);

        Console.WriteLine(obj.bookNumber);  

        Console.ReadLine();
    }
}
