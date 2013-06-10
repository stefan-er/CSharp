using System;
using System.Numerics;

class TrailingZerosOfFactoriel
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactoriel = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactoriel *= i;
        }

        BigInteger remainder = 0;
        int divider = 10;
        var count = -1;
        
        while (remainder == 0) 
        {

            remainder = nFactoriel % divider;
            nFactoriel = nFactoriel / divider;
            count++;
        }

        Console.WriteLine("The trailing zeroes are: " + count);
    }
}