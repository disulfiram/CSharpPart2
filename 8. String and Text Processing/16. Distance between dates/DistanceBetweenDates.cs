using System;

class DistanceBetweenDates
{
    static void Main(string[] args)
    {
        Console.Write("Input first date: ");
        string firstDate = Console.ReadLine();
        Console.Write("Input second date: ");
        string secondDate = Console.ReadLine();
        DateTime firstDateActual = DateTime.Parse(firstDate);
        DateTime secondDateActual = DateTime.Parse(secondDate);
        int distance = Math.Abs(firstDateActual.DayOfYear - secondDateActual.DayOfYear);
        Console.WriteLine("Distance between two dates is: {0} days", distance);
    }
}