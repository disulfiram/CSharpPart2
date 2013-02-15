using System;

class LeapYear
{
    static int ReadInts()       //Reads integers from console.
    {
        while (true)
        {
            int Integer;
            string Value = Console.ReadLine();
            bool Result = int.TryParse(Value, out Integer);
            if (Result == true)
            {
                return Integer;
            }
            else
            {
                Console.Write(@"""{0}"" is not an integer. Try again: ", Value);
                Value = Console.ReadLine();
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Input year: ");
        int year = -1;
        while (year <0)
        {
            year = ReadInts();
        }
        Console.WriteLine("{0} is leap year? {1}", year, DateTime.IsLeapYear(year));
    }
}