using System;
using System.Numerics;

class NFacDividedByKFac
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        BigInteger NFactoiral = 1;
        BigInteger KFactoiral = 1;

        if (N <= 0 || K <= 0)
        {
            Console.WriteLine("Enter positive numbers");
        }

        else if (K >= N)
        {
            Console.WriteLine("K should be < N");
        }

        else
        {
            for (int i = 1; i <= N; i++)
            {
                NFactoiral *= i;
            }

            for (int i = 1; i <= K; i++)
            {
                KFactoiral *= i;
            }

            Console.WriteLine("N!/K! = " + NFactoiral / KFactoiral);
        }
    }
}