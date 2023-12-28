using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] scores = Console.ReadLine().Split();
        int target = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (int.Parse(scores[i]) == target)
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine("Число не найдено");
    }
}
