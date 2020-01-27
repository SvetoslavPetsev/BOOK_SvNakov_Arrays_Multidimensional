using System;

namespace _05_Jagged_Array // nazubeni masivi
{
    class Program
    {
        static void Main()
        {
            //declaration:
            int[][] jaggedArray;
            jaggedArray = new int[2][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];

            //declaration and initailaization:
            int[][] myJaggedArray =
            {
                new int[] { 5, 7, 2 },
                new int[] { 10, 20, 40 },
                new int[] { 2, 35 }
            };
            //two-dimensional jagged array
            int[][,] jaggedMultyArray = new int[2][,];
            jaggedMultyArray[0] = new int[,]
            {
                { 5, 25 },
                { 125, 206 }
            };
            jaggedMultyArray[1] = new int[,] 
            {
                { 3, 4, 5 },
                { 7, 8, 9 }
            };
        }
    }
}
