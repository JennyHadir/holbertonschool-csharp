using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length <= 0)
            Console.WriteLine();
        else
        {
            for (int i = 0; i < length; i++)
            {    
            if (i == length - 1)
                Console.WriteLine("_");
            Console.Write("_");
            }
        } 
    }
}
