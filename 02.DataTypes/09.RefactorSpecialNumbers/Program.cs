using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumOfDigits = 0;
        int number = 0;
        bool isSpecial = false;
        for (int i = 1; i <= n; i++)
        {
            number = i;
            while (i > 0)
            {
                sumOfDigits += i % 10;
                i = i / 10;
            }
            isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
            Console.WriteLine($"{number} -> {isSpecial}");
            sumOfDigits = 0;
            i = number;
        }

    }
}