using System;

///<summary>  Create new class called Queue</summary>
public class Queue<T>
{
    /// Returns the Queue's Type
    public Type CheckType()
    {
        return typeof(T);
    }
}
