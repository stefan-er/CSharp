using System;

class WriteAMatrix
{
    static void Main()
    {
        Console.Write("Enter a number from 1 to 20: ");
        int N = int.Parse(Console.ReadLine());

        while (N < 1 || N > 20)
        {
            Console.WriteLine("Error");
            Console.Write("Enter a number from 1 to 20: ");
            N = int.Parse(Console.ReadLine());
        }

        int[,] matrix = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N + 0; j++)
            {
                matrix[i, j] = i + j + 1;
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}