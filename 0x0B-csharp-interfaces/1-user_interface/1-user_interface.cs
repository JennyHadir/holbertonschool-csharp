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

/// Interactive interface
public interface IInteractive
{
    /// Interact methode
    void Interact();
}

/// Breakable interface
public interface IBreakable
{
    /// Durability prop
    int durability { get; set; }

    /// Break method
    void Break();
}

/// Collectable interface
public interface ICollectable
{
    /// IsCollected prop
    bool isCollected { get; set; }

    /// Collect method
    void Collect();
}

/// TestObject Base
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// Drability implementation
    public int durability { get; set; }
    /// isCollected implementation
    public bool isCollected { get; set;} 

    /// Interact method implementation
    public void Interact()
    {
    }

    /// Break method implementation
    public void Break()
    {
    }

    /// Collect method implementation
    public void Collect()
    {
    }
}