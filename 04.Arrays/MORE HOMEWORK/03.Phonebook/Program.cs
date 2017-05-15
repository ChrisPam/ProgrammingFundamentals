using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] phoneNumbers = Console.ReadLine()
            .Split(' ')
            .ToArray();

        string[] names = Console.ReadLine()
            .Split(' ')
            .ToArray();

        string input = Console.ReadLine();

        while (input != "done")
        {
            int position = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if(names[i].ToLower() == input.ToLower())
                {
                    position = i;
                }
            }

            Console.WriteLine($"{names[position]} -> {phoneNumbers[position]}");

            input = Console.ReadLine();
        }


    }
}