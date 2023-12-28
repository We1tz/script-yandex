using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] scores = Console.ReadLine().Split();

        int j = n - 1;
        while (j >= 0)
        {
            Console.Write(scores[j] + " ");
            j--;
        }
        Console.WriteLine();
    }
}