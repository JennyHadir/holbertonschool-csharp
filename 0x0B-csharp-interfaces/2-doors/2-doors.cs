using System;

/// Abstract Base class
public abstract class Base
{
    /// Name
    public string name;

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
    /// <summary>IsCollected prop</summary>
    bool isCollected { get; set; }

    /// <summary>Collect method</summary>
    void Collect();
}

/// <summary>TestObject Base</summary>
public class Door : Base, IInteractive
{

    ///<summary> Door Constructor</summary>
    ///<param name="name"></param>
    public Door(string name="Door")
    {
        this.name = name;
    }
    /// <summary>Interact method implementation</summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the " + this.name + ". It's locked.");
    }
}