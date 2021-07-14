using System;

class Array
{
        public static int[] CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            int [] narray = new int [size];
            if (size == 0)
            {
                Console.WriteLine();
                return narray;
            }
            else
            {
                for (int i = 0; i < narray.Length; i++)
                {
                    narray[i] = i;
                    Console.Write(narray[i] + " ");
                }
                Console.WriteLine();
                return narray;
            }
        }
}
