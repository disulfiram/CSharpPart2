using System;

class AdTime
{
    static void Main(string[] args)
    {
        Console.Write("Input date: ");
        DateTime date;
        DateTime modifier = DateTime.Parse("6:30:0");
        try
        {
            date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(date.AddHours(6).AddMinutes(30)); 
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);    
        }
    }
}