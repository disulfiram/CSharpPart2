using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5___Two_is_Better_Than_One
{
    class Program
    {
        private static byte[] DecToBin(long number)
        {
            byte[] BinArray = new byte[64];     
            for (int bit = 0; bit < BinArray.Length; bit++)
            {
                BinArray[bit] = (byte)(number % 2);
                number /= 2;
            }
            //for (int i = FindPositionOfFirstNonZeroBit(BinArray); i >= 0; i--)
            //{
            //    Console.Write(BinArray[i]);
            //}
            //Console.WriteLine();
            return BinArray;
        }

        private static bool CheckIfMirror(byte[] binArray)
        {
            int positionOfFirstOne = FindPositionOfFirstNonZeroBit(binArray);
            //for (int i = FindPositionOfFirstNonZeroBit(binArray); i >= 0; i--)
            //    {
            //        Console.Write(binArray[i]);
            //    }
            //    Console.WriteLine();
            if (positionOfFirstOne == -1)
            {
                return false;
            }
            for (int bit = 0; bit < (positionOfFirstOne/2); bit++)
            {
                if (binArray[bit] != (binArray[positionOfFirstOne-bit]))
                {
                    return false;
                }
            }
            return true;
        }

        private static int FindPositionOfFirstNonZeroBit(byte[] binArray)
        {
            for (int positionOfFirsOne = binArray.Length - 1; positionOfFirsOne >= 0; positionOfFirsOne--)
            {
                if (binArray[positionOfFirsOne] == 1)
                {
                    return positionOfFirsOne;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            string rangeInput = Console.ReadLine();
            char firstSeparator = (' ');
            string[] rangeStrings = new string[2];
            rangeStrings = rangeInput.Split(firstSeparator);
            long[] range = new long[2];
            range[0] = long.Parse(rangeStrings[0]);
            range[1] = long.Parse(rangeStrings[1]);
            int counter = 0;
            for (long number = range[0]; number <= range[1]; number++)
            {
                byte[] binArray = DecToBin(number);
                bool isMirror = CheckIfMirror(binArray);
                if (isMirror == true)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}