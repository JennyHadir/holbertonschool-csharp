
using System;
using System.Collections.Generic;

/// <summary>VectorMath class</summary>
public class VectorMath
{
    ///<summary> Magnitude methode to calculat the magnitude of a vector</summary>
    ///<param name="vector"> Vector to calculat it magnitude</param>
    ///<return> magnitude </return>
    public static double Magnitude(double[] vector)
    {
        double magnitude = 0;
        if (vector.Length > 3 || vector.Length < 2)
            return (-1);
        foreach (var coordinat in vector)
        {
            magnitude += (coordinat * coordinat);
        }
        return Math.Round(Math.Sqrt(magnitude), 2);
    }
}