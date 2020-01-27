using System;

namespace _02_Print_Matrix
{
    class Program
    {
        static void Main()
        {
            //declare and initialize a matrix of size 2 x 4
            int[,] matrix =
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8}
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                //first - row 0; col 0; 1; 2; 3
                //second - row 1; col 0; 1; 2; 3
                Console.WriteLine();
            }
        }   
    }
}
