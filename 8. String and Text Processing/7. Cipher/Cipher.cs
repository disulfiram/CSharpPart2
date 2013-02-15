using System;

class Cipher
{
    private static string EncodeText(string inputText, string key)
    {
        char[] encodedTextInChars = new char[inputText.Length];
        int keyCounter = 0;
        for (int letter = 0; letter < inputText.Length; letter++)
        {
            encodedTextInChars[letter] = (char)(inputText[letter]^key[keyCounter]);
            keyCounter++;
            if (keyCounter == key.Length)
            {
                keyCounter = 0;
            }
        }
        string encodedText = new string(encodedTextInChars);
        return encodedText;
    }

    static void Main(string[] args)
    {
        Console.Write("Input text to encode: ");
        string inputText = Console.ReadLine();
        Console.Write("Input key: ");
        string key = Console.ReadLine();
        string encodedText = EncodeText(inputText, key);
        Console.WriteLine("{0} is the encoded text",encodedText);
        string decodedText = EncodeText(encodedText, key);
        Console.WriteLine(decodedText);
    }
}