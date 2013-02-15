using System;

class ReadNumbers
{
    public static int ReadNumber(int start=0, int end=100)
    {
        int Number;
        try
        {
            Number = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            throw new System.FormatException("Not valid number!");
        }
        catch (OverflowException)
        {
            throw new System.OverflowException("Not valid int32 number!");
        }
        if (Number<start || Number > end)
        {
            throw new System.ArgumentOutOfRangeException("Value should be grater than previous number!");
        }
        return Number;
    }

    static void Main(string[] args)
    {
        int[] ArrayOfInts = new int[10];
        try
        {
            ArrayOfInts[0] = ReadNumber();
            for (int count = 1; count < 10; count++)
            {
                ArrayOfInts[count] = ReadNumber(ArrayOfInts[count - 1]);
            }
        }
        catch (FormatException ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}