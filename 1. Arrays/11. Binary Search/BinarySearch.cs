// I really don't think I got the point of this task!

using System;

class BinarySearch
{
    static int ReadInts(string value)                                                           //Reads integers from console.
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

    static int[] BinarySearchIndex(int integer, int[] integerArray, int[] binarySearchArray)    //Binary Search
    {
        if (integer > integerArray[integerArray.Length - 1] || integer < integerArray[0])
        {
            binarySearchArray[0] = -1;
            Console.WriteLine("{0} is out of range", integer);
            return binarySearchArray;
        }
        if (integer == integerArray[binarySearchArray[2]])
        {
            binarySearchArray[0] = binarySearchArray[2];    //int=mid
            Console.WriteLine("{0} has in index {1} in the array.", integer, binarySearchArray[0]);
            return binarySearchArray;
        }
        if (integer > integerArray[binarySearchArray[2]])   //int>mid
        {
            binarySearchArray[1] = binarySearchArray[2];    //min=mid
            binarySearchArray[2] = (binarySearchArray[1] + binarySearchArray[3]) / 2;
            return binarySearchArray;
        }
        if (integer < integerArray[binarySearchArray[2]])   //int<mid
        {
            binarySearchArray[3] = binarySearchArray[2];    //max=mid
            binarySearchArray[2] = (binarySearchArray[1] + binarySearchArray[3]) / 2;
            return binarySearchArray;
        }
        binarySearchArray[0] = -1;
        return binarySearchArray;
    }

    static void Main(string[] args)
    {
        int n = -1;
        while (n < 0)
        {
            Console.Write("Input N: ");
            n = ReadInts(Console.ReadLine());
        }
        int[] integerArray = new int[n];
        for (int index = 0; index < integerArray.Length; index++)
        {
            Console.Write("Input Array[{0}]: ", index);
            integerArray[index] = ReadInts(Console.ReadLine());
        }
        Array.Sort(integerArray);
        Console.Write("Input integer to find the index of: ");
        int key = ReadInts(Console.ReadLine());
        int[] binarySearchArray = new int[4];
        binarySearchArray[0] = -2;          //used to find index of int
        binarySearchArray[1] = 0;           //min index
        binarySearchArray[2] = (n - 1) / 2;   //mid index
        binarySearchArray[3] = n - 1;         //max index
        while (binarySearchArray[0] < -1)
        {
            binarySearchArray = BinarySearchIndex(key, integerArray, binarySearchArray);
            if (binarySearchArray[0] == -1)
            {
                Console.WriteLine("{0} out of range!", key);
                break;
            }
        }
    }
}