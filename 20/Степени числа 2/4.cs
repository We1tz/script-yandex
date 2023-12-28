using System;

class Program
{
    static void Main()
    {
        int power = 2;
		
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"2^{i} = {power}");
            power *= 2;
        }
    }
}