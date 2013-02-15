using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Dictionary
{
    static string[] word;
    static string[] definition;

    private static void ProcessDictionarry()
    {
        StreamReader readDictionary = new StreamReader("Dictionary.txt");
        List<string> line = new List<string>();
        using (readDictionary)
        {
            string currentLine = readDictionary.ReadLine();
            while (currentLine != null)
            {
                line.Add(currentLine);
                currentLine = readDictionary.ReadLine();
            }
        }
        string[] dictionary = line.ToArray<string>();
        word = new string[line.Count];
        definition = new string[line.Count];
        for (int lineCount = 0; lineCount < line.Count; lineCount++)
        {
            char[] separators = { '-' };
            string[] currentLine = dictionary[lineCount].Split(separators);
            word[lineCount] = currentLine[0].Trim();
            definition[lineCount] = currentLine[1].Trim();
        }
    }

    private static void SearchDictionary(string userSearch, string[] word, string[] definition)
    {
        for (int words = 0; words < word.Length; words++)
        {
            if (word[words].ToUpper() == userSearch)
            {
                Console.WriteLine("{0} - {1}", word[words], definition[words]);
                return;
            }
            else if (words ==word.Length-1)
            {
                Console.WriteLine("Word not in dictionary!");
                return;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(@"Edit ""Dictionary.txt""");
        Console.ReadLine();
        ProcessDictionarry();
        Console.WriteLine("Input word to look for");
        string userSearch = Console.ReadLine().ToUpper();
        SearchDictionary(userSearch, word, definition);
    }
}