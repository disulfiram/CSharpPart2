﻿using System;

class CompareArrays
{
    static void Main()
    {
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
        int[] Array1 = new int[N];
        int[] Array2 = new int[N];
        for (int i = 0; i < N; i++)                     //Input cycle
        {
            while (true)
            {
                Console.Write("Element of Array1 with index {0} = ", i);
                string Value = Console.ReadLine();
                bool Result = int.TryParse(Value, out Array1[i]);
                if (Result == true)
                {
                    break;
                }
            }

        }
        for (int i = 0; i < N; i++)                     //Input cycle
        {
            while (true)
            {
                Console.Write("Element of Array2 with index {0} = ", i);
                string Value = Console.ReadLine();
                bool Result = int.TryParse(Value, out Array2[i]);
                if (Result == true)
                {
                    break;
                }
            }
        }
        for (int i = 0; i < N; i++)     //Compare cycle and output
        {
            if (Array1[i] > Array2[i])
            {
                Console.WriteLine("{0} > {1}", Array1[i], Array2[i]);
            }
            if (Array1[i] == Array2[i])
            {
                Console.WriteLine("{0} = {1}", Array1[i], Array2[i]);
            }
            if (Array1[i] < Array2[i])
            {
                Console.WriteLine("{0} < {1}", Array1[i], Array2[i]);
            }
        }
    }
}