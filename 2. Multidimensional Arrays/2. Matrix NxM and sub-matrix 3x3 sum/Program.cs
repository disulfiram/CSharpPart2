using System;

class Program
{
    static int[,] ArrayOfInts;
    static string ScanMatrixFuncion;
    static int sum;

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

    static void ScanMatrix(int rows, int cols, int beginx = 0, int beginy = 0)
    {
        for (int row = beginx; row < rows+beginx; row++)
        {
            switch (ScanMatrixFuncion)
            {
                case "print":
                    {
                        Console.WriteLine();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            for (int col = beginy; col < cols+beginy; col++)
            {
                switch (ScanMatrixFuncion)
                {
                    case "initiate":
                        {
                            ArrayOfInts[row, col] = ReadInts(Console.ReadLine());
                            break;
                        }
                    case "print":
                        {
                            Console.Write("{0,4} ", ArrayOfInts[row, col]);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }

    static void MaxSum()
    {
        sum = int.MinValue;
        int tempsum = int.MinValue;
        int[] index = new int[2];
        for (int row = 0; row < ArrayOfInts.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < ArrayOfInts.GetLength(1) - 2; col++)
            {
                tempsum = ArrayOfInts[row, col] + ArrayOfInts[row, col + 1] + ArrayOfInts[row, col + 2] + ArrayOfInts[row + 1, col] + ArrayOfInts[row + 1, col + 1] + ArrayOfInts[row + 1, col + 2] + ArrayOfInts[row + 2, col] + ArrayOfInts[row + 2, col + 1] + ArrayOfInts[row + 2, col + 2];
                if (tempsum > sum)
                {
                    sum = tempsum;
                    index[0] = row;
                    index[1] = col;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("The sub-array with max sum is:");
        ScanMatrixFuncion = "print";
        ScanMatrix(3, 3, index[0], index[1]);
        Console.WriteLine();
        Console.WriteLine("And the sum is: {0}", sum);
    }

    static void Main(string[] args)
    {
        int rows = -1;
        Console.Write("Input rows of matrix: ");
        while (rows <= 2)
        {
            rows = ReadInts(Console.ReadLine());
        }
        int cols = -1;
        Console.Write("Input columns of matrix: ");
        while (cols <= 2)
        {
            cols = ReadInts(Console.ReadLine());
        }
        ArrayOfInts = new int[rows, cols];
        ScanMatrixFuncion = "initiate";
        ScanMatrix(rows, cols);
        ScanMatrixFuncion = "print";
        ScanMatrix(rows, cols);
        MaxSum();
    }
}