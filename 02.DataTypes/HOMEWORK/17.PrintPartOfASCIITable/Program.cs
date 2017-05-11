using System;

class Program
{
    static void Main()
    {
        int indexStart = int.Parse(Console.ReadLine());
        int indexEnd = int.Parse(Console.ReadLine());

        for (int i = indexStart; i <= indexEnd; i++)
        {
            Console.Write($"{Convert.ToChar(i)} ");
        }
    }
}
