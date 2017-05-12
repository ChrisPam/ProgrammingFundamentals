using System;

class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());
        Console.WriteLine(RaiseToPower(number, power));
    }

    private static double RaiseToPower(double number, double power)
    {
        double result = Math.Pow(number, power);
        return result;
    }
}