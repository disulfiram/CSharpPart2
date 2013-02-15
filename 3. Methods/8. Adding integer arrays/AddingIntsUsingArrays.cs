using System;
using System.Collections.Generic;

class AddingIntsUsingArrays
{
    static List<byte> ReadBytes()       //Reads integers from console.
    {
        List<byte> Number = new List<byte>();
        int index = 0;

        while (true)
        {
            byte Integer;
            string Value = Console.ReadLine();
            bool Result = byte.TryParse(Value, out Integer);
            if (Result == true && Integer < 10)
            {
                Number.Add(Integer);
                index++;
            }
            else if (Value == "")
            {
                return Number;
            }
            else
            {
                Console.Write(@"""{0}"" is not a single digit. Try again: ", Value);
                Value = Console.ReadLine();
            }
        }
    }

    static List<byte> AddNumbers(List<byte> FirstNumber, List<byte> SecondNumber)
    {
        List<byte> Sum = new List<byte>();
        int length;
        byte reminder = 0;
        if (FirstNumber.Count > SecondNumber.Count)
        {
            length = FirstNumber.Count;
        }
        else
        {
            length = SecondNumber.Count;
        }
        for (int index = 0; index <= length; index++)
        {
            if (index < length)
            {
                byte Sume = (byte)((FirstNumber[index] + SecondNumber[index] + reminder) % 10);
                Sum.Add(Sume);
                reminder = (byte)((FirstNumber[index] + SecondNumber[index] + reminder) / 10);
            }
            else
            {
                byte Sume = (byte)(reminder % 10);
                Sum.Add(Sume);
            }
        }
        return Sum;
    }

    static void PrintList(List<byte> Sum)
    {
        for (int index = Sum.Count - 1; index >= 0; index--)
        {
            Console.Write(Sum[index]);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Input is made single digit at a line. Leave empty line to go to next number.");
        Console.WriteLine("Input digits of first number:");
        List<byte> FirstNumber = ReadBytes();
        Console.WriteLine("Input digits of second number:");
        List<byte> SecondNumber = ReadBytes();
        List<byte> Sum = AddNumbers(FirstNumber, SecondNumber);
        PrintList(Sum);
    }
}

