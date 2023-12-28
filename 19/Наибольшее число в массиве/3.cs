using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Console.ReadLine().Split().Take(n).Select(int.Parse).Max());
    }
}