using System;

class Program
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());

        Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
    }
}
