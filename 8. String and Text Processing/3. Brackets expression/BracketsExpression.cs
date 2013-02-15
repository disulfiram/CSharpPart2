using System;

class BracketsExpression
{
    static void Main(string[] args)
    {
        Console.Write("Input an expression: ");
        string expression = Console.ReadLine();
        int counter = 0;
        for (int symbol = 0; symbol < expression.Length; symbol++)
        {
            if (expression[symbol] == '(')
            {
                counter++;
            }
            if (expression[symbol] == ')')
            {
                counter--;
            }
            if (counter <0)
            {
                Console.WriteLine("The brackets are not put correctly!");
                break;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("The brackets are put correctly.");
        }
    }
}