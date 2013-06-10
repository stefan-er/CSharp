using System;

class SumOfFibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter how many members of Fibonacci sequence you want to add: ");
        int n = int.Parse(Console.ReadLine());
        decimal a = 0;
        decimal b = 1;
        decimal c = new decimal();
        decimal sum = a + b;

        for (int i = 1; i <= (n - 2); i++)
        {
            c = a + b;
            sum += c;
            a = b;
            b = c;
        }
        Console.WriteLine(sum);
    }
}