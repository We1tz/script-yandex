using System;

class Program
{
    static void Main()
    {
        int numberOfPlayers = int.Parse(Console.ReadLine());

        string input = Console.ReadLine();
        string[] scoresString = input.Split(' ');

        int[] scores = new int[numberOfPlayers];
        for (int i = 0; i < numberOfPlayers; i++)
        {
            scores[i] = int.Parse(scoresString[i]);
        }

        int maxScore = FindMaxScore(scores);

        Console.WriteLine(maxScore);
    }

    static int FindMaxScore(int[] scores)
    {
        int maxScore = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > maxScore)
            {
                maxScore = scores[i];
            }
        }
        return maxScore;
    }
}