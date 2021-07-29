using System;

namespace MyMath
{
    /// <summary> Matrix class </summary>
    public class Matrix
    {
        /// <summary> Divise a all matrix element by integer </summary>
        /// <param name="matrix"> matrix to divise its elements </param>
        /// <param name="num"> divisor </param>
        /// <returns> new matrix contains the division result </returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix is null)
                return null;
            try
            {
                int[,] NewMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        NewMatrix[i, j] = (matrix[i, j] / num);
                    }

                }
                return (NewMatrix);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }
        }
    }
}
