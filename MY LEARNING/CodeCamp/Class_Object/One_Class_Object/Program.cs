using System;

class LaptopDetails

{
    string laptopName;

    string laptopColour;

    string laptopNumber;


    static void Main(string[] args)
    {
        LaptopDetails obj = new LaptopDetails();

        obj.laptopName = "Asus";

        obj.laptopNumber = "1";

        obj.laptopColour = "green";

        Console.WriteLine(obj.laptopName);
        Console.WriteLine(obj.laptopColour);
        Console.WriteLine(obj.laptopNumber);

        Console.ReadLine(); 

    }
}