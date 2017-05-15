using System;

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

        var countOfNegativeNumbers = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] < 0)
            {
                countOfNegativeNumbers++;
            }
        }

        Console.WriteLine(countOfNegativeNumbers);
    }
}