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

    static bool CheckIfGrater(int K, int[] ArrayOfInts)
    {
        bool Bigger = false;
        if (K == 0)
        {
            if (ArrayOfInts[0] > ArrayOfInts[K + 1])
            {
                Bigger = true;
                return Bigger;
            }
        }
        if (K == ArrayOfInts.Length - 1)
        {
            if (ArrayOfInts[K] > ArrayOfInts[K - 1])
            {
                Bigger = true;
                return Bigger;
            }
        }
        else
        {
            if (ArrayOfInts[K] > ArrayOfInts[K + 1] && ArrayOfInts[K] > ArrayOfInts[K - 1])
            {
                Bigger = true;
                return Bigger;
            }
        }
        return Bigger;
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
        int IndexOfInteger = -1;
        for (int index = 0; index < N; index++)
        {
            bool IsBigger = CheckIfGrater(index, ArrayOfInts);
            if (IsBigger == true)
            {
                IndexOfInteger = index;
                break;
            }
        }
        if (IndexOfInteger > -1)
        {
            Console.WriteLine("{0} is the first in the array grater than it's neighbours.", ArrayOfInts[IndexOfInteger]);
        }
        else
        {
            Console.WriteLine("There is no such integer in the array, that is grater than it's neighbours.");
        }
    }
}