﻿

byte smallNumber = 100;
int largeNumber = smallNumber;

Console.WriteLine(largeNumber);//Implicit Casting

double largerNumber = 300.45;
int smallerNumber = (int)largerNumber;//Explicit Casting //Type Casting//Data may be lost 

Console.WriteLine(smallerNumber);