using System;
using System.Collections.Generic;
class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = -1;
        if (myLList.Contains(value))
        {
            index++;
            foreach (var item in myLList)
            {
                if (item == value)
                    break;
                index++;
            }
        }
        return index;
    }
}
