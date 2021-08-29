using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector = { -2, 1, 8 };
        double[] result;

        result = VectorMath.Multiply(vector, -4);

        // Console.WriteLine("(" + result[0] + ", " + result[1] + ")");
        Console.WriteLine("(" + result[0] + ", " + result[1] + ", " + result[2] + ")");
        // Console.WriteLine("(" + result[0] + ")");
    }
}