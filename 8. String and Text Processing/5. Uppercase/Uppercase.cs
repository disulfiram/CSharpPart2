//You are given a text. Write a program that changes the text in all regions surrounded 
//by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 

using System;

class Uppercase
{
    static int PrintUpercase(int word, string[] arrayOfStrings)
    {
        int upperWord;
        for (upperWord = word; upperWord < arrayOfStrings.Length; upperWord++)
        {
            if (arrayOfStrings[upperWord] == "/upcase")
            {
                return upperWord;
            }
            else
            {
                Console.Write(arrayOfStrings[upperWord].ToUpper()+" ");
            }
        }
        return upperWord;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Input string to edit:");
        string inputString = Console.ReadLine();
        char[] separators = { ' ', '<', '>' };
        string[] arrayOfStrings = inputString.Split(separators);
        //for (int index = 0; index < arrayOfStrings.Length; index++)
        //{
        //    Console.WriteLine(arrayOfStrings[index]);
        //}
        for (int word = 0; word < arrayOfStrings.Length; word++)
        {
            if (arrayOfStrings[word] == "upcase")
            {
                word++;
                word = PrintUpercase(word, arrayOfStrings);
            }
            else
            {
                Console.Write(arrayOfStrings[word]+" ");
            }
        }
    }
}