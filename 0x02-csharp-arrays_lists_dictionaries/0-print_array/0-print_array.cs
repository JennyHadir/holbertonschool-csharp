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
        for (int i = 0; i < narray.Length; i++)
        {
            narray[i] = i;
            Console.Write(narray[i]);
            if (i != size - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
        return narray;
    }
}
