using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] multiArray = new int [5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    multiArray[i, j] = 0;
                }
            }
            multiArray[2, 2] = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(multiArray[i, j]);
                    if (j != 4)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
