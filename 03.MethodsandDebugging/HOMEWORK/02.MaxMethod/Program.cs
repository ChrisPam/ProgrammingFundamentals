using System;

class Program
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine(GetMaxNumber(firstNumber, secondNumber, thirdNumber));
    }

    private static double GetMaxNumber(double firstNumber, double secondNumber, double thirdNumber)
    {
        double firstMax = Math.Max(firstNumber, secondNumber);
        double secondMax = Math.Max(firstMax, thirdNumber);
        return secondMax;
    }
}