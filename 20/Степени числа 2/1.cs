using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"2^{i} = {Math.Pow(2, i)}");
        }
    }
}