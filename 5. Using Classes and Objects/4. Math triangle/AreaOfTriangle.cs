using System;

class AreaOfTriangle
{
    static double ReadDouble()       //Reads integers from console.
    {
        while (true)
        {
            double Number;
            string Value = Console.ReadLine();
            bool Result = double.TryParse(Value, out Number);
            if (Result == true)
            {
                return Number;
            }
            else
            {
                Console.Write(@"""{0}"" is not double. Try again: ", Value);
                Value = Console.ReadLine();
            }
        }
    }

    private static double SideAndAltitudeToIt()
    {
        Console.Write("Side = ");
        double side = ReadDouble();
        Console.Write("Altitude = ");
        double altitude = ReadDouble();
        double area = (side * altitude) / 2;
        return area;
    }

    private static double ThreeSides()
    {
        Console.Write("First side = ");
        double side1 = ReadDouble();
        Console.Write("second side = ");
        double side2 = ReadDouble();
        Console.Write("Third side = ");
        double side3 = ReadDouble();
        double s = (side1 + side2 + side3)*0.5;
        double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        return area;
    }

    private static double TwoSidesAndAnAngleBetweenThem()
    {
        Console.Write("First side = ");
        double side1 = ReadDouble();
        Console.Write("Second side = ");
        double side2 = ReadDouble();
        Console.Write("Angle = ");
        double angle;
        while (true)
        {
            angle = ReadDouble();
            if (angle > 0 && angle < Math.PI/2)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Angle should be in radians.");
            }
        }
        double area = Math.Sin(angle) * side1 * side2 * 0.5;
        return area;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Calculate surface of triangele. Chose btween:");
        Console.WriteLine("1. Side and altidude to it.");
        Console.WriteLine("2. Three sides.");
        Console.WriteLine("3. Two sides and an angle btween them.");
        Console.WriteLine("1, 2 or 3?");
        double? area = null;
        string choice = Console.ReadLine();
        switch (choice.ToUpper())
        {
            case "1":
                {
                    area = SideAndAltitudeToIt();
                    break;
                }
            case "2":
                {
                    area = ThreeSides();
                    break;
                }
            case "3":
                {
                    area = TwoSidesAndAnAngleBetweenThem();
                    break;
                }
            default:
                break;
        }
        Console.WriteLine("Area = {0}", area);
    }
}