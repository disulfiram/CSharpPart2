using System;

class Reverse
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

    static void PrintReversedInts(int numberN)
    {
        Console.Write("The reversed number is: ");
        while (numberN != 0)
        {
            Console.Write(numberN % 10);
            numberN /= 10;
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Input integer: ");
        int numberN = ReadInts(Console.ReadLine());
        PrintReversedInts(numberN);
    }
}