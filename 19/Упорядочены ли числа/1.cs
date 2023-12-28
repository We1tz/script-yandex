using System;

class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        string input = Console.ReadLine();
        string[] scores = input.Split(' ');

        if (IsSorted(scores))
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }

    static bool IsSorted(string[] arr)
    {
        bool increasing = true;
        bool decreasing = true;

        for (int i = 1; i < arr.Length; i++)
        {
            int current = int.Parse(arr[i]);
            int previous = int.Parse(arr[i - 1]);

            if (current > previous)
            {
                decreasing = false;
            }
            else if (current < previous)
            {
                increasing = false;
            }
            else
            {
                increasing = decreasing = false;
            }
        }

        return increasing || decreasing;
    }
}