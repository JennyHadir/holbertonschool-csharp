using System;
using System.Collections.Generic;

///<summary> VectorMath class</summary>
class VectorMath
{
    ///<summary> Multiply methode to multiply a vector and a scalar</summary>
    ///<param name="vector"> Vector 1</param>
    ///<param name="scalar"> scalar multipliar </param>
    ///<return> Vector 3 containing the multiplication of a vector and a scalar </return>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] vector3 = new double[vector.Length];

        if (vector.Length == 3 || vector.Length == 2)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector3[i] = Math.Round((vector[i] * scalar), 2);
            }
            return vector3;    
        }
        return new double [] { -1};
    }
}
