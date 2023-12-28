using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] scores = Console.ReadLine().Split();
        int target = int.Parse(Console.ReadLine());

        int index = Array.FindIndex(scores, s => int.Parse(s) == target);

        if (index != -1)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("Число не найдено");
        }
    }
}