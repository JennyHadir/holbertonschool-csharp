using System;
using System.Collections.Generic;
class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> VerifList = new List<bool>();
        for (int index = 0; index < myList.Count; index++)
        {
            if (myList[index] % 2 == 0)
                VerifList.Add(true);
            else
                VerifList.Add(false);
        }
        return VerifList;
    }
}