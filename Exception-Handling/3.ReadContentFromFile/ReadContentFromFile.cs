using System;
using System.IO;
using System.Text;
using System.Security;

class ReadContentFromFile
{
    static void Main()
    {
        string path = @"..\..\..\SomeText.txt";
        try
        {
            Console.WriteLine(File.ReadAllText(path));
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Path is null");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("path is a zero-length string, contains only white space, or contains one or more invalid characters");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Path specified a file that is read-only");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission");
        }
    }
}