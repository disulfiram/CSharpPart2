using System;

class Program
{
    private static int FindMax(int[] Array)                         //Finds max value in array.
    {
        int Max = Array[0];

        for (int i = 0; i < Array.Length; i++)
        {
            if (Max < Array[i])
            {
                Max = Array[i];
            }
        }
        return Max;
    }

    private static int FindMin(int[] Array)                  //Finds next minimal value
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
    static int ReadInts()       //Reads integers from console.
    {
        while (true)
        {
            int Integer;
            string Value = Console.ReadLine();
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

    static int FindSum(int[] Array)
    {
        int Sum = 0;
        for (int index = 0; index < Array.Length; index++)
        {
            Sum += Array[index];
        }
        return Sum;
    }

    static double FindAvarage(int[] Array)
    {
        double Avarage = (double)FindSum(Array) / Array.Length;
        return Avarage;
    }

    static int FindProduct(int[] Array)
    {
        int Product = 1;
        for (int index = 0; index < Array.Length; index++)
        {
            Product *= Array[index];
        }
        return Product;
    }

    static void Main(string[] args)
    {
        Console.Write("Input size of array: ");
        int N = -1;
        while (N < 1)
        {
            N = ReadInts();
        }
        int[] ArrayOfInts = new int[N];
        for (int index = 0; index < N; index++)
        {
            ArrayOfInts[index] = ReadInts();
        }
        int Max = FindMax(ArrayOfInts);
        int Min = FindMin(ArrayOfInts);
        double Avarage = FindAvarage(ArrayOfInts);
        int Sum = FindSum(ArrayOfInts);
        int Product = FindProduct(ArrayOfInts);
        Console.WriteLine("Maximum value is: {0}", Max);
        Console.WriteLine("Minimum value is: {0}", Min);
        Console.WriteLine("Avarage value is: {0}", Avarage);
        Console.WriteLine("The sum of all elements is: {0}", Sum);
        Console.WriteLine("The product of all elements is: {0}", Product);
    }
}