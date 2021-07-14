using System;
using System.Collections.Generic;
class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
           Console.WriteLine("List is empty");
           return -1;
        }
        int max = myList[0];
        for (int index = 0; index < myList.Count; index++)
        {
            if (max < myList[index])
                max = myList[index];
        }
        return max;
    }
}