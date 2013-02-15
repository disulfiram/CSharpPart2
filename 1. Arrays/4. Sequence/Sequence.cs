using System;

class Sequence
{
    static void Main(string[] args)
    {
        int count = 1;
        int tempcount = 1;
        int index = 0;
        int N = 0;
        while (true)                                    //Will ask until successful parse
        {                                               //Array size
            Console.Write("Input array size: ");
            string Value = Console.ReadLine();
            bool Result = int.TryParse(Value, out N);
            if (Result == true && N > 0)
            {
                break;
            }
        }
        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            while (true)
            {
                Console.Write("Element with index {0} = ", i);
                string Value = Console.ReadLine();
                bool Result = int.TryParse(Value, out arr[i]);
                if (Result == true)
                {
                    break;
                }
            }
        }
        for (int i = 1; i < N; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                ++tempcount;
                if (tempcount > count)
                {
                    count = tempcount;      //Length of subarray
                    index = i;              //Index of last int in subarray
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
            Console.Write(arr[index] + " ");
        }
        Console.WriteLine();
    }
}