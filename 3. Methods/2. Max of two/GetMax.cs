using System;

class GetMaximum
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

    static int GetMax(int int1, int int2)   //Finds bigger of two ints
    {
        if (int1>int2)
        {
            return int1;
        }
        else
        {
            return int2;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Input 3 integers:");
        int firstInt = ReadInts(Console.ReadLine());
        int secondInt = ReadInts(Console.ReadLine());
        int thirdInt = ReadInts(Console.ReadLine());

        Console.WriteLine(GetMax(GetMax(firstInt, secondInt),thirdInt));
    }
}