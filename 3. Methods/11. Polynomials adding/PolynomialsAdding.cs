using System;
using System.Collections.Generic;

class PolynomialsAdding
{
    static List<int> ReadBytes()       //Reads integers from console.
    {
        List<int> number = new List<int>();
        int index = 0;

        while (true)
        {
            int integer;
            Console.Write("x^{0} * ", index);
            string value = Console.ReadLine();
            bool result = int.TryParse(value, out integer);
            if (result == true)
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
                Console.Write(@"""{0}"" is not an integer. Try again: ", value);
                value = Console.ReadLine();
            }
        }
    }

    static List<int> AddNumbers(List<int> firstPolynom, List<int> secondPolynom)
    {
        List<int> sum = new List<int>();
        int lengthBig, lengthLow;
        if (firstPolynom.Count > secondPolynom.Count)
        {
            lengthBig = firstPolynom.Count;
            lengthLow = secondPolynom.Count;
            for (int index = 0; index < lengthBig; index++)
            {
                if (index < lengthLow)
                {
                    int sume = (firstPolynom[index] + secondPolynom[index]);
                    sum.Add(sume);
                }
                if (index >= lengthLow)
                {
                    sum.Add(firstPolynom[index]);
                }
            }
        }
        else
        {
            lengthBig = secondPolynom.Count;
            lengthLow = firstPolynom.Count;
            for (int index = 0; index < lengthBig; index++)
            {
                if (index < lengthLow)
                {
                    int sume = (firstPolynom[index] + secondPolynom[index]);
                    sum.Add(sume);
                }
                if (index >= lengthLow)
                {
                    sum.Add(secondPolynom[index]);
                }
            }
        }

        return sum;
    }

    static void PrintList(List<int> sum)
    {
        for (int index = sum.Count - 1; index >= 0; index--)
        {
            if (index == 0)
            {
                Console.Write("{0}*x^{1} = ?", sum[index], index);
            }
            else
            {
                Console.Write("{0}*x^{1} + ", sum[index], index);
            }
                
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Input is made single digit at a line. Leave empty line to go to next number.");
        Console.WriteLine("Input first polynom:");
        List<int> polynom1 = ReadBytes();
        Console.WriteLine("Input second polynom:");
        List<int> polynom2 = ReadBytes();
        List<int> sum = AddNumbers(polynom1, polynom2);
        PrintList(sum);
    }
}