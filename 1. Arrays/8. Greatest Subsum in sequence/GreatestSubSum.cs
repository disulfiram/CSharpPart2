using System;

class GreatestSubSum
{
    static int ReadInts(string value)                                                                   //Reads integers from console.
    {
        while (true)
        {
            int integer;
            bool result = int.TryParse(value, out integer);
            if (result == true)
            {
                return integer;
            }
            else
            {
                Console.Write(@"""{0}"" is not an integer. Try again: ", value);
                value = Console.ReadLine();
            }
        }
    }

    private static void PrintOneDimSubArray(int index1, int length, int[] arr)                          //Prints array
    {
        for (int index = index1; index < index1+length; index++)
        {
            Console.Write(arr[index] + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int n = -1;
        while (n <= 0)
        {
            Console.Write("Input size of array: ");
            n = ReadInts(Console.ReadLine());
        }
        int k = -1;
        while (k <= 0 || k > n)
        {
            Console.Write("Input size of sub-array: ");
            k = ReadInts(Console.ReadLine());
        }
        int[] array = new int[n];
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Input Array[{0}]: ", index);
            array[index] = ReadInts(Console.ReadLine());
        }
        int maxsum = int.MinValue;
        int tempsum = 0;
        int minIndex = 0;
        for (int index = 0; index < array.Length - (k-1); index++)
        {
            for (int sumIndex = 0; sumIndex < k; sumIndex++)
            {
                tempsum += array[index + sumIndex];
            }
            if (maxsum < tempsum)
            {
                maxsum = tempsum;
                minIndex = index;
            }
            tempsum = 0;
        }
        Console.Write("Sub-array is: ");
        PrintOneDimSubArray(minIndex, k, array);
        Console.WriteLine("The sum is: {0}", maxsum);
    }
}