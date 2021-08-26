using System;
using System.Collections.Generic;

///<summary> VectorMath class</summary>
public class VectorMath
{
    ///<summary> DotProduct methode to calculat the dot product of two vectors</summary>
    ///<param name="vector1"> Vector 1</param>
    ///<param name="vector2"> Vector 2</param>
    ///<return> Dot product value </return>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double DotValue = -1;
        if (vector1.Length == vector2.Length)
        {
            if (vector2.Length == 2 || vector2.Length == 3)
            { 
                DotValue++;
                for (int i = 0; i < vector1.Length; i++)
                {
                    DotValue += Math.Round((vector1[i] * vector2[i]), 2);
                }
            }
        }
        return DotValue;
    }
}
