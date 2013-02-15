using System;
using System.Linq;


class IntegersInOneString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input integers on one row:");
        string integers = Console.ReadLine();
        string[] ArrayOfStrings = integers.Split();
        int[] ArrayOfInts = new int[ArrayOfStrings.Length];
        for (int index = 0; index < ArrayOfStrings.Length; index++)
        {
            bool fail = int.TryParse(ArrayOfStrings[index], out ArrayOfInts[index]);
            if (fail == false)
            {
                Console.WriteLine("{0} is not integer.", ArrayOfStrings[index]);
            }
        }
        Console.WriteLine("The sum is: {0}", ArrayOfInts.Sum());      
    }
}