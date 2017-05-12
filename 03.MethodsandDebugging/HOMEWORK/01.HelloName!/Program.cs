using System;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();

        SayHelloName(name);

    }

    private static void SayHelloName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}