using System;
using System.Collections.Generic;

class FromAnyToAny
{
    static byte From = 0;
    static byte to = 0;

    static string[] Digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

    private static List<string> StoreStringInArra(string InitialNumber)
    {
        List<string> NumberInStrings = new List<string>(InitialNumber.Length);
        for (int position = 0; position < InitialNumber.Length; position++)
        {
            string NumberString = InitialNumber[InitialNumber.Length - position - 1].ToString();
            NumberInStrings.Add(NumberString);
        }
        return NumberInStrings;
    }

    private static byte[] ConvertToDigits(List<string> NumberInArrayOfStrings)
    {
        byte[] ArrayOfDigits = new byte[NumberInArrayOfStrings.Count];
        for (int position = 0; position < NumberInArrayOfStrings.Count; position++)
        {
            ArrayOfDigits[position] = (byte)Array.BinarySearch(Digits, NumberInArrayOfStrings[position]);
            //Console.WriteLine("Position {0} - {1} value", position, ArrayOfDigits[position]); //used this to check results of the method
        }
        return ArrayOfDigits;
    }

    static int ConvertToDecimal(byte[] ArrayOfDigits)
    {
        int Number = 0;
        for (int position = 0; position < ArrayOfDigits.Length; position++)
        {
            Number += ArrayOfDigits[position] * (int)Math.Pow(From, position);
        }
        Console.WriteLine("Number in decimal is: {0}", Number);
        return Number;
    }

    private static byte[] ConvertDecimal(int DecNumber)
    {
        byte[] BinArray = new byte[32];
        BinArray[31] = 0;
        for (int bit = 0; bit < BinArray.Length - 1; bit++)
        {
            BinArray[bit] = (byte)(DecNumber % to);
            DecNumber /= to;
        }
        return BinArray;
    }

    private static void PrintConverted(byte[] ConvertedArray)
    {
        int beginning = 0;
        for (int position = ConvertedArray.Length-1; position >=0; position--)
        {
            if (ConvertedArray[position]!=0)
            {
                beginning = position;
                break;
            }
        }
        for (int position = beginning; position >= 0; position--)
        {
            Console.Write(Digits[ConvertedArray[position]]);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Input the numeral system to convert from: ");
        while (From <1)
        {
            byte.TryParse(Console.ReadLine(), out From);
        }
        Console.Write("Input the numeral system to convert to:");
        while (to<1)
        {
            byte.TryParse(Console.ReadLine(), out to);
        }
        Console.WriteLine("Input input number to convert: ");
        string InitialNumber = Console.ReadLine();
        List<string> NumberInArrayOfStrings = StoreStringInArra(InitialNumber);
        byte[] ArrayOfDigits = ConvertToDigits(NumberInArrayOfStrings);
        int DecNumber = ConvertToDecimal(ArrayOfDigits);
        byte[] ConvertedArray = ConvertDecimal(DecNumber);
        PrintConverted(ConvertedArray);
    }
}