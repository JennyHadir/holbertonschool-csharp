using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k = 1;
            for (i = 0; i < 9; i++)
            {
                for (j = k; j < 10; j++)
                {
                    if (j == 9 && i == 8)
                        Console.WriteLine("{0}{1}", i, j);
                    else
                        Console.Write("{0}{1}, ", i, j);
                }
                k = k + 1;
            }
        }
    }
}
