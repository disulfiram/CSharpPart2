using System;
using System.Collections.Generic;
using System.IO;

class ListOfStrings
{
    static void Main(string[] args)
    {
        Console.WriteLine("Change list.txt in the debug folder and press Enter.");
        Console.ReadLine();
        StreamReader ReadListOfStrings = new StreamReader("list.txt");
        List<string> ListOfNames = new List<string>();
        using (ReadListOfStrings)
        {
                
            string Current = "0";
            while (Current != null)
            {
                Current = ReadListOfStrings.ReadLine();
                ListOfNames.Add(Current);
            }
             
        }
        ListOfNames.Sort();
        StreamWriter WriteSortedNames = new StreamWriter("result.txt");
        using (WriteSortedNames)
        {
            for (int index = 1; index < ListOfNames.Count; index++)
            {
                WriteSortedNames.WriteLine("{0}. {1}", index, ListOfNames[index]);
            }
        }
    }
}