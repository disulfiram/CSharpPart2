//Doesn't work! Try alternative (10.1)
using System;
using System.Collections.Generic;

class Factoriel
{
    static List<byte> MultiNumbers(List<byte> FirstNumber, List<byte> SecondNumber)
    {
        List<byte> Result = new List<byte>();
        for (byte SecondIndex = 0; SecondIndex < SecondNumber.Count; SecondIndex++)
        {
            for (byte FirstIndex = 0; FirstIndex < FirstNumber.Count; FirstIndex++)
            {
                Result.Add((byte)(FirstNumber[FirstIndex] * SecondNumber[SecondIndex] * (10 * SecondIndex)));
            }
        }
        return Result;
    }

    static List<byte> SecondNumber(byte i)
    {
        List<byte> SN = new List<byte>();
        byte digit = (byte)(i % 10);
        SN.Add(digit);
        if (i>9)
        {
            digit = (byte)(i % 100);
            SN.Add(digit);  
        }
        if (i>99)
        {
            digit = (byte)(i % 1000);
            SN.Add(digit);
        }
        return SN;   
    }

    static void Main(string[] args)
    {
        List<byte> Factoriel = new List<byte>();
        Factoriel.Add(1);
        for (byte factorielI = 1; factorielI < 101; factorielI++)
        {
            Factoriel = MultiNumbers(Factoriel, SecondNumber(factorielI));
            Console.WriteLine("{0} - {1}", factorielI, Factoriel[factorielI-1]);
        }  
    }
}