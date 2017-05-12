using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double firstNumber = double.Parse(Console.ReadLine());

        for (int i = 0; i < numbers - 1; i++)
        {
            double number = double.Parse(Console.ReadLine());
            double diff = Diff(firstNumber, number);
            bool isSignificantDifference = hasDiff(diff, threshold);

            string message = Get(number, firstNumber, diff, isSignificantDifference);
            Console.WriteLine(message);

            firstNumber = number;
        }
    }

    private static string Get(double number, double firstNumber, double difference, bool etherTrueOrFalse)
    {
        string result = "";
        if (difference == 0)
        {
            result = string.Format("NO CHANGE: {0}", number);
        }
        else if (!etherTrueOrFalse)
        {
            result = string.Format("MINOR CHANGE: {0} result {1} ({2:F2}%)", firstNumber, number, difference);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            result = string.Format("PRICE UP: {0} result {1} ({2:F2}%)", firstNumber, number, difference);
        }
        else if (etherTrueOrFalse && (difference < 0))
            result = string.Format("PRICE DOWN: {0} result {1} ({2:F2}%)", firstNumber, number, difference);
        return result;
    }
    private static bool hasDiff(double threshold, double isDiff)
    {
        if (Math.Abs(threshold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Diff(double firstNumber, double number)
    {
        double result = (number - firstNumber) / firstNumber;
        return result;
    }
}
