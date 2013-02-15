using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWords
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Change ""InputFile.txt"" or press Enter");
        Console.ReadLine();
        StreamReader ReadFromFile = new StreamReader("InputFile.txt");
        StreamWriter WriteTheResults = new StreamWriter("result.txt");
        using (ReadFromFile)
        {
            using (WriteTheResults)
            {
                string line = ReadFromFile.ReadLine();
                while (line != null)
                {
                    string NewLine = Regex.Replace(line, @"\bstart\b", " finish ");
                    WriteTheResults.WriteLine(NewLine);
                    line = ReadFromFile.ReadLine();
                }
            }
        }
    }
}