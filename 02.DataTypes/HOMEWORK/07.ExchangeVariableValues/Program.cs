using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);
        int c = b;
        b = a;

        Console.WriteLine("After:\na = {0}\nb = {1}", c, b);
    }
}
