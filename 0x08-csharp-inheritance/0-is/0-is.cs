using System;

///<summary> Obj class</summary>
class Obj
{
    ///<summary> Check if obj of type int or not</summary>
    ///<param name="obj">Object to check</param>
    ///<return>True if obj is of type int false otherwise</return>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return true;
        return false;
    }
}

