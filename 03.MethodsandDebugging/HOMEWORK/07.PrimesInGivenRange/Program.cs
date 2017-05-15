using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int startPoint = int.Parse(Console.ReadLine());
        int endPoint = int.Parse(Console.ReadLine());
        Console.WriteLine(string.Join(", ", GetPrimeNumbersInRange(startPoint, endPoint)));
    }

    private static List<int> GetPrimeNumbersInRange(int startPoint, int endPoint)
    {
        List<int> numbers = new List<int>();
        for (int number = startPoint; number <= endPoint; number++)
        {
            numbers.Add(number);
            if (number == 0)
            {
                numbers.Remove(number);
            }
            else if (number == 1)
            {
                numbers.Remove(number);
            }
            else
            {
                
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    var isPrime = true;
                    if (number % i == 0)
                    {
                        isPrime = false;
                        numbers.Remove(number);
                        continue;
                    }
                }
            }
            
        }
        return numbers;
    }
}