using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            int Number = int.Parse(Console.ReadLine());
            try
            {
                SquareRootOfNumber(Number);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good riddance!");
        }
    }

    public static void SquareRootOfNumber(int Number)
    {
        if (Number<0)
        {
            throw new System.ArgumentOutOfRangeException("Integer has to be positive!");
        }
        Console.WriteLine(Math.Sqrt(Number));
    }
}