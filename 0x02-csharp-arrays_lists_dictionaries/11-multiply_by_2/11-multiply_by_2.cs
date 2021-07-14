using System;
using System.Collections.Generic;
class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> DoubleDict = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> pair in myDict)
        {
            DoubleDict[pair.Key] = pair.Value * 2;
        }
        return DoubleDict;
    }
}