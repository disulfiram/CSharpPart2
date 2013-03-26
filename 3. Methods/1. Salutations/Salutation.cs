using System;

class Salutation
{
    static void Salute(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("What's your name? (smily face)");
        string name = Console.ReadLine();
        Salute(name);
    }
}