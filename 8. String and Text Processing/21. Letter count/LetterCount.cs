using System;

class LetterCount
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input string:");
        string inputText = Console.ReadLine();
        char[] inputTextLetters = inputText.ToCharArray();
        int[] letterCount = new int[inputTextLetters.Length];
        for (int letters = 0; letters < inputTextLetters.Length; letters++)
        {
            for (int letterCheck = letters + 1; letterCheck < inputTextLetters.Length; letterCheck++)
            {
                if (inputTextLetters[letters] == inputTextLetters[letterCheck])
                {
                    letterCount[letters]++;
                    inputTextLetters[letterCheck] = '@';
                }
            }
            if (inputTextLetters[letters] == '@')
            {
                break;
            }
            Console.WriteLine("{1} - {0}", inputTextLetters[letters], letterCount[letters]+1);
        }
    }
}