using System;

class TwentySymbolStrings
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a string up to 20 symbols in length:");
        string inputString = null;
        try
        {
            inputString = Console.ReadLine();
            if (inputString.Length > 20)
            {
                throw new ArgumentException("String is longer than 20 symbols.");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        for (int letter = 0; letter < 20; letter++)
        {
            if (letter < inputString.Length)
            {
                Console.Write(inputString[letter]);
            }
            else
            {
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }
}