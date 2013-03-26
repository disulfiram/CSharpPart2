using System;

class BiggerThanNeighbours
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

    static void CheckIfGrater(int numberK, int[] arrayOfInts)
    {
        bool bigger = false;
        if (numberK == 0)
        {
            if (arrayOfInts[0] > arrayOfInts[numberK + 1])
            {
                bigger = true;
            }
        }
        if (numberK == arrayOfInts.Length - 1)
        {
            if (arrayOfInts[numberK] > arrayOfInts[numberK - 1])
            {
                bigger = true;
            }
        }
        else
        {
            if (arrayOfInts[numberK] > arrayOfInts[numberK + 1] && arrayOfInts[numberK] > arrayOfInts[numberK - 1])
            {
                bigger = true;
            }
        }
        Console.WriteLine(bigger);
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
        Console.Write("Input index of element to check: ");
        int numberK = ReadInts(Console.ReadLine());
        CheckIfGrater(numberK, arrayOfInts);
    }
}