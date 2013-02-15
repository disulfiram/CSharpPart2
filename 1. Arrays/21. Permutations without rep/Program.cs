using System;

class Program
{
    static int N;                               //Number of elements
    static int K;                               //Size of permutations
    static int[] ArrayOfInts;                   //Used to store permutations

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

    static void Combinations(int Combination=0) //Recursive way to find the permutations
    {
        if (Combination == K)
        {
            PrintCombinations();
            return;
        }
        for (int counter = 1; counter <= N; counter++)
        {
            ArrayOfInts[Combination] = counter;
            Combinations(Combination + 1);
        }
    }

    static void PrintCombinations()             //Prints the permutations as arrays
    {
        for (int index = 0; index < K; index++)
        {
            for (int check = index + 1; check < K; check++)
            {
                if (ArrayOfInts[index] == ArrayOfInts[check])
                {
                    return;
                }
                else
                {
                    Console.Write("{");
                }
            }
            if (index < (K - 1))
            {
                Console.Write("{0}, ", ArrayOfInts[index]);
            }
            else
            {
                Console.Write("{0}", ArrayOfInts[index]);
            }
        }
        Console.WriteLine("}");
    }

    static void Main(string[] args)
    {
        Console.Write("Input number of elements: ");
        N = ReadInts(Console.ReadLine());
        K = 0;
        while (K > N || K < 1)
        {
            Console.Write("Input size of variations(should be less than number of elements): ");
            K = ReadInts(Console.ReadLine());
        }
        ArrayOfInts = new int[N];
        Combinations();
    }
}