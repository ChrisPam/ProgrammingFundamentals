using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double significance = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());
            double diff = CalculateDiff(firstPrice, price);
            bool isSignificantDifference = isDiff(diff, significance);
            string message = GetMessage(price, firstPrice, diff, isSignificantDifference);
            Console.WriteLine(message);
            firstPrice = price;
        }
    }

    private static string GetMessage(double price, double firstPrice, double difference, bool isSignificantDifference)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", price);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, price, difference * 100);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, price, difference * 100);
        }
        else if (isSignificantDifference && (difference < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, price, difference * 100);
        return message;
    }
    private static bool isDiff(double significance, double isDiff)
    {
        if (Math.Abs(significance) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double CalculateDiff(double firstPrice, double price)
    {
        double result = (price - firstPrice) / firstPrice;
        return result;
    }
}
