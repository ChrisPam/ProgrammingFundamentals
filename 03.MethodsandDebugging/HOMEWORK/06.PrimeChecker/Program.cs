using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine(isPrime(n));
    }

    static bool isPrime(long n)
    {
        switch (n)
        {
            case 0:
                return false;
            case 1:
                return false;
            default:
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if(n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
        }
    }

}