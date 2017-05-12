using System;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        string reversedNumber = ReversedNumber(number);
        Console.WriteLine(reversedNumber);

    }

    private static string ReversedNumber(string number)
    {
        char[] numbers = number.ToCharArray();
        char[] reversedNumber = new char[number.Length];

        int position = 0;
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            reversedNumber[position] = numbers[i];
            position++;
        }

        return new string(reversedNumber);
    }
}