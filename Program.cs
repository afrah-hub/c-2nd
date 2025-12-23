using System;

class Program
{
    static void Main()
{
      int marks = 85;

if (marks >= 90 && marks <= 100)
{
    Console.WriteLine("S grade");
}
else if (marks >= 80 && marks < 90)
{
    Console.WriteLine("A grade");
}
else if (marks >= 70 && marks < 80)
{
    Console.WriteLine("B grade");
}
else if (marks >= 60 && marks < 70)
{
    Console.WriteLine("C grade");
}
else if (marks >= 50 && marks < 60)
{
    Console.WriteLine("D grade");
}
else if (marks >= 40 && marks < 50)
{
    Console.WriteLine("E grade");
}
else if (marks >= 0 && marks < 40)
{
    Console.WriteLine("Student has failed");
}
else
{
    Console.WriteLine("Invalid marks");
}


    }
}   