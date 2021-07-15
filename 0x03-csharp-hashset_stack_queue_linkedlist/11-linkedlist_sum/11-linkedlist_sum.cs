using System;
using System.Collections.Generic;
class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int num = 0;
        foreach (var item in myLList)
        {
            num = num + item;    
        }
        return num;
    }
}
