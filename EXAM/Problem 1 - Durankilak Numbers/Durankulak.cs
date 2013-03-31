using System;
using System.Numerics;

namespace Problem1DurankilakNumbers
{
    class Durankulak
    {
        static char[] Digits =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'
        };
        static bool check;
    
        private static int[] ConvertToDigits(char[] numberInArrayOfStrings)
        {
            int[] arrayOfDigits = new int[numberInArrayOfStrings.Length];
            for (int position = 0; position < numberInArrayOfStrings.Length; position++)
            {
                arrayOfDigits[position] = Array.BinarySearch(Digits, numberInArrayOfStrings[position]);
                if (arrayOfDigits[position] > 25)
                {
                    check = true;
                    arrayOfDigits[position] = (26 * (arrayOfDigits[position] - 25));
                }
            }
            return arrayOfDigits;
        }

        static void Main(string[] args)
        {
            string duranNumber = Console.ReadLine();
            char[] duranNumberInChars = duranNumber.ToCharArray();
            
            BigInteger number = 0;
            int[] numberInBytes = ConvertToDigits(duranNumberInChars);
            for (int i = 0; i < numberInBytes.Length / 2; i++)
            {
                int temp = numberInBytes[i];
                numberInBytes[i] = numberInBytes[numberInBytes.Length - i - 1];
                numberInBytes[numberInBytes.Length - i - 1] = temp;
            }
          
            int pow = 0;
            for (int digit = 0; digit < numberInBytes.Length; digit++)
            {
                BigInteger singleDigit = 0;
                if (numberInBytes.Length % 2 != 0 && digit == numberInBytes.Length - 1)
                {
                    singleDigit = (numberInBytes[digit] * (BigInteger)Math.Pow(168, pow));
                }
                else if (numberInBytes[digit + 1] < 26)
                {
                    singleDigit = 
                }
                {
                    BigInteger tempNumber = numberInBytes[digit] + numberInBytes[digit + 1];
                    singleDigit = (tempNumber * (BigInteger)Math.Pow(168, pow));
                    digit++;
                }
                number += singleDigit;
                pow ++;
            }
            Console.WriteLine(number);
        }
    }
}