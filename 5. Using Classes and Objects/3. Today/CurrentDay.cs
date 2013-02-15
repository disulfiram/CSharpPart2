using System;

class CurrentDay
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        DateTime today = DateTime.Now;
        Console.WriteLine(today.DayOfWeek);    
    }
}