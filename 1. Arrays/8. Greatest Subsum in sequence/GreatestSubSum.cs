using System;

class GreatestSubSum
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

    private static void PrintOneDimSubArray(int index1, int Length, int[] arr)                          //Prints array
    {
        for (int index = index1; index < index1+Length; index++)
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
        int K = -1;
        while (K <= 0 || K > N)
        {
            Console.Write("Input size of sub-array: ");
            K = ReadInts(Console.ReadLine());
        }
        int[] Array = new int[N];
        for (int index = 0; index < Array.Length; index++)
        {
            Console.Write("Input Array[{0}]: ", index);
            Array[index] = ReadInts(Console.ReadLine());
        }
        int maxsum = int.MinValue;
        int tempsum = 0;
        int minIndex = 0;
        for (int index = 0; index < Array.Length - (K-1); index++)
        {
            for (int sumIndex = 0; sumIndex < K; sumIndex++)
            {
                tempsum += Array[index + sumIndex];
            }
            if (maxsum < tempsum)
            {
                maxsum = tempsum;
                minIndex = index;
            }
            tempsum = 0;
        }
        Console.Write("Sub-array is: ");
        PrintOneDimSubArray(minIndex, K, Array);
        Console.WriteLine("The sum is: {0}", maxsum);
    }
}