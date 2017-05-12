using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintHeaderRow(n);
        PrintBody(n);
        PrintHeaderRow(n);
    }
    static void PrintHeaderRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }
    static void PrintBody(int n)
    {
        for (int i = 1; i <= n - 2; i++)
        {
            Console.Write("-");
            for (int j = 1; j <= n - 1; j++)
            {
                Console.Write(@"\/");
            }
            Console.WriteLine("-");
        }
        
    }
}
