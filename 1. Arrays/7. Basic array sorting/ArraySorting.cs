using System;

class ArraySorting
{
    static int ReadInts(string value)                                               //Reads integers from console.
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

    private static void PrintOneDimArray(int n, int[] arr)                          //Prints array
    {
        for (int index = 0; index < n; index++)
        {
            Console.Write(arr[index] + " ");
        }
    }

    private static int MaxInOneDimArray(int n, int[] array)                         //Finds max value in array.
    {
        int max = array[0];

        for (int i = 0; i < n; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }

    private static int MinInOneDimArray(int n, int m, int[] array)                  //Finds next minimal value
    {
        int min = m;
        int max = m;
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            if (min >= array[i])
            {
                min = array[i];
                index = i;
            }
        }
        array[index] = max;
        return min;
    }

    static void Main(string[] args)
    {
        int n = -1;
        while (n <= 0)
        {
            Console.Write("Input N: ");
            n = ReadInts(Console.ReadLine());
        }
        int[] array = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Input Array[{0}]: ", index);
            array[index] = ReadInts(Console.ReadLine());
        }
        int[] sortedArray = new int[n];

        int max = MaxInOneDimArray(n, array);

        for (int index = 0; index < n; index++)
        {
            sortedArray[index] = MinInOneDimArray(n, max, array);
        }
        PrintOneDimArray(n, sortedArray);
    }
}