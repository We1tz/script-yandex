using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] scores = Console.ReadLine().Split().Take(n).Select(int.Parse).ToArray();
        Console.WriteLine(scores.Max());
    }
}