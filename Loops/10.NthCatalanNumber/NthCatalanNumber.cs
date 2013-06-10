using System;
using System.Numerics;

class NthCatalanNumber
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger catalanNumber = (Factoriel(2*n)) / (Factoriel(n+1)*Factoriel(n));

        Console.WriteLine("The {0} Catalan number is: {1}", n, catalanNumber);

    }

    static BigInteger Factoriel (int number) 
    {
        BigInteger numberFactoriel = 1;

        for (int i = 1; i <= number; i++)
        {
            numberFactoriel *= i;
        }

        return numberFactoriel;
    }
}