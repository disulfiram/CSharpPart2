using System;

class MaxSequence
{
    static string[,] ArrayOfStrings;
    static int[] NumberInSequence = { 0, 0, 0 };

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

    static void ScanMatrix(string Function)     //Scans the matrix, uses string to determine wat do
    {
        for (int row = 0; row < ArrayOfStrings.GetLength(0); row++)
        {
            for (int col = 0; col < ArrayOfStrings.GetLongLength(1); col++)
            {
                switch (Function)
                {
                    case "input":
                        {
                            ArrayOfStrings[row, col] = Console.ReadLine();
                            break;
                        }
                    case "search":
                        {
                            SearchForSequence(row, col);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }   

    static void SearchForSequence(int row, int col)
    {
        int i = row;
        int j = col;
        int TempSeq = 1;
        if (col < (ArrayOfStrings.GetLength(1)-1))
        {
            while (ArrayOfStrings[i, j] == ArrayOfStrings[i, j + 1])
            {
                TempSeq += 1;
                j += 1;
                if ((j + 1) == ArrayOfStrings.GetLength(1))
                {
                    break;
                }
            }
            RecordResults(row, col, TempSeq);
        }

        i = row;
        j = col;
        TempSeq = 1;
        if (row < (ArrayOfStrings.GetLength(0)-1))
        {
            while (ArrayOfStrings[i, j] == ArrayOfStrings[i + 1, j])
            {
                TempSeq += 1;
                i += 1;
                if ((i + 1) == ArrayOfStrings.GetLength(0))
                {
                    break;
                }
            }
            RecordResults(row, col, TempSeq);
        }

        i = row;
        j = col;
        TempSeq = 1;
        if (row < (ArrayOfStrings.GetLength(0) - 1) && col < (ArrayOfStrings.GetLength(1) - 1))
        {
            while (ArrayOfStrings[i, j] == ArrayOfStrings[i + 1, j + 1])
            {
                TempSeq += 1;
                i += 1;
                j += 1;
                if ((i + 1) == ArrayOfStrings.GetLength(0) || (j + 1) == ArrayOfStrings.GetLength(1))
                {
                    break;
                }
            }
            RecordResults(row, col, TempSeq);
        }
            
        i = row;
        j = col;
        TempSeq = 1;
        if (row > 0 && col < (ArrayOfStrings.GetLength(1) - 1))
        {
            while (ArrayOfStrings[i, j] == ArrayOfStrings[i - 1, j + 1])
            {
                TempSeq += 1;
                i -= 1;
                j += 1;
                if ((i - 1) == -1 || (j + 1) == ArrayOfStrings.GetLength(1))
                {
                    break;
                }
            }
            RecordResults(row, col, TempSeq);
        }
    }

    static void RecordResults(int row, int col, int TempSeq)
    {
        if (TempSeq > NumberInSequence[2])
        {
            NumberInSequence[2] = TempSeq;
            NumberInSequence[0] = row;
            NumberInSequence[1] = col;
        }
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
        ArrayOfStrings = new string[rows, cols];

        ScanMatrix("input");

        ScanMatrix("search");
        Console.WriteLine("There are {0} in a row of the string {1}", NumberInSequence[2], ArrayOfStrings[NumberInSequence[0], NumberInSequence[1]]);
    }
}