using System;

class Program
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        for (int num = 2; num <= inputNumber; num++)
        {
            bool isPrime = true;
            for (int delimiter = 2; delimiter <= Math.Sqrt(num); delimiter++)
            {
                if (num % delimiter == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{num} -> {isPrime}");
        }

    }
}
