using System;
using System.IO;
using System.Text.RegularExpressions;

class RemoveTags
{
    static void Main(string[] args)
    {
        string inputFile = "WebSite.txt";
        string contentFile = "Content.txt";
        StreamReader ReadWebsite = new StreamReader(inputFile);
        StreamWriter ExtractContent = new StreamWriter(contentFile);
        //string pattern = @">(A-Za-z)<";
        string pattern = @">(.*?)\<";
        using (ReadWebsite)
        {
            using (ExtractContent)
            {
                string line = ReadWebsite.ReadLine();
                while (line!=null)
                {
                    Regex content = new Regex(pattern);
                    MatchCollection result = content.Matches(line);
                    foreach (var Line in result)
                    {
                            ExtractContent.WriteLine(Line);
                            Console.WriteLine(Line);       //it's something, right?
                    }
                    line = ReadWebsite.ReadLine();
                }
            }
        }
    }
}