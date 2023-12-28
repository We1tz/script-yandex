using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int score = 0;
        int i = 1;

        string oddNumbersString = "";

        do
        {
            score += i;
            oddNumbersString += i.ToString();

            if (i < n && i + 2 <= n)
                oddNumbersString += " + ";

            i += 2;
        } while (i <= n);

        Console.WriteLine($"{score} ({oddNumbersString})");
    }
}