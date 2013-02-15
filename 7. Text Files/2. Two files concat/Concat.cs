using System;
using System.IO;

class Concat
{
    static void Main(string[] args)
    {
        Console.Write(@"Input first file name(or use default ""first.txt""): ");
        string file1Name = Console.ReadLine();
        Console.Write(@"Input second file name(or use default ""second.txt""): ");
        string file2Name = Console.ReadLine();
        string NewFile = "NewFile.txt";
        StreamWriter ConcatFiles = new StreamWriter(NewFile);
        using (ConcatFiles)
        {
            using (StreamReader TextFile = new StreamReader(file1Name))
            {
                string line = "0";
                while (line != null)
                {
                    line = TextFile.ReadLine();
                    ConcatFiles.WriteLine(line);
                }
            }
            using (StreamReader TextFile = new StreamReader(file2Name))
            {
                string line = "0";
                while (line != null)
                {
                    line = TextFile.ReadLine();
                    ConcatFiles.WriteLine(line);
                }
            }
        }
    }
}