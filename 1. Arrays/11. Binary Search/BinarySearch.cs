// I really don't think I got the point of this task!
using System;

class BinarySearch
{
    static int ReadInts(string Value)                                                           //Reads integers from console.
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

    static int[] BinarySearchIndex(int Integer, int[] IntegerArray, int[] BinarySearchArray)    //Binary Search
    {
        if (Integer > IntegerArray[IntegerArray.Length-1] || Integer < IntegerArray[0])
        {
            BinarySearchArray[0] = -1;
            return BinarySearchArray;
            Console.WriteLine("{0} is out of range", Integer);
        }
        if (Integer == IntegerArray[BinarySearchArray[2]])
        {
            BinarySearchArray[0] = BinarySearchArray[2];    //int=mid
            Console.WriteLine("{0} has in index {1} in the array.", Integer, BinarySearchArray[0]);
            return BinarySearchArray;
        }
        if (Integer > IntegerArray[BinarySearchArray[2]])   //int>mid
        {
            BinarySearchArray[1] = BinarySearchArray[2];    //min=mid
            BinarySearchArray[2] = (BinarySearchArray[1] + BinarySearchArray[3]) / 2;
            return BinarySearchArray;
        }
        if (Integer < IntegerArray[BinarySearchArray[2]])   //int<mid
        {
            BinarySearchArray[3] = BinarySearchArray[2];    //max=mid
            BinarySearchArray[2] = (BinarySearchArray[1] + BinarySearchArray[3]) / 2;
            return BinarySearchArray;
        }
        BinarySearchArray[0] = -1;
        return BinarySearchArray;
    }

    static void Main(string[] args)
    {
        int N = -1;
        while (N < 0)
        {
            Console.Write("Input N: ");
            N = ReadInts(Console.ReadLine());
        }
        int[] IntegerArray = new int[N];
        for (int index = 0; index < IntegerArray.Length; index++)
        {
            Console.Write("Input Array[{0}]: ", index);
            IntegerArray[index] = ReadInts(Console.ReadLine());
        }
        Array.Sort(IntegerArray);
        Console.Write("Input integer to find the index of: ");
        int Key = ReadInts(Console.ReadLine());
        int[] BinarySearchArray = new int[4];
        BinarySearchArray[0] = -2;          //used to find index of int
        BinarySearchArray[1] = 0;           //min index
        BinarySearchArray[2] = (N-1) / 2;   //mid index
        BinarySearchArray[3] = N-1;         //max index
        while (BinarySearchArray[0] < -1)
        {
            BinarySearchArray = BinarySearchIndex(Key, IntegerArray, BinarySearchArray);
            if (BinarySearchArray[0] == -1)
            {
                Console.WriteLine("{0} out of range!", Key);
                break;
            }
        }
    }
}