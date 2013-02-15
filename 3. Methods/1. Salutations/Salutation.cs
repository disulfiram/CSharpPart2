using System;

class Salutation
{
    static void Salute(string Name)
    {
        Console.WriteLine("Hello, {0}!", Name);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("What's your name? (smily face)");
        string Name = Console.ReadLine();
        Salute(Name);
    }
}