using System;

class FirstBigger
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

    static int CheckIfGrater(int[] ArrayOfInts)
    {
        for (int index = 0; index < ArrayOfInts.Length; index++)
        {
            if (index == 0)
            {
                if (ArrayOfInts[index] > ArrayOfInts[index + 1])
                {
                    return index;
                }
            }
            if (index == ArrayOfInts.Length - 1)
            {
                if (ArrayOfInts[index] > ArrayOfInts[index - 1])
                {
                    return index;
                }
            }
            else
            {
                if (ArrayOfInts[index] > ArrayOfInts[index + 1] && ArrayOfInts[index] > ArrayOfInts[index - 1])
                {
                    return index;
                }
            }
        }
        return -1;
    }

    static void Main(string[] args)
    {
        Console.Write("Input size of array: ");
        int N = ReadInts(Console.ReadLine());
        int[] ArrayOfInts = new int[N];
        for (int index = 0; index < N; index++)
        {
            Console.Write("Input element {0}: ", index);
            ArrayOfInts[index] = ReadInts(Console.ReadLine());
        }
        int IndexOfInteger = CheckIfGrater(ArrayOfInts);
        if (IndexOfInteger >-1)
        {
            Console.WriteLine("{0} is the first in the array grater than it's neighbours.", ArrayOfInts[IndexOfInteger]);
        }
        else
        {
            Console.WriteLine("There is no such integer in the array, that is grater than it's neighbours.");
        }
    }
}