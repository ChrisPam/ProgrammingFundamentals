using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        bool trueOrFalse = Convert.ToBoolean(input);

        string result = "";
        result = trueOrFalse ? "Yes" : "No";

        Console.WriteLine(result);
    }
}
