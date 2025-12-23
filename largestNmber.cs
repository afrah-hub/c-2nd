using System;

class Program
{
    static void Main()
{
      int a = 10, b = 25, c = 15;

if (a >= b && a >= c)
{
    Console.WriteLine("Largest number is " + a);
}
else if (b >= a && b >= c)
{
    Console.WriteLine("Largest number is " + b);
}
else
{
    Console.WriteLine("Largest number is " + c);
}



    }
}   