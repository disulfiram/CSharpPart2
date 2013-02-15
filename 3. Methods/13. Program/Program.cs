using System;

class Program
{
    static int ReadInts()       //Reads integers from console.
    {
        while (true)
        {
            int integer;
            string value = Console.ReadLine();
            bool result = int.TryParse(value, out integer);
            if (result == true)
            {
                return integer;
            }
            else
            {
                Console.Write(@"""{0}"" is not an integer. Try again: ", value);
                value = Console.ReadLine();
            }
        }
    }

    private static void Menu(string choice)
    {
        switch (choice.ToUpper())
        {
            case "1":
            case "R":
            case "REVERSE":
                {
                    Reverse();
                    break;
                }
            case "2":
            case "A":
            case "AVARAGE":
                {
                    Avarage();
                    break;
                }
            case "3":
            case "S":
            case "SOLVE":
                {
                    LinEq();
                    break;
                }
            default:
                break;
        }
    }

    private static void LinEq()
    {
        Console.WriteLine("a*x + b = 0");
        Console.Write("Input a:");
        int a = ReadInts();
        Console.Write("Input b:");
        int b = ReadInts();
        double x = ((double)-b / (double)a);
        Console.WriteLine("x = {0}",x);
    }

    private static void Avarage()
    {
        Console.WriteLine("Size of array: ");
        int n = -1;
        while (n<1)
        {
            n = ReadInts();
        }
        int[] arrayOfInts = new int[n];
        Console.WriteLine("Input elements:");
        int sum = 0;
        for (int index = 0; index < n; index++)
        {
            arrayOfInts[index] = ReadInts();
            sum += arrayOfInts[index];
        }
        int av = sum / arrayOfInts.Length;
        Console.WriteLine("Avarage is: {0}", av);
    }

    private static void Reverse()
    {
        Console.Write("Input a positive integer: ");
        int n = ReadInts();
        if (n < 0)
        {
            Console.WriteLine("Integer must be positive:");
            return;
        }
        PrintReversedInts(n);
    }

    static void PrintReversedInts(int n)
    {
        Console.Write("The reversed number is: ");
        while (n != 0)
        {
            Console.Write(n % 10);
            n /= 10;
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Choose which task do you want:");
        Console.WriteLine("1. Reverse");
        Console.WriteLine("2. Avarage");
        Console.WriteLine("3. Solve");
        string choice = Console.ReadLine();        //input
        Menu(choice);
    }
}