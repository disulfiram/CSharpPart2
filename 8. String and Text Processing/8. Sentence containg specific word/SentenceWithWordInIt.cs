using System;

class SentenceWithWordInIt
{
    private static void PrintSentence(int firstLetter, string inputText)
    {
        char[] separators = {'.'};
        string[] sentences = inputText.Split(separators);
        int placeInText = 0;
        for (int sentenceNumber = 0; sentenceNumber < sentences.Length; sentenceNumber++)
        {
            if (firstLetter > placeInText)
            {
                placeInText += sentences[sentenceNumber].Length;
            }
            else
            {
                Console.WriteLine(sentences[sentenceNumber-1]);
                break;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Input text to look in: ");
        string inputText = Console.ReadLine();
        Console.Write("Input word to look for: ");
        string wordLookingFor = Console.ReadLine();
        string[] words = inputText.Split(' ');
        int counter = 0;
        for (int wordNumber = 0; wordNumber < words.Length; wordNumber++)
        {
            if (words[wordNumber].ToUpper() == wordLookingFor.ToUpper() || words[wordNumber].ToUpper() == wordLookingFor.ToUpper()+".")
            {
                PrintSentence(counter, inputText);
            }
            counter += words[wordNumber].Length+1;
        }
    }
}