using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .Split(' ')
            .ToArray();

        double meters = double.Parse(input[0]);

        for (int i = 1; i < input.Length; i+=2)
        {
            if(input[i].ToLower() == "up")
            {
                meters += double.Parse(input[i + 1]);
            }
            else if(input[i].ToLower() == "down")
            {
                meters -= double.Parse(input[i + 1]);
            }
        }

        if(meters <= 0)
        {
            Console.WriteLine("crashed");
        }
        else
        {
            Console.WriteLine($"got through safely. current altitude: {meters}m");
        }
    }
}