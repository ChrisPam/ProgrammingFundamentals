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
        double countSpecialNumbers = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if(specialNumber == numbers[i])
            {
                countSpecialNumbers++;
            }
        }

        Console.WriteLine(countSpecialNumbers);
    }
}
