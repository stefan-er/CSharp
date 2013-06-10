using System;

class ReadNumberInRange
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            try
            {
                NumberInRange(1, 10);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }

    public static void NumberInRange(int start, int end)
    {
        Console.Write("Enter a number in [{0}, {1}]: ", start, end);
        int number = int.Parse(Console.ReadLine());
        if (number < start || number > end)
        {
            throw new System.ArgumentOutOfRangeException("The number is not in the given interval", new ArgumentOutOfRangeException());
        }
        Console.WriteLine("The number is: " + number);
    }
}