using System;

class Program
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        GetClosestPodoubleToCenter(x1, y1, x2, y2);
    }

    private static void GetClosestPodoubleToCenter(double x1, double y1, double x2, double y2)
    {
        double firstPoint = 0;
        double secondPoint = 0;
        if (Math.Abs(x1) > Math.Abs(x2) && Math.Abs(y1) > Math.Abs(y2))
        {
            firstPoint = x2;
            secondPoint = y2;
        }
        else
        {
            firstPoint = x1;
            secondPoint = y1;
        }

        Console.WriteLine($"({firstPoint}, {secondPoint})");
    }
}