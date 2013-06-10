using System;

class GCDOfTwoNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        if (secondNumber > firstNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;           
        }

        int remainder = 1;
        int dividend = firstNumber;
        int divider = secondNumber;

        while (remainder != 0)
        {
            remainder = dividend % divider;
            dividend = divider;
            divider = remainder;
        }

        Console.WriteLine("GCD is: " + dividend);
    }
}