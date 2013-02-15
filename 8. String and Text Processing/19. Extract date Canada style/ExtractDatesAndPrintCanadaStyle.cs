using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class ExtractDatesAndPrintCanadaStyle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input text");
        string inputText = Console.ReadLine();
        string datePattern = @"([123]?[\d]\.[1]?[\d]\.[\d]?[\d]?[\d]?[\d])";
        Match match = Regex.Match(inputText, datePattern);
        Regex rx = new Regex(datePattern);
        MatchCollection matches = rx.Matches(inputText);
        foreach (var dates in matches)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            DateTime date = DateTime.Parse(dates.ToString());
            Console.WriteLine(date);
        }
    }
}