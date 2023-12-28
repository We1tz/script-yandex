using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] scores = Console.ReadLine().Split();

        Console.WriteLine(string.Join(" ", scores.Reverse()));
    }
}