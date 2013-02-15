using System;

class BiggerThanNeighbours
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

    static void CheckIfGrater(int K, int[] ArrayOfInts)
    {
        bool Bigger = false;
        if (K == 0)
        {
            if (ArrayOfInts[0] > ArrayOfInts[K + 1])
            {
                Bigger = true;
            }
        }
        if (K == ArrayOfInts.Length - 1)
        {
            if (ArrayOfInts[K] > ArrayOfInts[K - 1])
            {
                Bigger = true;
            }
        }
        else
        {
            if (ArrayOfInts[K] > ArrayOfInts[K + 1] && ArrayOfInts[K] > ArrayOfInts[K - 1])
            {
                Bigger = true;
            }
        }
        Console.WriteLine(Bigger);
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
        Console.Write("Input index of element to check: ");
        int K = ReadInts(Console.ReadLine());
        CheckIfGrater(K, ArrayOfInts);
    }
}