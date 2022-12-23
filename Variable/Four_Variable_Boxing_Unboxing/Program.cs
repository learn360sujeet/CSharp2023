// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bhola Prasad");
///Boxing is the process of converting value type to refrence type

int numberOne = 100;
object obj = numberOne;
Console.WriteLine(obj);// Boxing

///Unboxing is the process of converting refrence type to value type
 

int numberTwo = (int)obj;//Every Conversion results a value ,that has to be contained in a container like type and variable
Console.WriteLine(numberTwo);
