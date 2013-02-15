using System;

class GetMaximum
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

    static int GetMax(int Int1, int Int2)   //Finds bigger of two ints
    {
        if (Int1>Int2)
        {
            return Int1;
        }
        else
        {
            return Int2;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Input 3 integers:");
        int FirstInt = ReadInts(Console.ReadLine());
        int SecondInt = ReadInts(Console.ReadLine());
        int ThirdInt = ReadInts(Console.ReadLine());

        Console.WriteLine(GetMax(GetMax(FirstInt, SecondInt),ThirdInt));
    }
}