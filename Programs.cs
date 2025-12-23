using System;

class Program
{
    static void Main()
    {
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(
                new string(' ', n - i) +
                new string('*', 2 * i - 1)
            );
        }

        for (int i = n - 1; i >= 1; i--)
        {
            Console.WriteLine(
                new string(' ', n - i) +
                new string('*', 2 * i - 1)
            );
        }
    }
}