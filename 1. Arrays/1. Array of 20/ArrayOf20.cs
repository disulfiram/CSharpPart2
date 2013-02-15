using System;

class ArrayOf20
{
    static void Main()
    {
        int[] Array20 = new int[20];
        for (int i = 0; i < 20; i++)    //Input cycle
        {
            Array20[i] = i * 5;
        }
        for (int i = 0; i < 20; i++)    //Output cycle
        {
            Console.Write(Array20[i] + " ");
        }
        Console.WriteLine();
    }
}