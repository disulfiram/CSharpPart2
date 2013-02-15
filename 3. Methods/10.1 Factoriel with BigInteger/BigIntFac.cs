using System;
using System.Numerics;

class BigIntFac
{
    static BigInteger FactorielMeth(BigInteger FirstNumber, BigInteger SecondNumber)
    {
        BigInteger Result = FirstNumber * SecondNumber;
        return Result;
    }

    static void Main(string[] args)
    {
        BigInteger FactorielNumber = 1;
        for (int i = 1; i < 101; i++)
		{
            FactorielNumber = FactorielMeth(FactorielNumber, i);
            Console.WriteLine("{0,3} - {1}", i, FactorielNumber);
		}
            
    }
}
