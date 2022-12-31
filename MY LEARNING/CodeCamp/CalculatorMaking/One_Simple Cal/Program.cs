class Calculator
{
    static void Main()
    {
        Console.Write("Enter the first Number :");

        int firstNum= Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Second Number :");

        int SecondNum= Convert.ToInt32(Console.ReadLine());

        int sum = firstNum + SecondNum;

        Console.WriteLine( " The Result is {0} ", sum);

        Console.ReadLine(); 

    }
}