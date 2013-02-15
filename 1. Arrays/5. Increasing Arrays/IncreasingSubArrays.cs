using System;

class IncreasingArrays
{
    static void Main(string[] args)
    {
        int count = 1;                              //to store the amount of consecutive numbers
        int tempcount = 1;                          //to store the current amount of consecutive numbers
        int index = 0;
        Console.Write("Input the size of the arrays: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Element with index {0} = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < size; i++)
        {
            if (arr[i] == arr[i - 1] + 1)
            {
                ++tempcount;
                if (tempcount > count)
                {
                    count = tempcount;
                    index = i;
                }
            }
            else
            {
                tempcount = 1;
            }
        }
        Console.Write("Sub array is: ");
        for (int i = count - 1; i >= 0; i--)
        {
            Console.Write(arr[index - i] + " ");
        }
        Console.WriteLine();
    }
}