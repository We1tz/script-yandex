using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result = Enumerable.Range(1, n).Aggregate((acc, x) => acc * x);
        Console.WriteLine($"{result} ({string.Join(" * ", Enumerable.Range(1, n))})");
    }
}