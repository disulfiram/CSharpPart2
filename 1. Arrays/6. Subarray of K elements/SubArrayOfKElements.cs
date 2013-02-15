using System;

class SubArrayOfKElements
{
    static int ReadInts(string Value)
    {
        while (true)                                                                //Will ask until successful parse
        {                                               
            int Integer;
            bool Result = int.TryParse(Value, out Integer);
            if (Result == true)
            {
                return Integer;
            }
            else
            {
                Console.Write(@"""{0}"" is not an integer. Try again: ",Value);
                Value = Console.ReadLine();
            }
        }
    }

    private static int MinInOneDimArray(int[] Array)                                //Finds min value in array.
    {
        int Min = Array[0];

        for (int i = 0; i < Array.Length; i++)
        {
            if (Min > Array[i])
            {
                Min = Array[i];
            }
        }
        return Min;
    }

    private static int MaxInOneDimArray(int ArrayMin, int[] Array)                  //Finds next Max value
    {
        int Max = ArrayMin;
        int Min = ArrayMin;
        int index = 0;

        for (int i = 0; i < Array.Length; i++)
        {
            if (Max <= Array[i])
            {
                Max = Array[i];
                index = i;
            }
        }
        Array[index] = Min;
        return Max;
    }

    private static void PrintOneDimArray(int[] Array)                               //Prints array
    {
        for (int index = 0; index < Array.Length; index++)
        {
            Console.Write(Array[index] + " ");
        }
    }

    static void Main()
    {
        int N = -1;
        while (N<=0)
        {
            Console.Write("Input N: ");
             N = ReadInts(Console.ReadLine());
        }
        int K = -1;
        while (K>N || K<0)
        {
            Console.Write("Input K: ");
            K = ReadInts(Console.ReadLine());
        }
        int[] Array = new int[N];
        for (int index = 0; index < N; index++)
        {
            Console.Write("Input Array[{0}]: ",index);
            Array[index] = ReadInts(Console.ReadLine());
        }
        
        int Min = MinInOneDimArray(Array);
        int[] MaxSubArr = new int[K];
        for (int index = 0; index < K; index++)
        {
            MaxSubArr[index] = MaxInOneDimArray(Min, Array);
        }
        int Sum = 0;
        foreach (var Number in MaxSubArr)
        {
            Sum += Number;
        }
        Console.Write("Greatest sub array is: ");
        PrintOneDimArray(MaxSubArr);
        Console.WriteLine();
        Console.WriteLine("The sum of it's elements is: {0}",Sum);
    }
}