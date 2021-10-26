using System;

/// Abstract Base class
public abstract class Base
{
    /// Name
    public string name { get; set; }

    /// <summary>Override method</summary>
    public override string ToString()
    {
        return (name + " is a " + this.GetType());
    }

}

/// <summary>Interactive interface</summary>
public interface IInteractive
{
    /// <summary>Interact methode</summary>
    void Interact();
}

/// <summary>Breakable interface</summary>
public interface IBreakable
{
    /// <summary>Durability prop</summary>
    int durability { get; set; }

    /// <summary>Break method</summary>
    void Break();
}

/// <summary>Collectable interface</summary>
public interface ICollectable
{
    ///<summary> IsCollected prop</summary>
    bool isCollected { get; set; }

    /// <summary>Collect method</summary>
    void Collect();
}

/// <summary>TestObject Base</summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary> Drability implementation</summary>
    public int durability { get; set; }
    /// <summary>isCollected implementation</summary>
    public bool isCollected { get; set;} 


    /// <summary>Interact method implementation</summary>
    public void Interact()
    {
    }

    /// <summary>Break method implementation</summary>
    public void Break()
    {
    }

    /// <summary>Collect method implementation</summary>
    public void Collect()
    {
    }
}