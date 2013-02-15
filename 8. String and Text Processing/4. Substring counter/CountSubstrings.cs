using System;

class CountSubstrings
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input string to look in:");
        string inputString = Console.ReadLine();
        Console.Write("Input sub-string to look for: ");
        string substring = Console.ReadLine();
        int counter = 0;
        for (int firstLetter = 0; firstLetter < (inputString.Length - (substring.Length + 1)); firstLetter++)
        {
            int lastLetter = substring.Length;
            string compare = inputString.Substring(firstLetter, lastLetter);
            if (compare.ToUpper() == substring.ToUpper())
            {
                counter++;
            }
        }
        if (substring.Length == 1)
        {
            Console.WriteLine("There are {0} instances of the substring {1}", counter, substring);
        }
        else
        {
            Console.WriteLine("There are {0} instances of the substring {1}", counter + 1, substring);
        }
    }
}