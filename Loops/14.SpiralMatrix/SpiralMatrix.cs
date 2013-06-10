using System;

class SpiralMatrix
{
    static void Main()
    {

        /* The program is using variables to observe when some row or column from the matrix is already full.
         * These variables are "startRowIndex", "endRowIndex", "startColIndex" and "endColIndex" of which we set initial values.
         * After every loop we change these values to mark when some row or column is already filled up.*/

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[,] matrix = new int[number, number];
        int startRowIndex = 0;
        int startColIndex = 0;
        int endRowIndex = number - 1;
        int endColIndex = number - 1;
        int count = 1;

        do
        {
            for (int i = startColIndex; i <= endColIndex; i++) //right filling
            {
                matrix[startRowIndex, i] = count;
                count++;
            }
            startRowIndex++;

            for (int i = startRowIndex; i <= endRowIndex; i++) //down filling
            {
                matrix[i, endColIndex] = count;
                count++;
            }
            endColIndex--;

            for (int i = endColIndex; i >= startColIndex; i--) //left filling
            {
                matrix[endRowIndex, i] = count;
                count++;
            }
            endRowIndex--;

            for (int i = endRowIndex; i >= startRowIndex; i--) //up filling
            {
                matrix[i, startColIndex] = count;
                count++;
            }
            startColIndex++;

        } while (count <= number * number);


        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0,4}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }
}
