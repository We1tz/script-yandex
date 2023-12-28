using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(scores.Max());
    }
}