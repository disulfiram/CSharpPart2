using System;
using System.Text.RegularExpressions;

class ExtractMails
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input text:");
        string inputText = Console.ReadLine();
        const string MatchEmailPattern = @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\." + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";
        Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        MatchCollection matches = rx.Matches(inputText);
        int noOfMatches = matches.Count;
        Console.WriteLine("Emails:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value.ToString());
        }
    }
}