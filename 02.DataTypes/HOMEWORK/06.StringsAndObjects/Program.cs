using System;

class Program
{
    static void Main()
    {
        string firstValue = "Hello";
        string secondValue = "World";

        object result = firstValue + " " + secondValue;

        Console.WriteLine((string)result);
    }
}
