using System;

class Program
{
    static void Main()
    {
        int numberOfPlayers = int.Parse(Console.ReadLine());

        string[] scoresInput = Console.ReadLine().Split();

        int totalScore = 0;

        foreach (var score in scoresInput)
        {
            totalScore += int.Parse(score);
        }

        Console.WriteLine(totalScore);
    }
}