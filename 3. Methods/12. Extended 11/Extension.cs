using System;
using System.Collections.Generic;

class Extension
{
    static List<int> ReadBytes()       //Reads integers from console.
    {
        List<int> Number = new List<int>();
        int index = 0;

        while (true)
        {
            int Integer;
            Console.Write("x^{0} * ", index);
            string Value = Console.ReadLine();
            bool Result = int.TryParse(Value, out Integer);
            if (Result == true)
            {
                Number.Add(Integer);
                index++;
            }
            else if (Value == "")
            {
                return Number;
            }
            else
            {
                Console.Write(@"""{0}"" is not an integer. Try again: ", Value);
                Value = Console.ReadLine();
            }
        }
    }

    static List<int> AddPolynoms(List<int> FirstPolynom, List<int> SecondPolynom)
    {
        List<int> Sum = new List<int>();
        int lengthBig, lengthLow;
        if (FirstPolynom.Count > SecondPolynom.Count)
        {
            lengthBig = FirstPolynom.Count;
            lengthLow = SecondPolynom.Count;
            for (int index = 0; index < lengthBig; index++)
            {
                if (index < lengthLow)
                {
                    int Sume = (FirstPolynom[index] + SecondPolynom[index]);
                    Sum.Add(Sume);
                }
                if (index >= lengthLow)
                {
                    Sum.Add(FirstPolynom[index]);
                }
            }
        }
        else
        {
            lengthBig = SecondPolynom.Count;
            lengthLow = FirstPolynom.Count;
            for (int index = 0; index < lengthBig; index++)
            {
                if (index < lengthLow)
                {
                    int Sume = (FirstPolynom[index] + SecondPolynom[index]);
                    Sum.Add(Sume);
                }
                if (index >= lengthLow)
                {
                    Sum.Add(SecondPolynom[index]);
                }
            }
        }
        return Sum;
    }

    static List<int> SubtractPolynoms(List<int> FirstPolynom, List<int> SecondPolynom)
    {
        List<int> Sum = new List<int>();
        int lengthBig, lengthLow;
        if (FirstPolynom.Count > SecondPolynom.Count)
        {
            lengthBig = FirstPolynom.Count;
            lengthLow = SecondPolynom.Count;
            for (int index = 0; index < lengthBig; index++)
            {
                if (index < lengthLow)
                {
                    int Sume = (FirstPolynom[index] - SecondPolynom[index]);
                    Sum.Add(Sume);
                }
                if (index >= lengthLow)
                {
                    Sum.Add(FirstPolynom[index]);
                }
            }
        }
        else
        {
            lengthBig = SecondPolynom.Count;
            lengthLow = FirstPolynom.Count;
            for (int index = 0; index < lengthBig; index++)
            {
                if (index < lengthLow)
                {
                    int Sume = (FirstPolynom[index] - SecondPolynom[index]);
                    Sum.Add(Sume);
                }
                if (index >= lengthLow)
                {
                    Sum.Add(SecondPolynom[index]);
                }
            }
        }
        return Sum;
    }

    private static void MultPolynoms(List<int> Polynom1, List<int> Polynom2)
    {
        int[,] Multi = new int[Polynom1.Count,Polynom2.Count];
        for (int FirstIndex = 0; FirstIndex < Polynom1.Count; FirstIndex++)
        {
            for (int SecondIndex = 0; SecondIndex < Polynom2.Count; SecondIndex++)
            {
                int mult = Polynom1[FirstIndex] * Polynom2[SecondIndex];
                Multi[FirstIndex, SecondIndex] = mult;               
            }
        }
        for (int FirstIndex = Polynom1.Count-1; FirstIndex >=0 ; FirstIndex--)
        {
            for (int SecondIndex = Polynom2.Count-1; SecondIndex >= 0; SecondIndex--)
            {
                if (FirstIndex == 0 && SecondIndex == 0)
                {
                    Console.Write("{0}*x^{1} = 0", Multi[FirstIndex, SecondIndex], FirstIndex + SecondIndex);
                }
                else
                {
                    Console.Write("{0}*x^{1} + ", Multi[FirstIndex, SecondIndex], FirstIndex + SecondIndex);
                }
            }
            Console.WriteLine();
        }
    }

    static void PrintList(List<int> Sum)
    {
        for (int index = Sum.Count - 1; index >= 0; index--)
        {
            if (index == 0)
            {
                Console.Write("{0}*x^{1} = ?", Sum[index], index);
            }
            else
            {
                Console.Write("{0}*x^{1} + ", Sum[index], index);
            }
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Input is made single digit at a line. Leave empty line to go to next number.");
        Console.WriteLine("Input first polynom:");
        List<int> Polynom1 = ReadBytes();
        Console.WriteLine("Input second polynom:");
        List<int> Polynom2 = ReadBytes();
        Console.Write("Chose what to do with polynoms (Add/Subtract/Multiply): ");
        string Choice = Console.ReadLine();
        List<int> Result = new List<int>();
        switch (Choice.ToUpper())
        {
            case "ADD":
                {
                    Result = AddPolynoms(Polynom1, Polynom2);
                    PrintList(Result);
                    break;
                }
            case "SUBTRACT":
                {
                    Result = SubtractPolynoms(Polynom1, Polynom2);
                    PrintList(Result);
                    break;
                }
            case "MULTIPLY":
                {
                    MultPolynoms(Polynom1, Polynom2);
                    break;
                }
            default:
                break;
        }
    }
}