using System;


class LastDigit
{
    static int ReadInts(string value)       //Reads integers from console.
    {
        while (true)
        {
            int integer;
            bool result = int.TryParse(value, out integer);
            if (result == true)
            {
                return integer;
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
        int numberN = ReadInts(Console.ReadLine());
        string digitName = FindDigit(numberN);
        Console.WriteLine("Last digit is {0}", digitName);
    }
}