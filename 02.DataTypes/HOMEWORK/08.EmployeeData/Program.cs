using System;

class Program
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        sbyte age = sbyte.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        long personalID = long.Parse(Console.ReadLine());
        int employeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Personal ID: {personalID}");
        Console.WriteLine($"Unique Employee number: {employeeNumber}");

    }
}
