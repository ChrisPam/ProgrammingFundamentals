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

        double specialNumber = double.Parse(Console.ReadLine());
        double countBiggerThanSpecial = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= specialNumber)
            {
                countBiggerThanSpecial++;
            }
        }

        Console.WriteLine(countBiggerThanSpecial);
    }
}