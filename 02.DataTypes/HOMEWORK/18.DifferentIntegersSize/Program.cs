using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        var count = 0;
        string firstType = "";
        string secondType = "";
        string thirdType = "";
        string forthType = "";
        string fifthType = "";
        string sixthType = "";
        string seventhType = "";
        try
        {
            sbyte.Parse(input);
            firstType = "* sbyte\n";
            count++;
        }
        catch (OverflowException) { }
        try
        {
            byte.Parse(input);
            secondType = "* byte\n";
            count++;
        }
        catch (OverflowException) { }
        try
        {
            short.Parse(input);
            thirdType = "* short\n";
            count++;
        }
        catch (OverflowException) { }
        try
        {
            ushort.Parse(input);
            forthType = "* ushort\n";
            count++;
        }
        catch (OverflowException) { }
        try
        {
            int.Parse(input);
            fifthType = "* int\n";
            count++;
        }
        catch (OverflowException) { }
        try
        {
            uint.Parse(input);
            sixthType = "* uint\n";
            count++;
        }
        catch (OverflowException) { }
        try
        {
            long.Parse(input);
            seventhType = "* long\n";
            count++;
        }
        catch (OverflowException) { }
        string result = $"\n{firstType}{secondType}{thirdType}{forthType}{fifthType}{sixthType}{seventhType}";
        if (count > 0)
        {
            Console.WriteLine($"{input} can fit in: {result}");
        }
        else if (count == 0)
        {
            Console.WriteLine($"{input} can't fit in any type");
        }
    }
}