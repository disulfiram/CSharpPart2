//I broke the program in one of my tests but I cannot duplicate the result!

using System;

class BinSearch
{
    static int ReadInts(string Value)           //Reads integers from console.
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

    static void FindIndex(int[] ArrayOfInts, int K)
    {
        int index = Array.BinarySearch(ArrayOfInts, K);
        for (int indexInArray = 0; indexInArray < ArrayOfInts.Length; indexInArray++)
        {
            Console.WriteLine("[{0}] - {1}", index, ArrayOfInts[indexInArray]);
        }
        if (index<0)
        {
            Console.WriteLine("Elemen with index {0} and value {1}, is smaller than {2}", (~index) - 1, ArrayOfInts[(~index) - 1], K);
        }
        else
        {
            Console.WriteLine("Elemen with index {0} and value {1}, is equal to {2}", index, ArrayOfInts[index], K);
        }
    }

    static void Main(string[] args)
    {
        int N = -1;
        Console.Write("Input size of array: ");
        while (N < 1)
        {
            N = ReadInts(Console.ReadLine());
        }
        Console.Write("Input element to search for: ");
        int K = ReadInts(Console.ReadLine());
        int [] ArrayOfInts = new int[N];
        for (int index = 0; index < ArrayOfInts.Length; index++)
        {
            ArrayOfInts[index] = ReadInts(Console.ReadLine());
        }
        Array.Sort(ArrayOfInts);
        FindIndex(ArrayOfInts, K);
    }
}