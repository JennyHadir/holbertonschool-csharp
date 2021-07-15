using System;
using System.Collections.Generic;
using System.Linq;
class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int nodeData = 0;
        if (n < myLList.Count && n > 0)
        {
            nodeData = myLList.ElementAt(n);
        }
        return nodeData;
    }
}
