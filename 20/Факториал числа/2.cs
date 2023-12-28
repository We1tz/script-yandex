using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result = 1;
        int j = 1;
        while (j <= n)
        {
            result *= j;
            j++;
        }
        Console.WriteLine($"{result} ({string.Join(" * ", Enumerable.Range(1, n))})");
    }
}