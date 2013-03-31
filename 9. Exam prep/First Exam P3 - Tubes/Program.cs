using System;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        short N = short.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int[] pipeLengths = new int[N];
        ulong Sum = 0;
        for (short pipeNumber = 0; pipeNumber < N; pipeNumber++)
        {
            pipeLengths[pipeNumber] = int.Parse(Console.ReadLine());
            Sum += (ulong)pipeLengths[pipeNumber];
        }
        if ((int)Sum < M)
        {
            Console.WriteLine("-1");
        }
        int maxLength = (int)(Sum / (ulong)M);
        int actualLength = maxLength;
        int pipes = 0;
        while (pipes < M)
        {
            for (int pipe = 0; pipe < pipeLengths.Length; pipe++)
            {
                pipes += (pipeLengths[pipe] / actualLength);
            }
            if (pipes<M)
            {
                actualLength--;
                pipes = 0;
            }
        }
        Console.WriteLine(actualLength);
    }
}