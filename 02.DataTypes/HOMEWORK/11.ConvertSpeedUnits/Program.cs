using System;

class Program
{
    static void Main()
    {
        float distance = int.Parse(Console.ReadLine());
        float hours = int.Parse(Console.ReadLine());
        float minutes = int.Parse(Console.ReadLine());
        float seconds = int.Parse(Console.ReadLine());

        float totalTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;
        float metersPerSeconds = distance / totalTimeInSeconds;
        Console.WriteLine("{0:0.#######}", metersPerSeconds);

        float totalTimeInHours = (hours + (minutes / 60) + (seconds / 3600));
        float kilometersPerHour = (distance / 1000) / totalTimeInHours;
        Console.WriteLine("{0:0.#######}", kilometersPerHour);

        float milesPerHour = (distance / 1609) / totalTimeInHours;

        Console.WriteLine("{0:0.#######}", milesPerHour);

    }
}
