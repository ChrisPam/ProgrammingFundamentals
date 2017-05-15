using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] coordinates = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        double coordinateX = coordinates[0];
        double coordinateY = coordinates[1];


        string[] commands = Console.ReadLine()
            .Split(' ')
            .ToArray();

        double coordinateToShootX = 0;
        double coordinateToShootY = 0;


        for (int i = 0; i < commands.Length; i += 2)
        {
            if (commands[i].ToLower() == "up")
            {
                coordinateToShootY += double.Parse(commands[i + 1]);
            }
            else if (commands[i].ToLower() == "down")
            {
                coordinateToShootY -= double.Parse(commands[i + 1]);
            }
            else if (commands[i].ToLower() == "left")
            {
                coordinateToShootX -= double.Parse(commands[i + 1]);
            }
            else if (commands[i].ToLower() == "right")
            {
                coordinateToShootX += double.Parse(commands[i + 1]);
            }
        }

        Console.WriteLine($"firing at [{coordinateToShootX}, {coordinateToShootY}]");
        if (coordinateToShootX == coordinateX && coordinateToShootY == coordinateY)
        {
            Console.WriteLine("got 'em!");
        }
        else
        {
            Console.WriteLine("better luck next time...");
        }
    }
}