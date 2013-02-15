using System;

class ConsecutiveLetters
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input string: ");
        string inputString = Console.ReadLine();
        for (int symbol = 0; symbol < inputString.Length; symbol++)
        {
            if (symbol == inputString.Length-1)
            {
                Console.WriteLine(inputString[symbol]);
                break;
            }
            while (inputString[symbol] == inputString[symbol + 1])
            {
                symbol++;
                if (symbol == inputString.Length-1)
                {
                    break;
                }
            }
            Console.Write(inputString[symbol]);
        }
        Console.WriteLine();
    }
}