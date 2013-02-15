using System;

class Palindromes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input text:");
        string inputText = Console.ReadLine();
        char[] separators = { ' ', '.', ',', '!', '?', '-' };
        string[] inputTextArray = inputText.Split(separators);
        bool[] polindromes = new bool[inputTextArray.Length];
        for (int word = 0; word < inputTextArray.Length; word++)
        {
            for (int letter = 0; letter < inputTextArray[word].Length / 2; letter++)
            {
                if (inputTextArray[word][letter] != inputTextArray[word][inputTextArray[word].Length - 1 - letter])
                {
                    polindromes[word] = false;
                    break;
                }
                else
                {
                    polindromes[word] = true;
                }
            }
            if (polindromes[word])
            {
                Console.WriteLine(inputTextArray[word]);
            }
        }
    }
}