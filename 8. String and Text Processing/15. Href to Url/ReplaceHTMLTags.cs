using System;

class ReplaceHTMLTags
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a string:");
        string inputText = Console.ReadLine();
        inputText = inputText.Replace(@"<a href=""", "[URL=");
        inputText = inputText.Replace(@"</a>", "[/URL]");
        inputText = inputText.Replace(@""">", "]");
        Console.WriteLine(inputText);
    }
}