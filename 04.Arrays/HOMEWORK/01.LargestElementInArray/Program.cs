using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double[] numbers = new double[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine(numbers.Max());
    }
}