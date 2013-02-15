using System;

class ArraySorting
{
    static int ReadInts(string Value)                                               //Reads integers from console.
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

    private static void PrintOneDimArray(int N, int[] arr)                          //Prints array
    {
        for (int index = 0; index < N; index++)
        {
            Console.Write(arr[index] + " ");
        }
    }

    private static int MaxInOneDimArray(int N, int[] Array)                         //Finds max value in array.
    {
        int Max = Array[0];

        for (int i = 0; i < N; i++)
        {
            if (Max < Array[i])
            {
                Max = Array[i];
            }
        }
        return Max;
    }

    private static int MinInOneDimArray(int N, int M, int[] Array)                  //Finds next minimal value
    {
        int Min = M;
        int Max = M;
        int index = 0;

        for (int i = 0; i < N; i++)
        {
            if (Min >= Array[i])
            {
                Min = Array[i];
                index = i;
            }
        }
        Array[index] = Max;
        return Min;
    }

    static void Main(string[] args)
    {
        int N = -1;
        while (N <= 0)
        {
            Console.Write("Input N: ");
            N = ReadInts(Console.ReadLine());
        }
        int[] Array = new int[N];
        for (int index = 0; index < N; index++)
        {
            Console.Write("Input Array[{0}]: ", index);
            Array[index] = ReadInts(Console.ReadLine());
        }
        int[] SortedArray = new int[N];

        int Max = MaxInOneDimArray(N, Array);

        for (int index = 0; index < N; index++)
        {
            SortedArray[index] = MinInOneDimArray(N, Max, Array);
        }
        PrintOneDimArray(N, SortedArray);
    }
}