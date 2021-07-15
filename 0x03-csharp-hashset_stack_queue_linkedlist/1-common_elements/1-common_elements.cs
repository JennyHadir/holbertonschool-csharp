using System;
using System.Collections.Generic;
class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> nList = list1;
        for (int i = 0; i < list1.Count; i++)
        {
            if (!list2.Contains(list1[i]))
                nList.Remove(list1[i]);
        }
        nList.Sort();
        return nList;
    }
}