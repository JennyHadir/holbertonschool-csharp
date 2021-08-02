using System;
using System.Collections.Generic;

///<summary> Obj class</summary>
class Obj
{
    ///<summary> Check if obj is an instance or an instance of a class that inherited from Array</summary>
    ///<param name="obj">Object to check</param>
    ///<return>True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False.</return>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        return false;
    }
}

