using System;
using System.IO;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter file address. There is a default file. To access, just type: TEST.exe");
        string Address = Console.ReadLine();    //"TEST.txt";
        string contents = null;
        try
        {
            contents = System.IO.File.ReadAllText(Address);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("1");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Argument exception. Enter valid path.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Dierctory not found");
        }
        catch (IOException)
        {
            Console.WriteLine("5");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access denied");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Not supported file");
        }
        catch (SecurityException)
        {
            Console.WriteLine("8");
        }
        Console.WriteLine(contents);
    }
}