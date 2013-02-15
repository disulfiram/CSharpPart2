using System;
using System.IO;

class InsertLineNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Input file name(default ""text.txt""): ");
        string TextLocation = Console.ReadLine();
        StreamReader ReadText = new StreamReader(TextLocation);
        StreamWriter WriteNewText = new StreamWriter("newfile.txt");
        using (WriteNewText)
        {
            using (ReadText)
            {
                int counter = 1;
                string line = "0";
                while (line != null)
                {
                    line = ReadText.ReadLine();
                    WriteNewText.WriteLine("Line {0} - {1}",counter , line);
                    counter++;
                }
            }
        }
    }
}