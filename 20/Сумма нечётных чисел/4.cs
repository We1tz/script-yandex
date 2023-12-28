using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int score = 0;

        string oddNumbersString = "";

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                score += i;
                oddNumbersString += i.ToString();

                if (i < n && i + 2 <= n)
                    oddNumbersString += " + ";
            }
        }

        Console.WriteLine($"{score} ({oddNumbersString})");
    }
}