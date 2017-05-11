using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int number = i;

            int sumOfDigits = 0;
            while (number > 0)
            {
                sumOfDigits += number % 10;

                number /= 10;
            }

            if (sumOfDigits == 5 || sumOfDigits == 7 | sumOfDigits == 11)
            {
                Console.WriteLine("{0} -> True", i);
            }
            else
            {
                Console.WriteLine("{0} -> False", i);
            }
        }
    }
}
