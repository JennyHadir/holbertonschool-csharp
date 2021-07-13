using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
            Console.WriteLine();
        else
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < i; i++)
                    Console.Write(" ");
                Console.WriteLine("H");
            }
        }
    }
}
