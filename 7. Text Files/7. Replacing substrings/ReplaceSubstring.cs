using System;
using System.IO;

class ReplaceSubstring
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
                    string NewLine = line.Replace("start", "finish");
                    WriteTheResults.WriteLine(NewLine);
                    line = ReadFromFile.ReadLine();
                }
            }
        }
    }
}