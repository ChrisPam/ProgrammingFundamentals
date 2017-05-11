using System;

class Program
{
    static void Main()
    {
        string hexdecimalNumber = Console.ReadLine();

        decimal decimalNumber = Convert.ToInt32(hexdecimalNumber, 16);

        Console.WriteLine(decimalNumber);
    }
}
