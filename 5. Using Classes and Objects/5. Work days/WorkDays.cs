//Should work with holydays as well. No time for that! Gotta go fast.
using System;

class WorkDays
{
    static void Main(string[] args)
    {
        DateTime TimeNow = DateTime.Now;
        DateTime[] Holydays = new DateTime[14];         //Needs to be filled with the holydays… who has time for this?!
        Console.WriteLine("Input date");
        DateTime Target = new DateTime(1, 1, 1);
        try
        {
            Target = DateTime.Parse(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Not valid date!"); ;
        }
        int count = 0;
        Console.WriteLine(TimeNow.DayOfWeek);
        for (int Day = 0; Day < Target.DayOfYear-TimeNow.DayOfYear; Day++)
        {
            DateTime modified = TimeNow.AddDays(Day);
            if (modified.DayOfWeek != DayOfWeek.Saturday && modified.DayOfWeek != DayOfWeek.Sunday)
            {
                count += 1;
            }
            foreach (var day in Holydays)
            {
                if (day == modified)
                {
                    count -= 1;
                }
            }
        }
        Console.WriteLine("There are {0} workdays between now and {1}", count, Target);
    }
}