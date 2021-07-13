using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char alphabet = 'a'; alphabet <= 'z'; alphabet++)
            {
                if (alphabet == 'q' || alphabet == 'e')
                    alphabet++;
                Console.Write(alphabet);
            }
        }
    }
}
