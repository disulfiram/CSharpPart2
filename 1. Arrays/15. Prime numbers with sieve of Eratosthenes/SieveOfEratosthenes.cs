using System;

class SieveOfEratosthenes
{
    static void Main(string[] args)
    {
        int[] TenMil = new int[10000000];                       //Change this value to check if alg works(it does :) )
        for (int index = 0; index < TenMil.Length; index++)
        {
            TenMil[index] = index;
        }
        bool[] IndexOfPrimeNumbers = new bool[TenMil.Length];   //this array is to find which indexes store prime numbers
        for (int index = 2; index < TenMil.Length; index++)
        {
            if (IndexOfPrimeNumbers[index] == false)
            {
                for (long index2 = 2*index; index2 < TenMil.Length; index2 += index)
                {
                    IndexOfPrimeNumbers[index2] = true;
                }
            }
        }
        for (int index = 0; index < TenMil.Length; index++)
        {
            if (IndexOfPrimeNumbers[index] == false)
            {
                Console.WriteLine(TenMil[index]);
            }
        }
    }
}