using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMultipleOfEvensAndOdds(number));
    }

    private static int GetMultipleOfEvensAndOdds(int number)
    {
        int sumEvens = GetSumOfEvenDigits(number);
        int sumOdds = GetSumOfOddDigits(number);
        return sumEvens * sumOdds;
    }

    private static int GetSumOfOddDigits(int number)
    {
        number = Math.Abs(number);
        int sum = 0;
        while (number > 0)
        {
            var digit = number % 10;
            if(digit % 2 == 1)
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }

    private static int GetSumOfEvenDigits(int number)
    {
        number = Math.Abs(number);
        int sum = 0;
        while (number > 0)
        {
            var digit = number % 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }
}