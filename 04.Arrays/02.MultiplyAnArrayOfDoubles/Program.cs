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

        double p = double.Parse(Console.ReadLine());

        double[] multipliedNumbers = new double[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            multipliedNumbers[i] = numbers[i] * p;
        }

        Console.WriteLine(string.Join(" ", multipliedNumbers));
        
    }
}