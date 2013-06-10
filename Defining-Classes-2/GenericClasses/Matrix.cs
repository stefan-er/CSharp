namespace GenericClasses
{
    using System;
    using System.Collections.Generic;

    public class Matrix<T>
        where T : IComparable<T>, new()
    {
        const int defaultRows = 1024;
        const int defaultCols = 1024;

        private T[,] elements;

        public Matrix(int rows, int cols)
        {
            this.elements = new T[rows, cols];
        }

        public Matrix()
            : this(defaultRows, defaultCols)
        { 
        }

        public int Rows
        {
            get { return this.elements.GetLength(0); }
        }

        public int Cols
        {
            get { return this.elements.GetLength(1); }
        }

        public T this[int row, int col]
        {
            get 
            {
                if (row >= this.elements.GetLength(0))
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid row: {0}.", row));
                }
                else if (col >= this.elements.GetLength(1))
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid column: {0}.", col));
                }

                return this.elements[row, col];
            }
            set 
            {
                if (row >= this.elements.GetLength(0))
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid row: {0}.", row));
                }
                else if (col >= this.elements.GetLength(1))
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid column: {0}.", col));
                }

                this.elements[row, col] = value;
            }
        }

        public static Matrix<T> operator +(dynamic matrix1, Matrix<T> matrix2)
        {
            if (matrix1.GetType() != typeof(Matrix<T>))
            {
                throw new FormatException(String.Format("The first element should be from class Matrix<T>"));
            }
            if (matrix1.Rows != matrix2.Rows && matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("The matrices are not of the same size");
            }
            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(dynamic matrix1, Matrix<T> matrix2)
        {
            if (matrix1.GetType() != typeof(Matrix<T>))
            {
                throw new FormatException(String.Format("The first element should be from class Matrix<T>"));
            }
            if (matrix1.Rows != matrix2.Rows && matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("The matrices are not of the same size");
            }
            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, dynamic matrix2)
        {
            if (matrix2.GetType() != typeof(Matrix<T>))
            {
                throw new FormatException(String.Format("The first element should be from class Matrix<T>"));
            }
            if (matrix1.Cols != matrix2.Rows)
            {
                throw new ArgumentException("The matrices are not conformed");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix2.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    T sell = new T();
                    for (int k = 0; k < matrix1.Cols; k++)
                    {
                        sell += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sell;
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            if (matrix.GetType() != typeof(Matrix<T>))
            {
                throw new FormatException(String.Format("The first element should be from class Matrix<T>"));
            }

            T defaultTValue = new T();
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j].CompareTo(defaultTValue) != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            if (matrix.GetType() != typeof(Matrix<T>))
            {
                throw new FormatException(String.Format("The first element should be from class Matrix<T>"));
            }

            T defaultTValue = new T();
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j].CompareTo(defaultTValue) != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
