using System;

class PrintAlphabetically
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input string of words:");
        string inputString = Console.ReadLine();
        char[] separators = { ' ' };
        string[] inputWords = inputString.Split(separators);
        Array.Sort(inputWords);
        for (int word = 0; word < inputWords.Length; word++)
        {
            Console.WriteLine(inputWords[word]);
        }
    }
}