using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result = CalculateFactorial(n);
        Console.WriteLine($"{result} ({string.Join(" * ", Enumerable.Range(1, n))})");
    }

    static int CalculateFactorial(int num)
    {
        if (num <= 1)
        {
            return 1;
        }
        else
        {
            return num * CalculateFactorial(num - 1);
        }
    }
}