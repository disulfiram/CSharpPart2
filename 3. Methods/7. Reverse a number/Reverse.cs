using System;

class Reverse
{
    static int ReadInts(string Value)       //Reads integers from console.
    {
        while (true)
        {
            int Integer;
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

    static void PrintReversedInts(int N)
    {
        Console.Write("The reversed number is: ");
        while (N != 0)
        {
            Console.Write(N % 10);
            N /= 10;
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Input integer: ");
        int N = ReadInts(Console.ReadLine());
        PrintReversedInts(N);
    }
}