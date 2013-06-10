using System;

class SquareRootOfInteger
{
    static void Main()
    {
        try
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }               
            Console.WriteLine(Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid integer number");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine();
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}