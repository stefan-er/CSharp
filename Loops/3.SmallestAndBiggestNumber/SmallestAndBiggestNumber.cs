using System;

class SmallestAndBiggestNumber
{
    static void Main()
    {
        Console.Write("Enter how many elements you will compare: ");
        int N = int.Parse(Console.ReadLine());
        int[] n = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter {0} element: ", i);
            n[i] = int.Parse(Console.ReadLine());
        }

        int smallestNumber = n[0];
        for (int i = 0; i < N; i++)
        {
            if (n[i] < smallestNumber)
            {
                smallestNumber = n[i];
            }
        }

        int biggestNumber = n[0];
        for (int i = 0; i < N; i++)
        {
            if (n[i] > biggestNumber)
            {
                biggestNumber = n[i];
            }
        }

        Console.WriteLine("The smallest number is: " + smallestNumber);
        Console.WriteLine("The biggest number is: " + biggestNumber);
    }
}