using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine()
            .Split(' ')
            .ToArray();

        var equalWord = "";

        for (int i = 0; i < words.Length - 3; i++)
        {
            if(words[i].ToLower() == words[i + 1].ToLower() && words[i + 1].ToLower() == words[i + 2].ToLower())
            {
                equalWord = words[i];
            }
        }

        var wordsLength = words.Length - 1;

        if(words[wordsLength].ToLower() == words[wordsLength - 1].ToLower() && words[wordsLength].ToLower() == words[wordsLength - 2].ToLower())
        {
            equalWord = words[wordsLength];
        }

        Console.WriteLine($"{equalWord} {equalWord} {equalWord}");
    }
}
