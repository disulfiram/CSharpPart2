using System;

class StringToUnicode
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input string: ");
        string inputString = Console.ReadLine();
        char[] unicodeArray = new char[inputString.Length];
        for (int symbol = 0; symbol < inputString.Length; symbol++)
        {
            unicodeArray[symbol] = inputString[symbol];
            Console.Write("\\u{0:x4}",(int)unicodeArray[symbol]);
        }
    }
}