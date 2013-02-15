using System;

class SumSInSequence
{
    static int ReadInts(string Value)                                                                   //Reads integers from console.
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

    private static void PrintOneDimSubArray(int begin, int Length, int[] arr)                          //Prints array
    {
        for (int index = begin; index <= begin + Length; index++)
        {
            Console.Write(arr[index] + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int N = -1;
        while (N <= 0)
        {
            Console.Write("Input size of array: ");
            N = ReadInts(Console.ReadLine());
        }
        Console.Write("Input Target sum: ");
        int S = ReadInts(Console.ReadLine());
        int[] Array = new int[N];
        for (int index = 0; index < Array.Length; index++)
        {
            Console.Write("Input Array[{0}]: ", index);
            Array[index] = ReadInts(Console.ReadLine());
        }
        int sum;
        for (int index = 0; index < Array.Length; index++)
        {
            sum = Array[index];
            for (int i = index+1; i < Array.Length; i++)
            {
                sum += Array[i];
                if (sum > S)
                {
                    break;
                }
                if (sum == S)
                {
                    PrintOneDimSubArray(index, i-index, Array);
                }
            }
        }
    }
}