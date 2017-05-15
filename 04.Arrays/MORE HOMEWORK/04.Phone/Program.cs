using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
        string[] names = Console.ReadLine().Split(' ').ToArray();
        string[] input = Console.ReadLine().Split(' ').ToArray();

        while (input[0] != "done")
        {
            if (input[0] == "call")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    int sumDigitNumbers = GetPhomeNumbersSum(phoneNumbers, i);
                    string answer = MessageForSeconds(sumDigitNumbers);
                    if (input[1] == names[i])
                    {
                        Console.WriteLine($"calling {phoneNumbers[i]}...");
                        PrintMessageForCall(sumDigitNumbers, answer);
                    }
                    else if (input[1] == phoneNumbers[i])
                    {
                        Console.WriteLine($"calling {names[i]}...");
                        PrintMessageForCall(sumDigitNumbers, answer);
                    }
                }
            }
            else if (input[0] == "message")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    int sumDigitNumbers = GetPhomeNumbersSum(phoneNumbers, i);
                    if (input[1] == names[i])
                    {     
                        Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                        PrintMessageForSMS(sumDigitNumbers);
                    }
                    else if(input[1] == phoneNumbers[i])
                    {
                        Console.WriteLine($"sending sms to {names[i]}...");
                        PrintMessageForSMS(sumDigitNumbers);
                    }
                }
            }

            input = Console.ReadLine()
                .Split(' ')
                .ToArray();
        }
    }

    private static void PrintMessageForSMS(int sumDigitNumbers)
    {
        if(sumDigitNumbers % 2 == 0)
        {
            Console.WriteLine("meet me there");
        }
        else
        {
            Console.WriteLine("busy");
        }
    }

    private static string MessageForSeconds(int sumDigitNumbers)
    {
        TimeSpan t = TimeSpan.FromSeconds(sumDigitNumbers);
        string answer = string.Format("{0:D2}:{1:D2}",t.Minutes,t.Seconds);

        return answer;
    }

    private static int GetPhomeNumbersSum(string[] phoneNumbers, int i)
    {
        char[] phoneNumber = phoneNumbers[i].ToCharArray();
        var sumDigitNumbers = SumDigitNumbers(phoneNumber);

        return sumDigitNumbers;
    }

    private static void PrintMessageForCall(int sumDigitNumbers, string answer)
    {
        if (sumDigitNumbers % 2 == 0)
        {
            Console.WriteLine($"call ended. duration: {answer}");
        }
        else
        {
            Console.WriteLine("no answer");
        }
    }

    private static int SumDigitNumbers(char[] phoneNumber)
    {
        int sum = 0;
        for (int i = 0; i < phoneNumber.Length; i++)
        {
            if (phoneNumber[i] - '0' >= 0 && phoneNumber[i] - '0' <= 9)
            {
                sum += phoneNumber[i] - '0';
            }
        }

        return sum;
    }
}