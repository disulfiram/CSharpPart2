using System;
using System.Collections.Generic;

class AddingIntsUsingArrays
{
    static List<byte> ReadBytes()       //Reads integers from console.
    {
        List<byte> number = new List<byte>();
        int index = 0;

        while (true)
        {
            byte integer;
            string value = Console.ReadLine();
            bool result = byte.TryParse(value, out integer);
            if (result == true && integer < 10)
            {
                number.Add(integer);
                index++;
            }
            else if (value == "")
            {
                return number;
            }
            else
            {
                Console.Write(@"""{0}"" is not a single digit. Try again: ", value);
                value = Console.ReadLine();
            }
        }
    }

    static List<byte> AddNumbers(List<byte> firstNumber, List<byte> secondNumber)
    {
        List<byte> sum = new List<byte>();
        int length;
        byte reminder = 0;
        if (firstNumber.Count > secondNumber.Count)
        {
            length = firstNumber.Count;
        }
        else
        {
            length = secondNumber.Count;
        }
        for (int index = 0; index <= length; index++)
        {
            if (index < length)
            {
                byte sume = (byte)((firstNumber[index] + secondNumber[index] + reminder) % 10);
                sum.Add(sume);
                reminder = (byte)((firstNumber[index] + secondNumber[index] + reminder) / 10);
            }
            else
            {
                byte sume = (byte)(reminder % 10);
                sum.Add(sume);
            }
        }
        return sum;
    }

    static void PrintList(List<byte> sum)
    {
        for (int index = sum.Count - 1; index >= 0; index--)
        {
            Console.Write(sum[index]);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Input is made single digit at a line. Leave empty line to go to next number.");
        Console.WriteLine("Input digits of first number:");
        List<byte> firstNumber = ReadBytes();
        Console.WriteLine("Input digits of second number:");
        List<byte> secondNumber = ReadBytes();
        List<byte> sum = AddNumbers(firstNumber, secondNumber);
        PrintList(sum);
    }
}

