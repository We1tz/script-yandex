using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] scores = Console.ReadLine().Split();

        Array.Reverse(scores);
        Console.WriteLine(string.Join(" ", scores));
    }
}