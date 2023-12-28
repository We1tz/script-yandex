using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int score = 0;

        var oddNumbers = Enumerable.Range(1, n).Where(x => x % 2 != 0).ToList();
        string oddNumbersString = string.Join(" + ", oddNumbers);

        score = oddNumbers.Sum();

        Console.WriteLine($"{score} ({oddNumbersString})");
    }
}