using System;
using System.Collections.Generic;

///<summary> Obj class</summary>
class Obj
{
    ///<summary> Check if obj is a subclass</summary>
    ///<param name="derivedType">Type of Object to check</param>
    ///<param name="baseType">Type of base</param>
    ///<return>True if the object is a subclass, otherwise return False.</return>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if ((derivedType).IsSubclassOf (baseType))
            return true;
        return false;
    }
}

