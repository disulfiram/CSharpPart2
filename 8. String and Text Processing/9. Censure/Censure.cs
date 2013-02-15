using System;

class Censure
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input text to censure:");
        string inputText = Console.ReadLine();
        Console.WriteLine("Input words you wish to censure: ");
        string wrongWords = Console.ReadLine().ToUpper();
        char[] separators = { ' ' };
        string[] arrayOfWrongWords = wrongWords.Split(separators);
        string[] wordsInInputText = inputText.Split(separators);
        for (int wordInInputText = 0; wordInInputText < wordsInInputText.Length; wordInInputText++)
        {
            string currentWord = null;
            for (int wordWrongWords = 0; wordWrongWords < arrayOfWrongWords.Length; wordWrongWords++)
            {
                if (arrayOfWrongWords[wordWrongWords] == wordsInInputText[wordInInputText].ToUpper() || arrayOfWrongWords[wordWrongWords] + "." == wordsInInputText[wordInInputText].ToUpper() || arrayOfWrongWords[wordWrongWords] + "!" == wordsInInputText[wordInInputText].ToUpper() || arrayOfWrongWords[wordWrongWords] + "?" == wordsInInputText[wordInInputText].ToUpper() || arrayOfWrongWords[wordWrongWords] + "," == wordsInInputText[wordInInputText].ToUpper() || arrayOfWrongWords[wordWrongWords] + "-" == wordsInInputText[wordInInputText].ToUpper())
                {
                    currentWord = null;
                    for (int letter = 0; letter < arrayOfWrongWords[wordWrongWords].Length; letter++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");
                    break;
                }
                else
                {
                    currentWord = wordsInInputText[wordInInputText] + " ";
                }
            }
            Console.Write(currentWord);
        }
        Console.WriteLine();
    }
}