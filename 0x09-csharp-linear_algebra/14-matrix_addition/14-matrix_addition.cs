using System;

///<summary> MatrixMath class</summary>
public class MatrixMath
{
    ///<summary>Add method to add two matrix with the same size</summary>
    ///<param name="matrix1"> matrix1</param>
    ///<param name="matrix2"> matrix2</param>
    ///<return> matrix result of the addition of two matrix </return>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(0) == 2 && matrix2.GetLength(1) == 2)
        {
            double[,] matrix3 = {
                {0, 0},
                {0, 0}
            }; 
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix3;
        }
        else if (matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(0) == 3 && matrix2.GetLength(1) == 3)
        {
            double[,] matrix3 = {
                {0, 0, 0},
                {0, 0, 0},
                {0, 0, 0}
            }; 
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix3;
        }
        return new double[,] {{-1}};
    }
}
