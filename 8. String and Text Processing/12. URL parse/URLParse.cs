using System;

class URLParse
{
    static void Main(string[] args)
    {
        Console.Write("Input URL: ");
        string url = Console.ReadLine();
        char[] separators = { ':', '/' };
        string[] splitURL = url.Split(separators);
        Console.WriteLine("[protocol] = {0}", splitURL[0]);
        Console.WriteLine("[server] = {0}", splitURL[3]);
        Console.Write("[resource] = ");
        for (int i = 4; i < splitURL.Length; i++)
        {
            Console.Write("/"+splitURL[i]);
        }
        Console.WriteLine();
    }
}