using System;

class IntInArrayOfInts
{
    static int ReadInts(string value)       //Reads integers from console.
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

    static void FindAndCountInArray(int numberK, int[] arrayOfInts)
    {
        int counter = 0;
        for (int index = 0; index < arrayOfInts.Length; index++)
        {
            if (arrayOfInts[index] == numberK)
            {
                counter += 1;
            }
        }
        Console.WriteLine("{0} is present {1} times in the array.", numberK, counter);
    }

    static void Main(string[] args)
    {
        Console.Write("Input size of array: ");
        int numberN = ReadInts(Console.ReadLine());
        int[] arrayOfInts = new int[numberN];
        for (int index = 0; index < numberN; index++)
        {
            Console.Write("Input element {0}: ", index);
            arrayOfInts[index] = ReadInts(Console.ReadLine());
        }
        Console.Write("Input integer to look for in the array: ");
        int numberK = ReadInts(Console.ReadLine());
        FindAndCountInArray(numberK, arrayOfInts);
    }
}