using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        List<double> numbersEqualToIndex = new List<double>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if(i == numbers[i])
            {
                numbersEqualToIndex.Add(numbers[i]);
            }

        }

        Console.WriteLine(string.Join(" ", numbersEqualToIndex));
    }
}