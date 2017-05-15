using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            if(i % 2 == 1)
            {
                if(Math.Abs(numbers[i]) % 2 == 1)
                {
                    Console.WriteLine($"Index {i} -> {numbers[i]}");
                }
            }
        }
    }
}
