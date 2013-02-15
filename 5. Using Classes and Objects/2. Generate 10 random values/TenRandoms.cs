using System;

class TenRandoms
{
    static void Main(string[] args)
    {
        Random randomGenerator2 = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomGenerator2.Next(100) + 100);
        }
    }
}