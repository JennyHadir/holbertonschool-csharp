using System;

class Array
{
        public static int[] CreatePrint(int size)
        {
            int [] narray = new int [size];
            if (size == 0)
            {
                Console.WriteLine();
            }
            else if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            else
            {
                for (int i = 0; i < narray.Length; i++)
                {
                    narray[i] = i;
                    Console.Write(narray[i] + " ");
                }
                Console.WriteLine();
            }
            return narray;
        }
}
