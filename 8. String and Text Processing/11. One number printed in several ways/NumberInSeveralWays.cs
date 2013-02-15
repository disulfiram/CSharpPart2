using System;

class NumberInSeveralWays
{
    static int ReadInts()       //Reads integers from console.
    {
        while (true)
        {
            int Integer;
            string Value = Console.ReadLine();
            bool Result = int.TryParse(Value, out Integer);
            if (Result == true)
            {
                return Integer;
            }
            else
            {
                Console.Write(@"""{0}"" is not an integer. Try again: ", Value);
                Value = Console.ReadLine();
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Input number: ");
        int number = ReadInts();
        Console.WriteLine("{0,15} - The number in decimal.", number);
        Console.WriteLine("{0,15:X4} - The number in hexadecimal.", number);
        Console.WriteLine("{0,15:P} - The number as percentage.", number);
        Console.WriteLine("{0,15:E} - The number in scientific notation.", number);
    }
}