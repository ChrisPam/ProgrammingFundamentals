using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine()
            .Split(' ')
            .ToArray();

        int countOfCapitalLetters = 0;
        for (int i = 0; i < words.Length; i++)
        {
            try
            {
                var letter = Convert.ToChar(words[i]);
                if((int)letter >= 65 && (int)letter <= 90)
                {
                    countOfCapitalLetters++;
                }
            }
            catch (Exception)
            {

            }
        }

        Console.WriteLine(countOfCapitalLetters);
    }
}
