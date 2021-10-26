using System;

/// Abstract Base class
public abstract class Base
{
    /// Name
    public string name;

    /// Override method
    public override string ToString()
    {
        return (name + " is a " + this.GetType());
    }

}

