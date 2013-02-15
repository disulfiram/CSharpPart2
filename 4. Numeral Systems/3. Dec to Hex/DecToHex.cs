using System;

class DecToHex
{
    static uint ReadInts()       //Reads integers from console.
    {
        while (true)
        {
            uint Integer;
            string Value = Console.ReadLine();
            bool Result = uint.TryParse(Value, out Integer);
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

    private static byte[] TransformedNumber(uint Number)
    {
        byte[] HexArray = new byte[8];
        for (int position = 0; position < HexArray.Length - 1; position++)
        {
            HexArray[position] = (byte)(Number % 16);
            Number /= 16;
        }
        return HexArray;
    }

    private static void PrintArray(byte[] HexArray)
    {
        for (int position = 7; position >= 0; position--)
        {
            if (HexArray[position] >= 0 && HexArray[position] < 10)
            {
                Console.Write(HexArray[position]);
            }
            if (HexArray[position]>9 && HexArray[position]<16)
            {
                switch (HexArray[position])
                {
                    case 10:
                        {
                            Console.Write("A");
                            break;
                        }
                    case 11:
                        {
                            Console.Write("B");
                            break;
                        }
                    case 12:
                        {
                            Console.Write("C");
                                break;
                        }
                    case 13:
                        {
                            Console.Write("D");
                            break;
                        }
                    case 14:
                        {
                            Console.Write("E");
                            break;
                        }
                    case 15:
                        {
                            Console.Write("F");
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Input integer: ");
        uint Number = ReadInts();
        byte[] HexArray = new byte[8];
        HexArray = TransformedNumber(Number);
        PrintArray(HexArray);
    }
}