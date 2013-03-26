using System;

class FirstBigger
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

    static int CheckIfGrater(int[] arrayOfInts)
    {
        for (int index = 0; index < arrayOfInts.Length; index++)
        {
            if (index == 0)
            {
                if (arrayOfInts[index] > arrayOfInts[index + 1])
                {
                    return index;
                }
            }
            if (index == arrayOfInts.Length - 1)
            {
                if (arrayOfInts[index] > arrayOfInts[index - 1])
                {
                    return index;
                }
            }
            else
            {
                if (arrayOfInts[index] > arrayOfInts[index + 1] && arrayOfInts[index] > arrayOfInts[index - 1])
                {
                    return index;
                }
            }
        }
        return -1;
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
        int indexOfInteger = CheckIfGrater(arrayOfInts);
        if (indexOfInteger >-1)
        {
            Console.WriteLine("{0} is the first in the array grater than it's neighbours.", arrayOfInts[indexOfInteger]);
        }
        else
        {
            Console.WriteLine("There is no such integer in the array, that is grater than it's neighbours.");
        }
    }
}