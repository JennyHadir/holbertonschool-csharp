using System;
using System.Collections.Generic;

///<summary> VectorMath class</summary>
class VectorMath
{
    ///<summary> Add methode to add two vectors</summary>
    ///<param name="vector1"> Vector 1</param>
    ///<param name="vector2"> Vector 2</param>
    ///<return> Vector 3 containing the addition of two vector </return>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        List<double> vector3 = new List<double>();
        vector3[0] = -1;
        if (vector1.Count == vector2.Count)
        {
            if (vector1.Count == 3 || vector1.Count == 2)
            {
                for (int i = 0; i < vector2.Count; i++)
                    vector3[i] = Math.Round((vector1[i] + vector2[i]), 3);
            }
        }
        return vector3;
    }
}
