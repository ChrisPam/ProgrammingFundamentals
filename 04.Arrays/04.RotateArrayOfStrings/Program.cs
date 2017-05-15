using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine()
            .Split(' ')
            .ToArray();

        string[] rotatedWords = new string[words.Length];

        rotatedWords[0] = words[words.Length - 1];

        for (int i = 1; i < words.Length; i++)
        {
            rotatedWords[i] = words[i - 1];
        }

        Console.WriteLine(string.Join(" ", rotatedWords));
    }
}