using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a string: ");
        string inputString = Console.ReadLine();
        for (int symbol = (inputString.Length -1); symbol >= 0; symbol--)
        {
            Console.Write(inputString[symbol]);
        }
        Console.WriteLine();
    }
}