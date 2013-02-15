using System;

class IntInArrayOfInts
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

    static void FindAndCountInArray(int K, int[] ArrayOfInts)
    {
        int counter = 0;
        for (int index = 0; index < ArrayOfInts.Length; index++)
        {
            if (ArrayOfInts[index] == K)
            {
                counter += 1;
            }
        }
        Console.WriteLine("{0} is present {1} times in the array.", K, counter);
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
        Console.Write("Input integer to look for in the array: ");
        int K = ReadInts(Console.ReadLine());
        FindAndCountInArray(K, ArrayOfInts);
    }
}