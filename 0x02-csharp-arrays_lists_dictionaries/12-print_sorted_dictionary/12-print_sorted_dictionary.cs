using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var list = myDict.Keys.ToList();
        list.Sort();
        foreach (var key in list)
            Console.WriteLine("{0}: {1}", key, myDict[key]);
    }
}