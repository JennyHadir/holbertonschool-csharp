using System;

///<summary>Shape class</summary>
class Shape
{
    ///<summary>Throw an exception</summary>
    ///<return></return>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
