using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 'a'; i < 'a' + n; i++)
        {
            for (int j = 'a'; j < 'a' + n; j++)
            {
                for (int k = 'a'; k < 'a' + n; k++)
                {
                    Console.WriteLine("{0}{1}{2}", (char)i, (char)j, (char)k);
                }
            }
        }
    }
}
