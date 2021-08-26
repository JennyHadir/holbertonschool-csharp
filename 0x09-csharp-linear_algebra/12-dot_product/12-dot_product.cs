using System;
using System.Collections.Generic;

///<summary> VectorMath class</summary>
class VectorMath
{
    ///<summary> DotProduct methode to calculat the dot product of two vectors</summary>
    ///<param name="vector1"> Vector 1</param>
    ///<param name="vector2"> Vector 2</param>
    ///<return> Dot product value </return>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double DotValue = -1;
        if (vector1.Count == vector2.Count)
        {
            if (vector2.Count == 2 || vector2.Count == 3)
            { 
                DotValue++;
                for (int i = 0; i < vector1.Count; i++)
                {
                    DotValue += Math.Round((vector1[i] * vector2[i]), 3);
                }
            }
        }
        return DotValue;
    }
}
