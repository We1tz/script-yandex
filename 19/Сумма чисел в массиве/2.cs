using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int numberOfPlayers = int.Parse(Console.ReadLine());
        int[] scores = ReadIntArray();
        Console.WriteLine(scores.Sum());
    }
    static int[] ReadIntArray()
    {
        string[] input = Console.ReadLine().Split();
        return input.Select(int.Parse).ToArray();
    }
}