﻿using System;
using System.Collections.Generic;
class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int counter = 0;
        foreach (var item in myLList)
        {
            if (index == counter)
            {
                myLList.Remove(item);
                return;
            }
            counter++;
        }
    }
}
