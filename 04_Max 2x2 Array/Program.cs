using System;

namespace _04_Max_2x2_Array
{
    class Program
    {
        static void Main()
        {
            //Declare and initialize the matrix

            int[,] matrix =
            {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 }
            };
            // Find the maximal platform 2 x 2
            int maxSum = int.MinValue;
            int[,] maxMatrix = new int[2, 2];
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxMatrix[0, 0] = matrix[row, col];
                        maxMatrix[0, 1] = matrix[row, col + 1];
                        maxMatrix[1, 0] = matrix[row + 1, col];
                        maxMatrix[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }
            Console.WriteLine("The best platform is: ");
            for (int row = 0; row < maxMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < maxMatrix.GetLength(1); col++)
                {
                    Console.Write(" " + maxMatrix [row, col]);
                }
                Console.WriteLine();
            }
            Console.Write("The maximal sum is: {0}", maxSum);

        }
    }
}
