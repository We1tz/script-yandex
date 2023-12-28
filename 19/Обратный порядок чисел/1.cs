using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] scores = Console.ReadLine().Split();

        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(scores[i] + " ");
        }
        Console.WriteLine();
    }
}