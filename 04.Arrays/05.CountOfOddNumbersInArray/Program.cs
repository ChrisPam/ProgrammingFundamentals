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

        

        Console.WriteLine(GetCountOfOddNumbers(numbers));
    }

    private static int GetCountOfOddNumbers(double[] numbers)
    {
        var oddNumbers = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (Math.Abs(numbers[i]) % 2 == 1)
            {
                oddNumbers++;
            }
        }
        return oddNumbers;
    }
}