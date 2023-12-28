using System;

class Program
{
    static void Main()
    {
        for (int i = 1, power = 2; i <= 10; i++, power *= 2)
        {
            Console.WriteLine($"2^{i} = {power}");
        }
    }
}