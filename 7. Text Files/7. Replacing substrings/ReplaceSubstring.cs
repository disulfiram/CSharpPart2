using System;
using System.IO;

class ReplaceSubstring
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Change ""InputFile.txt"" or press Enter");
        Console.ReadLine();
        StreamReader readFromFile = new StreamReader("InputFile.txt");
        StreamWriter writeTheResults = new StreamWriter("result.txt");
        using (readFromFile)
        {
            using (writeTheResults)
            {
                string line = readFromFile.ReadLine();
                while (line != null)
                {
                    string newLine = line.Replace("start", "finish");
                    writeTheResults.WriteLine(newLine);
                    line = readFromFile.ReadLine();
                }
            }
        }
    }
}