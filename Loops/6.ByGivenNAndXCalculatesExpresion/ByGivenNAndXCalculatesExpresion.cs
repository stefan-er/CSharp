using System;
using System.Numerics;

class ByGivenNAndXCalculatesExpresion
{
    static void Main()
    {
        Console.Write("Enter N: ");
        double N = double.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        double X = double.Parse(Console.ReadLine());

        double NFactoiral = 1;
        double XOnPwerN = 1;
        double S = 1;

        for (int i = 1; i <= N; i++)
        {
            NFactoiral *= i;
            XOnPwerN *= X;
            S += NFactoiral / XOnPwerN;
        }

        Console.WriteLine("The sum S is: " + S);
    }
}