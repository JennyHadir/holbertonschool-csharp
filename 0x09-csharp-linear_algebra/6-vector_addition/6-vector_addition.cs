using System;

///<summary> VectorMath class</summary>
class VectorMath
{
    ///<summary> Add methode to add two vectors</summary>
    ///<param name="vector1"> Vector 1</param>
    ///<param name="vector2"> Vector 2</param>
    ///<return> Vector 3 containing the addition of two vector </return>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] vector3 = { 0, 0};
            for (int i = 0; i < vector2.Length; i++)
                vector3[i] = (vector1[i] + vector2[i]);
            return vector3;
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] vector3 = {0, 0, 0};
            for (int i = 0; i < vector2.Length; i++)
                vector3[i] = (vector1[i] + vector2[i]);
            return vector3;
        }
        return new double[] { -1};
    }
}
