using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(number.ToString("X"));
        Console.WriteLine(Convert.ToString(number, 2));
    }
}
