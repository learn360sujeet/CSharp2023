// See https://aka.ms/new-console-template for more information
//
//Console.WriteLine("Hello, World!");

using System;

class InsatnceVariable
{
    int c;
    public  void Add()
    {
        int a = 100;
        int b = 200;
        int c =a+b;
        Console.WriteLine(c);

    }

    public  void Sub()
    {
        int a = 200;
        int b = 100;
        int c = b - a;
        Console.WriteLine(c);
    }

    static void Main(string[] args)
    {
        InsatnceVariable obj= new InsatnceVariable();
        obj.Add();
        Console.ReadLine();
    }
   
}
