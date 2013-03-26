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

    static bool CheckIfGrater(int numberK, int[] arrayOfInts)
    {
        bool bigger = false;
        if (numberK == 0)
        {
            if (arrayOfInts[0] > arrayOfInts[numberK + 1])
            {
                bigger = true;
                return bigger;
            }
        }
        if (numberK == arrayOfInts.Length - 1)
        {
            if (arrayOfInts[numberK] > arrayOfInts[numberK - 1])
            {
                bigger = true;
                return bigger;
            }
        }
        else
        {
            if (arrayOfInts[numberK] > arrayOfInts[numberK + 1] && arrayOfInts[numberK] > arrayOfInts[numberK - 1])
            {
                bigger = true;
                return bigger;
            }
        }
        return bigger;
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
        int indexOfInteger = -1;
        for (int index = 0; index < numberN; index++)
        {
            bool isBigger = CheckIfGrater(index, arrayOfInts);
            if (isBigger == true)
            {
                indexOfInteger = index;
                break;
            }
        }
        if (indexOfInteger > -1)
        {
            Console.WriteLine("{0} is the first in the array grater than it's neighbours.", arrayOfInts[indexOfInteger]);
        }
        else
        {
            Console.WriteLine("There is no such integer in the array, that is grater than it's neighbours.");
        }
    }
}