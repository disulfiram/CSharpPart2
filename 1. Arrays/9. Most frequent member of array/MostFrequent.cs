using System;

class MostFrequent
{
    static int ReadInts(string value)                                                                   //Reads integers from console.
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

    static void Main(string[] args)
    {
        int n = -1;
        while (n <= 0)
        {
            Console.Write("Input size of array: ");
            n = ReadInts(Console.ReadLine());
        }
        int[] array = new int[n];
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Input Array[{0}]: ", index);
            array[index] = ReadInts(Console.ReadLine());
        }
        int counter = 0;
        int countOfSameElements = 0;
        int element = 0;
        for (int index = 0; index < array.Length; index++)
        {
            foreach (var number in array)
            {
                if (number == array[index])
                {
                    counter += 1;
                }
            }
            if (countOfSameElements < counter)
            {
                countOfSameElements = counter;
                element = array[index];
            }
            counter = 0;
        }
        Console.WriteLine("The element {0} is repeated {1} times", element, countOfSameElements);
    }
}