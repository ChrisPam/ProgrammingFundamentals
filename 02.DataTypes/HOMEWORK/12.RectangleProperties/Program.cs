using System;

class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * width + 2 * height;
        double area = width * height;
        double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);
    }
}
