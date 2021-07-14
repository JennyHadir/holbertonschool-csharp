using System;
using System.Collections.Generic;
class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        foreach (var item in myDict)
        {
            if (item.Key == key)
            {
                myDict.Remove(key);
                break;
            }
        }
        return myDict;
    }
}