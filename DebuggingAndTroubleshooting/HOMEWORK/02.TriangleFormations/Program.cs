using System;

class TriangleFormations
{
    static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        var triangleValidityCondition1 = a + b > c;
        var triangleValidityCondition2 = b + c > a;
        var triangleValidityCondition3 = a + c > b;
        var isValidTriangle = triangleValidityCondition1 && triangleValidityCondition2 && triangleValidityCondition3;

        if (isValidTriangle)
        {
            Console.WriteLine("Triangle is valid.");
        }
        else
        {
            Console.WriteLine("Invalid Triangle.");
            return;
        }

        if (a * a + b * b == c * c)
        {
            Console.WriteLine("Triangle has a right angle between sides a and b");
        }
        else if (b * b + c * c == a * a)
        {
            Console.WriteLine("Triangle has a right angle between sides b and c");
        }
        else if (a * a + c * c == b * b)
        {
            Console.WriteLine("Triangle has a right angle between sides a and c");
        }
        else
        {
            Console.WriteLine("Triangle has no right angles");
        }
    }
}
