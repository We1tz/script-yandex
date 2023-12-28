using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = n * (n + 1) / 2;
        Console.WriteLine(sum);
    }
}