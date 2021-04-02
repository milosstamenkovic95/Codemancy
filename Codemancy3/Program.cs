using System;

namespace Codemancy3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Input the dimensions of the matrix: " + Environment.NewLine);
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[x, y];

            Console.Write("Input elements in the matrix : " + Environment.NewLine);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write(Environment.NewLine + Environment.NewLine + "The matrix is : " + Environment.NewLine);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(Environment.NewLine);
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0}\t", matrix[i, j]);
            }

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "Matrix represented as array: " + Environment.NewLine);
            int[] array = MatrixToArray(matrix);
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString() + " ");
            }
        }

        private static int[] MatrixToArray(int[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            var array1d = new int[rows * cols];
            var current = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array1d[current++] = matrix[i, j];
                }
            }
            return array1d;
        }
    }
}
