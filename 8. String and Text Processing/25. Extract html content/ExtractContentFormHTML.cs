using System;
using System.Text.RegularExpressions;

class ExtractContentFromHTML
{
    static void Main()
    {
        Console.WriteLine("Input html content:");
        string inputHTML = Console.ReadLine();
        string titlePattern = "(<title>[a-zA-Z0-9]+</title>)";
        Match Title = Regex.Match(inputHTML, titlePattern);
        string title = Title.ToString();
        title = title.Replace("<title>", "");
        title = title.Replace("</title>", "");
        Console.WriteLine("Title: {0}", title);
        //pending!
    }
}