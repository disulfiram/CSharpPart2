using System;

class MaxInSubArray
{
    static int[] ArrayOfInts;

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

    static int FindBiggestInArray(int K = 0)
    {
        int TempIndex = K;
        for (int index = K; index < ArrayOfInts.Length; index++)
        {
            if (ArrayOfInts[TempIndex] < ArrayOfInts[index])
            {
                TempIndex = index;
            }
        }
        return TempIndex;
    }

    static void SortArray()
    {
        int [] StoreArrayOfInts = new int[ArrayOfInts.Length];
        for (int index = 0; index < ArrayOfInts.Length; index++)
		{
            StoreArrayOfInts[index] = ArrayOfInts[index];
		} 
        for (int index = 0; index < ArrayOfInts.Length; index++)
        {
            int temp = ArrayOfInts[index];
            int big = FindBiggestInArray(index);
            ArrayOfInts[index] = ArrayOfInts[big];
            ArrayOfInts[big] = temp;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Input size of array: ");
        int N = ReadInts();
        ArrayOfInts = new int[N];
        for (int index = 0; index < N; index++)
        {
            Console.Write("Input element {0} of the array: ", index);
            ArrayOfInts[index] = ReadInts();
        }
        SortArray();
        for (int index = 0; index < ArrayOfInts.Length; index++)
        {
            Console.Write("{0} ", ArrayOfInts[index]);
        }
    }
}