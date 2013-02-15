using System;

class HexToDec
{
    static string[] Digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

    private static void TransformStringToBits(string Number, byte[] HexArray)
    {
        for (int position = 0; position < Number.Length; position++)
        {
            string HexString = Number[Number.Length - position -1].ToString();
            //string BitString = Encoding.ASCII.GetString(Number[HexArray.Length-1-position]);
            //string HexString = new String(Number[HexArray.Length - 1 - position], 8);
            if (HexString == "0" || HexString == "1" || HexString == "2" || HexString == "3" || HexString == "4" || HexString == "5" || HexString == "6" || HexString == "7" || HexString == "8" || HexString == "9")
            {
                bool fail = byte.TryParse(HexString, out HexArray[position]);
            }
            else
            {
                switch (HexString.ToUpper())
                {
                    case "A":
                        {
                            HexArray[position] = 10;
                            break;
                        }
                    case "B":
                        {
                            HexArray[position] = 11;
                            break;
                        }
                    case "C":
                        {
                            HexArray[position] = 12;
                            break;
                        }
                    case "D":
                        {
                            HexArray[position] = 13;
                            break;
                        }
                    case "E":
                        {
                            HexArray[position] = 14;
                            break;
                        }
                    case "F":
                        {
                            HexArray[position] = 15;
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }

    private static int CalculateTheInteger(byte[] HexArray)
    {
        int Number = 0;
        for (int position = 0; position < HexArray.Length; position++)
        {
            Number += HexArray[position] * (int)Math.Pow(16, position);
        }
        return Number;
    }

    static void Main(string[] args)
    {
        //for sanity's sake I will make it with integers of byte type.
        Console.WriteLine("Input 8 symbol hexidecimal number: ");
        string Number = Console.ReadLine();
        byte[] HexArray = new byte[8];
        TransformStringToBits(Number, HexArray);
        int DecNumber = CalculateTheInteger(HexArray);
        Console.WriteLine(DecNumber);
    }
}