using System;
using System.Collections.Generic;


class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int res = 0;
        List<int> divList = new List<int>();
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                res = list1[i] / list2[i];
                divList.Add(res);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                divList.Add(0);
            }
            catch(System.Exception)
            {
                Console.WriteLine("Out of range");
            }
        }
        return divList;
    }
}

