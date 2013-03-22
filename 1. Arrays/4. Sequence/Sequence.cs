using System;

class Sequence
{
    static void Main(string[] args)
    {
        int count = 1;
        int tempcount = 1;
        int indexOfSequence = 0;
        int n = 0;
        while (true)                                    //Will ask until successful parse
        {                                               //Array size
            Console.Write("Input array size: ");
            string value = Console.ReadLine();
            bool result = int.TryParse(value, out n);
            if (result == true && n > 0)
            {
                break;
            }
        }
        int[] arr = new int[n];
        for (int index = 0; index < n; index++)
        {
            while (true)
            {
                Console.Write("Element with index {0} = ", index);
                string value = Console.ReadLine();
                bool result = int.TryParse(value, out arr[index]);
                if (result == true)
                {
                    break;
                }
            }
        }
        for (int index = 1; index < n; index++)
        {
            if (arr[index] == arr[index - 1])
            {
                ++tempcount;
                if (tempcount > count)
                {
                    count = tempcount;      //Length of subarray
                    indexOfSequence = index;              //Index of last int in subarray
                }

            }
            else
            {
                tempcount = 1;
            }
        }
        Console.Write("Sub array is: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(arr[indexOfSequence] + " ");
        }
        Console.WriteLine();
    }
}