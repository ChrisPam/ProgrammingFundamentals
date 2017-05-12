using System;

class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = CalculateTriangleArea(width, height);
        Console.WriteLine(area);
    }

    private static double CalculateTriangleArea(double width, double height)
    {
        double area = (width * height) / 2;

        return area;
    }
}
