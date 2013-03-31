using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Problem_1____Durankulan_Numbers;

namespace Problem1DurankilakNumbers
{
    class Durankulak
    {
        //public static string[] Digits = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
        //                                  "aA", "aB", "aC", "aD", "aE", "aF", "aG", "aH", "aI", "aJ", "aK", "aL", "aM", "aN", "aO", "aP", "aQ", "aR", "aS", "aT", "aU", "aV", "aW", "aX", "aY", "aZ",
        //                                  "bA", "bB", "bC", "bD", "bE", "bF", "bG", "bH", "bI", "bJ", "bK", "bL", "bM", "bN", "bO", "bP", "bQ", "bR", "bS", "bT", "bU", "bV", "bW", "bX", "bY", "bZ",
        //                                  "cA", "cB", "cC", "cD", "cE", "cF", "cG", "cH", "cI", "cJ", "cK", "cL", "cM", "cN", "cO", "cP", "cQ", "cR", "cS", "cT", "cU", "cV", "cW", "cX", "cY", "cZ",
        //                                  "dA", "dB", "dC", "dD", "dE", "dF", "dG", "dH", "dI", "dJ", "dK", "dL", "dM", "dN", "dO", "dP", "dQ", "dR", "dS", "dT", "dU", "dV", "dW", "dX", "dY", "dZ",
        //                                  "eA", "eB", "eC", "eD", "eE", "eF", "eG", "eH", "eI", "eJ", "eK", "eL", "eM", "eN", "eO", "eP", "eQ", "eR", "eS", "eT", "eU", "eV", "eW", "eX", "eY", "eZ",
        //                                  "fA", "fB", "fC", "fD", "fE", "fF", "fG", "fH", "fI", "fJ", "fK", "fL", "fM", "fN", "fO", "fP", "fQ", "fR", "fS", "fT", "fU", "fV", "fW", "fX", "fY", "fZ", };

        //static string[] Digits = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
        //                           "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
        //                           "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b",
        //                           "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c",
        //                           "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d",
        //                           "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e",
        //                           "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", "f", };

        //static char[] Digits = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
        //                         'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a',
        //                         'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b',
        //                         'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c',
        //                         'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd', 'd',
        //                         'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e', 'e',
        //                         'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', 'f', };

        static char[] Digits = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                 'a', 'b', 'c', 'd', 'e', 'f' };

        //private static byte[] ConvertToDigits(string[] duranNumberInChars)
        //{
        //    byte[] ArrayOfDigits = new byte[duranNumberInChars.Length];
        //    for (int position = 0; position < duranNumberInChars.Length; position++)
        //    {
        //        ArrayOfDigits[position] = (byte)Array.BinarySearch(Digits, duranNumberInChars[position]);
        //        Console.WriteLine("Position {0} - {1} value", position, ArrayOfDigits[position]); //used this to check results of the method
        //    }
        //    return ArrayOfDigits;
        //}

        private static int[] ConvertToDigits(char[] numberInArrayOfStrings)
        {
            int[] arrayOfDigits = new int[numberInArrayOfStrings.Length];
            for (int position = 0; position < numberInArrayOfStrings.Length; position++)
            {
                arrayOfDigits[position] = Array.BinarySearch(Digits, numberInArrayOfStrings[position]);
                if (arrayOfDigits[position] > 25)
                {
                    arrayOfDigits[position] = (26 * (arrayOfDigits[position] - 25));
                }
                //Console.WriteLine("Position {0} - {1} value", position, ArrayOfDigits[position]); //used this to check results of the method
            }
            return arrayOfDigits;
        }

        static void Main(string[] args)
        {
            string duranNumber = Console.ReadLine();
            char[] duranNumberInChars = duranNumber.ToCharArray();
            //byte[] realNumber[];
            //for (int digit = duranNumberInChars.Length-1; digit >= 0 ; digit--)
            //{
            //    Console.WriteLine((int)duranNumberInChars[digit]-65);
            //}
            BigInteger Number = 0;
            int[] numberInBytes = ConvertToDigits(duranNumberInChars);
            for (int i = 0; i < numberInBytes.Length / 2; i++)
            {
                //Console.WriteLine("index {0} - {1}", i, NumberInBytes[i]);
                int temp = numberInBytes[i];
                numberInBytes[i] = numberInBytes[numberInBytes.Length - i - 1];
                numberInBytes[numberInBytes.Length - i - 1] = temp;
                //Console.WriteLine("index {0} - {1}", i, NumberInBytes[i]);
            }
            int pow = 0;
            for (int digit = 0; digit < numberInBytes.Length; digit++)
            {

                BigInteger singleDigit = 0;
                if (numberInBytes.Length % 2 != 0 && digit == numberInBytes.Length - 1)
                {
                    singleDigit = (numberInBytes[digit] * (BigInteger)Math.Pow(168, pow));
                }
                else
                {
                    BigInteger tempNumber = numberInBytes[digit] + numberInBytes[digit + 1];
                    singleDigit = (tempNumber * (BigInteger)Math.Pow(168, pow));
                    digit++;
                }

                Number += singleDigit;
                pow++;
            }
            Console.WriteLine(Number);
        }
    }
}