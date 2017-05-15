using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        long fibonacci = Fib(n);
        Console.WriteLine(fibonacci);
    }

    private static long Fib(long n)
    {
        long fibFirst = 1;
        long fibNext = 1;
        long fiblongeration = 0;

        long fibSum = 0;
        if (n == 1 || n == 0)
        {
            return 1;
        }
        while (fiblongeration < n - 1)
        {
            fibSum = fibFirst + fibNext;
            fibFirst = fibNext;
            fibNext = fibSum;
            fiblongeration++;
        }

        return fibSum;
    }
}