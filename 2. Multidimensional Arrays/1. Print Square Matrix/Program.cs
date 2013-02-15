using System;

class Program
{
    static int[,] ArrayOfInts;

    static int ReadInts(string Value)           //Reads integers from console.
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

    static void A()
    {
        for (int row = 0; row < ArrayOfInts.GetLength(0); row++)
        {
            for (int col = 0; col < ArrayOfInts.GetLength(1); col++)
            {
                ArrayOfInts[row, col] = (col * ArrayOfInts.GetLength(0)) + (row + 1);
            }
        }
    }

    static void B()
    {
        for (int row = 0; row < ArrayOfInts.GetLength(0); row++)
        {
            for (int col = 0; col < ArrayOfInts.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    ArrayOfInts[row, col] = (col * ArrayOfInts.GetLength(0)) + (row + 1);
                }
                else
                {
                    ArrayOfInts[row, col] = ((col + 1) * ArrayOfInts.GetLength(0)) - row;
                }
            }
        }
    }

    static void C()
    {
        for (int row = 0; row < ArrayOfInts.GetLength(0); row++)
        {
            for (int col = 0; col < ArrayOfInts.GetLength(1); col++)
            {
                //not implemented
            }
        }
    }

    static void PrintMatrix()
    {
        for (int row = 0; row < ArrayOfInts.GetLength(0); row++)
        {
            for (int col = 0; col < ArrayOfInts.GetLength(1); col++)
            {
                Console.Write("{0,4} ", ArrayOfInts[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int N = -1;
        Console.Write("Input size of matrix: ");
        while (N <= 0)
        {
            N = ReadInts(Console.ReadLine());
        }
        ArrayOfInts = new int[N, N];
        Console.Write("Chose between a, b, c and d: ");
        string Choice = null;
        while (Choice != "a" && Choice != "b" && Choice != "c" && Choice != "d")
        {
            Choice = Console.ReadLine();
        }
        switch (Choice)
        {
            case "a":
            case "A":
                {
                    A();
                    break;
                }
            case "b":
            case "B":
                {
                    B();
                    break;
                }
            case "c":
            case "C":
                {
                    C();
                    break;
                }
            default:
                {
                    break;
                }
        }
        PrintMatrix();
    }
}