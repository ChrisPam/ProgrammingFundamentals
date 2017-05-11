using System;

class Program
{
    static void Main()
    {
        sbyte centuries = sbyte.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        decimal minutes = hours * 60;
        decimal seconds = minutes * 60;
        decimal miliseconds = seconds * 1000;
        decimal microseconds = miliseconds * 1000;
        decimal nanoseconds = microseconds * 1000;
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}
