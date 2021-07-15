using System;
using System.Collections.Generic;
using System.Linq;
class List
{
    public static int Sum(List<int> myList)
    {
        int all = 0;
        List<int> uniqueList = myList.Distinct().ToList();
        foreach (var item in uniqueList)
        {
            all = all + item;
        }
        return all;
    }
}
