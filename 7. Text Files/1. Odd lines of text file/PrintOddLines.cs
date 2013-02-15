using System;
using System.IO;

class PrintOddLines
{
    static void Main(string[] args)
    {
        try
        {
            for (int ChooseLine = 0; ChooseLine < int.MaxValue; ChooseLine += 2)
            {
                string[] lines = System.IO.File.ReadAllLines("EST.txt");
                if (ChooseLine < lines.Length)
                {
                    if (ChooseLine < lines.Length)
                    {
                        Console.WriteLine(lines[ChooseLine]);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
    }
}