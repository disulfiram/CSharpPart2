//I could just copy the solution I made for 7 over all other solutions but I decided to keep them to show the progress I made while doing the homework.
using System;

class DecToBin
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

    private static void TransformedNumber(int Number)
    {
        byte[] BinArray = new byte[32];
        if (Number>=0)
        {
            BinArray[31] = 0;
            for (int bit = 0; bit < BinArray.Length-1; bit++)
            {
                BinArray[bit] = (byte)(Number % 2);
                Number /= 2;
            }
        }
        if (Number<0)
        {
            BinArray[31] = 1;
            Number = Int32.MaxValue + Number+1;
            for (int bit = 0; bit < BinArray.Length-1; bit++)
            {
                BinArray[bit] = (byte)(Number % 2);
                Number /= 2;
            }
        }
        PrintArray(BinArray);
    }

    private static void PrintArray(byte[] BinArray)
    {
        for (int bit = 31; bit >= 0; bit--)
        {
            Console.Write(BinArray[bit]);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Input positive or negative integer: ");
        int Number = ReadInts();
        TransformedNumber(Number);
    }
}