using System;


class LastDigit
{
    static int ReadInts(string value)       //Reads integers from console.
    {
        while (true)
        {
            int Integer;
            bool result = int.TryParse(value, out Integer);
            if (result == true)
            {
                return Integer;
            }
            else
            {
                Console.Write(@"""{0}"" is not an integer. Try again: ", value);
                value = Console.ReadLine();
            }
        }
    }

    static string FindDigit(int number)
    {
        int digit = number % 10;
        switch (digit)
        {
            case 0:
                {
                    return "Zero";
                }
            case 1:
                {
                    return "One";
                }
            case 2:
                {
                    return "Two";
                }
            case 3:
                {
                    return "Three";
                }
            case 4:
                {
                    return "Four";
                }
            case 5:
                {
                    return "Five";
                }
            case 6:
                {
                    return "Six";
                }
            case 7:
                {
                    return "Seven";
                }
            case 8:
                {
                    return "Eight";
                }
            case 9:
                {
                    return "Nine";
                }
            default:
                {
                    return "ups";
                }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Input an integer: ");
        int N = ReadInts(Console.ReadLine());
        string DigitName = FindDigit(N);
        Console.WriteLine("Last digit is {0}", DigitName);
    }
}