﻿using System;
using System.Collections.Generic;
class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {

        if (index >= myList.Count || index < 0)
            Console.WriteLine("Index out of range");
        else
            myList.Remove(myList[index]);
        return myList;
    }
}