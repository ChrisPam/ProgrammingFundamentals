using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine()
           .Split(' ')
           .ToArray();

        string[] reversedWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            reversedWords[i] = words[words.Length - 1 - i];
        }

        var isSymmetry = true;

        for (int i = 0; i < words.Length; i++)
        {
            if(reversedWords[i] == words[i])
            {

            }
            else
            {
                isSymmetry = false;
                break;
            }
        }

        if (isSymmetry)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }


    }
}
