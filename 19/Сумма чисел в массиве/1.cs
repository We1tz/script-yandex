using System;

class Program
{
    static void Main()
    {
        int numberOfPlayers = int.Parse(Console.ReadLine());

        string[] scoresInput = Console.ReadLine().Split();

        int[] scores = new int[numberOfPlayers];

        int totalScore = 0;
        for (int i = 0; i < numberOfPlayers; i++)
        {
            scores[i] = int.Parse(scoresInput[i]);
            totalScore += scores[i];
        }

        Console.WriteLine(totalScore);
    }
}