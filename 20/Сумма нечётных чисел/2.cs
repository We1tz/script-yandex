using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int score = 0;
        int i = 1;

        string oddNumbersString = "";

        while (i <= n)
        {
            score += i;
            oddNumbersString += i.ToString();

            if (i < n && i + 2 <= n)
                oddNumbersString += " + ";

            i += 2;
        }

        Console.WriteLine($"{score} ({oddNumbersString})");
    }
}