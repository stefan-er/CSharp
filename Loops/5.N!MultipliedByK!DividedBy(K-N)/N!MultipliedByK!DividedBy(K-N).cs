using System;
using System.Numerics;

class NFacMultipliedByKFacDividedBy
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

        else if (N >= K)
        {
            Console.WriteLine("N should be < K");
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

            Console.WriteLine("N!*K!/(K-N) = " + NFactoiral * KFactoiral / (K - N));
        }
    }
}