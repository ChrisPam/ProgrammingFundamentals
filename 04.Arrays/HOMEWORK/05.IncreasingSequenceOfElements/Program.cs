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

        bool isLargeThanPrevious = true;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] < numbers[i + 1] && numbers[numbers.Length - 2] < numbers[numbers.Length - 1])
            {
                
            }
            else
            {
                isLargeThanPrevious = false;
                break;
            }
        }

        if (isLargeThanPrevious)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}