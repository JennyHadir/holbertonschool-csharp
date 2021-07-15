using System;
using System.Collections.Generic;
class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int data = 0;
        if (myLList.First != null)
        {
            data = myLList.First.Value;
            myLList.RemoveFirst();
        }
        return data;
    }
}
