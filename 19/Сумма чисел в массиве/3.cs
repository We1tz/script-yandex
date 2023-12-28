using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int numberOfPlayers = int.Parse(Console.ReadLine());

        int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(scores.Sum());
    }
}