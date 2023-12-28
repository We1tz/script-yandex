using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = SumRec(n);
        Console.WriteLine(sum);
    }

    static int SumRec(int num)
    {
        return num == 0 ? 0 : num + SumRec(num - 1);
    }
}