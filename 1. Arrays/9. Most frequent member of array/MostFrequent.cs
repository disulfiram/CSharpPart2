using System;

class MostFrequent
{
    static int ReadInts(string Value)                                                                   //Reads integers from console.
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

    static void Main(string[] args)
    {
        int N = -1;
        while (N <= 0)
        {
            Console.Write("Input size of array: ");
            N = ReadInts(Console.ReadLine());
        }
        int[] Array = new int[N];
        for (int index = 0; index < Array.Length; index++)
        {
            Console.Write("Input Array[{0}]: ", index);
            Array[index] = ReadInts(Console.ReadLine());
        }
        int counter = 0;
        int countOfSameElements = 0;
        int element = 0;
        for (int index = 0; index < Array.Length; index++)
        {
            foreach (var number in Array)
            {
                if (number == Array[index])
                {
                    counter += 1;
                }
            }
            if (countOfSameElements < counter)
            {
                countOfSameElements = counter;
                element = Array[index];
            }
            counter = 0;
        }
        Console.WriteLine("The element {0} is repeated {1} times", element, countOfSameElements);
    }
}