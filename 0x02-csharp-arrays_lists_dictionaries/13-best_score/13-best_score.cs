using System;
using System.Collections.Generic;
using System.Linq;
class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = -1;
        string biggest = "None";
        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > max)
                {
                    max = entry.Value;
                    biggest = entry.Key;
                }
        }
        return biggest;
    }
}