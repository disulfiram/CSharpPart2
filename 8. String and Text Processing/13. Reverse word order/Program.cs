//To implement correct sign positioning.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input string: ");
        string inputText = Console.ReadLine();
        char[] separators = { ' ' };
        string[] inputTextArray = inputText.Split(separators);
        for (int word = inputTextArray.Length-1; word >= 0; word--)
        {
            Console.Write(inputTextArray[word]+" ");
        }
        //for (int word = 0; word < inputTextArray.Length; word++)
        //{
        //    char[] wordInChars = inputTextArray[word].ToCharArray();
        //    if (wordInChars[wordInChars.Length - 1] == '.' || wordInChars[wordInChars.Length - 1] == ',')
        //    {

        //    }
        //}
    }
}