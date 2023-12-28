using System;

class Program
{
    static void Main()
    {
        int result = 1;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"2^{i} = {result}");
            result *= 2;
        }
    }
}