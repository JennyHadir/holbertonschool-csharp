using System;
using System.Collections.Generic;
class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        int i;
        LinkedList<int> linked = new LinkedList<int>();
        if (size > 0)
        {
            for (i = 0; i < size; i++)
            {
                linked.AddLast(i);
            }
            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }
        }
        return linked;
    }
}
