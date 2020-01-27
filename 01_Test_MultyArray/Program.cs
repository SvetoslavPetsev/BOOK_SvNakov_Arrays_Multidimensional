using System;

namespace _01_Test_MultyArray
{
    class Program
    {
        static void Main()
        { //two-dimensional array /matrix
            int[,] twoDMatrix = 
            {
                { 1, 2, 3, 4 }, //row 0
                { 5, 6, 7, 8 } //row 1
            };
            Console.WriteLine(twoDMatrix[0,1]);

            // tree - dimensional array/ amtrix

            int[,,] treeDMatrix =
            {
                {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 }
                },
                {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 }
                }
            };
        }
    }
}
