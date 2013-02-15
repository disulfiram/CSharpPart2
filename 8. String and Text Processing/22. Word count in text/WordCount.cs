using System;

class WordCount
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input text:");
        string inputText = Console.ReadLine();
        char[] separators = { ' ', '.', ',', '!', '?', '-' };
        string[] inputTextArray = inputText.Split(separators);
        int[] wordCount = new int[inputTextArray.Length];
        for (int word = 0; word < inputTextArray.Length; word++)
        {
            for (int wordChek = word+1; wordChek < inputTextArray.Length; wordChek++)
            {
                if (inputTextArray[word] == inputTextArray[wordChek])
                {
                    wordCount[word]++;
                    inputTextArray[wordChek] = null;
                }
            }
            if (inputTextArray[word] == null)
            {
                break;
            }
            Console.WriteLine("{1} - {0}", inputTextArray[word], wordCount[word]+1);
        }
    }
}