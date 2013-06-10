namespace GenericClasses
{
    using System;
    using System.Collections.Generic;

    class ConsoleTests
    {
        static void Main()
        {
            //GenericList<int> list = new GenericList<int>(2);
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);
            //list.Add(7);

            //list.Remove(1);

            //list.Insert(8, 1);

            ////list.Clear();

            //Console.WriteLine(list.Count);
            //Console.WriteLine();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //Console.WriteLine(list.Find(8));
            //Console.WriteLine(list.Find(2));

            //Console.WriteLine(list.ToString());

            //Console.WriteLine(GenericList<int>.Min<int>(list));
            //Console.WriteLine(GenericList<int>.Max<int>(list));

            //Matrix<int> matrix1 = new Matrix<int>(3, 5);
            //matrix1[0, 0] = 2;
            //matrix1[0, 1] = 3;

            //Matrix<int> matrix2 = new Matrix<int>(3, 5);
            //matrix2[0, 0] = 3;
            //matrix2[0, 1] = 5;

            //Matrix<int> matrix = matrix2 + matrix1;
            //Matrix<int> matrix = matrix2 - matrix1;

            //for (int i = 0; i < matrix.Rows; i++)
            //{
            //    for (int j = 0; j < matrix.Cols; j++)
            //    {
            //        Console.Write(matrix[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //Matrix<int> matrix1 = new Matrix<int>(3, 2);
            //matrix1[0, 0] = 1;
            //matrix1[0, 1] = 3;
            //matrix1[1, 0] = 0;
            //matrix1[1, 1] = -2;
            //matrix1[2, 0] = 4;
            //matrix1[2, 1] = 1;

            //Matrix<int> matrix2 = new Matrix<int>(2, 3);
            //matrix2[0, 0] = 7;
            //matrix2[0, 1] = 9;
            //matrix2[0, 2] = 1;
            //matrix2[1, 0] = 5;
            //matrix2[1, 1] = 2;
            //matrix2[1, 2] = 1;

            //Matrix<int> matrix = matrix1 * matrix2;

            //for (int i = 0; i < matrix.Rows; i++)
            //{
            //    for (int j = 0; j < matrix.Cols; j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            Matrix<int> matrix3 = new Matrix<int>(8, 8);
            //matrix3[7, 7] = 1;
            if (matrix3)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
