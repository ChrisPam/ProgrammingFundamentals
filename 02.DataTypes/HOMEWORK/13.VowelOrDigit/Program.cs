using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();

        try
        {
            double number = double.Parse(input);
            Console.WriteLine("digit");
        }
        catch (FormatException)
        {
            if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
        
        
    }
}