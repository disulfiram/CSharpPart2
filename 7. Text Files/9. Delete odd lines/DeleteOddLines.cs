using System;
using System.IO;

class DeleteOddLines
{
    static void Main(string[] args)
    {
        string InputFileLocation = "InputFile.txt";
        string TemporaryStorageLocation = "result.txt";
        Console.WriteLine(@"Change ""{0}"" or press Enter", InputFileLocation);
        Console.ReadLine();
        StreamReader InputTextFile = new StreamReader(InputFileLocation);
        StreamWriter Result = new StreamWriter(TemporaryStorageLocation);
        using (InputTextFile)
        {
            using (Result)
            {
                int lineCount = 1;
                string line = InputTextFile.ReadLine();
                while (line != null)
                {
                    if ((lineCount %2)==0)
                    {
                        Result.WriteLine(line);
                    }
                    lineCount++;
                    line = InputTextFile.ReadLine();
                }
            }
        }
        File.Delete(InputFileLocation);
        File.Move(TemporaryStorageLocation, InputFileLocation);
    }
}