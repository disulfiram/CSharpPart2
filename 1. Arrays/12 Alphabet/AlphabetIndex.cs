using System;

class AlphabetIndex
{

    static char[] AlphabetChar(int Begin)
    {
        char[] Alphabet = new char[26];
        for (int i = 0; i < Alphabet.Length; i++)
        {
            Alphabet[i] = (char)(i + Begin);
        }
        return Alphabet;
    }

    static int[] BinarySearchIndex(char Leter, char[] AlphabetChar, int[] BinarySearchArray)
    {
        if (Leter == AlphabetChar[BinarySearchArray[2]])
        {
            BinarySearchArray[0] = BinarySearchArray[2];
            return BinarySearchArray;
        }
        if (Leter > AlphabetChar[BinarySearchArray[2]])
        {
            BinarySearchArray[1] = BinarySearchArray[2];     //min=mid
            BinarySearchArray[2] = (BinarySearchArray[1] + BinarySearchArray[3]) / 2;
            return BinarySearchArray;
        }
        else
        {
            BinarySearchArray[3] = BinarySearchArray[2];    //max=mid
            BinarySearchArray[2] = (BinarySearchArray[1] + BinarySearchArray[3]) / 2;
            return BinarySearchArray;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Write something.");
        char[] AlphabetUpper = AlphabetChar(65);
        char[] AlphabetLower = AlphabetChar(97);
        //for (int i = 0; i < AlphabetLower.Length; i++)
        //{
        //    Console.WriteLine("{0} - {1}", AlphabetUpper[i], AlphabetLower[i]);
        //}
        string ConsoleInput = Console.ReadLine();
        int[] BinarySearchArray = new int[4];

        for (int index = 0; index < ConsoleInput.Length; index++)
        {
            BinarySearchArray[0] = -1;      //used to find index of char
            BinarySearchArray[1] = 0;       //min index
            BinarySearchArray[2] = 12;      //mid index
            BinarySearchArray[3] = 25;      //max index
            if (char.IsLower(ConsoleInput[index]))
            {
                while (BinarySearchArray[0] < 0)
                {
                    BinarySearchArray = BinarySearchIndex(ConsoleInput[index], AlphabetLower, BinarySearchArray);
                }
                Console.WriteLine("Letter {0} is number {1} and is Lowercase", ConsoleInput[index], BinarySearchArray[0] + 1);
            }
            else
            {
                while (BinarySearchArray[0] < 0)
                {
                    BinarySearchArray = BinarySearchIndex(ConsoleInput[index], AlphabetUpper, BinarySearchArray);
                }
                Console.WriteLine("Letter {0} is number {1} and is Uppercase", ConsoleInput[index], BinarySearchArray[0] + 1);
            }
            BinarySearchArray[0] = -1;
        }
    }
}