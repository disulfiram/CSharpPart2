using System;

class BinToDec
{
    private static void TransformStringToBits(string Number, byte[] ArrayOfBits)
    {
        for (int bit = 0; bit < 8; bit++)
        {
            //string BitString = Encoding.ASCII.GetString(Number[ArrayOfBits.Length-1-bit]);
            string BitString = new String(Number[ArrayOfBits.Length - 1 - bit], 1);
            bool fail = byte.TryParse(BitString, out ArrayOfBits[bit]);
        }
    }

    private static int CalculateTheInteger(byte[] ArrayOfBits)
    {
        int Number = 0;
        for (int bit = 0; bit < ArrayOfBits.Length; bit++)
        {
            Number += ArrayOfBits[bit] * (byte)Math.Pow(2, bit);
        }
        if (ArrayOfBits[ArrayOfBits.Length-1]==0)
        {
            return Number;
        }
        else
        {
            return (Number - Byte.MaxValue-1);
        }
    }

    static void Main(string[] args)
    {
        //for sanity's sake I will make it with integers of byte type.
        Console.WriteLine("Input 8 bit binary number(8th bit is MSB): ");
        string Number = Console.ReadLine();
        byte[] ArrayOfBits = new byte[8];
        TransformStringToBits(Number, ArrayOfBits);
        int DecNumber = CalculateTheInteger(ArrayOfBits);
        Console.WriteLine(DecNumber);
    }
}