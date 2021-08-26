﻿using System;
using System.Collections.Generic;

///<summary> VectorMath class</summary>
class VectorMath
{
    ///<summary> Multiply methode to multiply a vector and a scalar</summary>
    ///<param name="vector1"> Vector 1</param>
    ///<param name="scalar"> scalar multipliar </param>
    ///<return> Vector 3 containing the multiplication of a vector and a scalar </return>
    public static double[] Multiply(double[] vector, double scalar)
    {
        List<double> vector3 = new List<double>();
        vector3[0] = -1;

        if (vector.Count == 3 || vector.Count == 2)
        {
            for (int i = 0; i < vector.Count; i++)
            {
                vector3[i] = Math.Round((vector[i] * scalar), 3);
            }
        }
        return vector3;
    }
}
