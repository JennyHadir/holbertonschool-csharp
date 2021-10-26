using System;
using System.Collections.Generic;

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

/// <summary>Door class</summary>
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

///<summary> Decoration class</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// isQuestItem prop
    public bool isQuestItem { get; set; }

    /// durability prop
    public int durability { get; set; }

    ///<summary> Decoration constructor</summary>
    ///<param name="name"></param>
    ///<param name="durability"></param>
    ///<param name="isQuestItem"></param>
    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false)
    {
        this.name = name;
        if (durability <= 0)
        {
            throw new Exception ("Durability must be greater than 0");
        }
        else
        {
            this.durability = durability;
            this.isQuestItem = isQuestItem;
            this.name = name;
        }
    }

    /// <summary>Interact method implementation</summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The " + this.name + " has been broken.");
        else 
        {
            if (isQuestItem == true)
                Console.WriteLine("You look at the " + this.name + ". There's a key inside.");
            else
                Console.WriteLine("You look at the " + this.name + ". Not much to see here.");
        }
    }

    ///<summary> Break Method implementation</summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine("You hit the "+ this.name + ". It cracks.");
        else if (durability == 0)
            Console.WriteLine("You smash the "+ this.name + ". What a mess.");
        else
            Console.WriteLine("The "+ this.name + " is already broken.");
    }
}

///<summary> Key class</summary>
public class Key : Base, ICollectable
{
    /// isCollected prop
    public bool isCollected { get; set; }

    ///<summary>Key Constructor</summary>
    ///<param name="name"></param>
    ///<param name="isCollected"></param>
    public Key(string name="Key", bool isCollected=false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    ///<summary>Collect method implementation</summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine("You pick up the "+ this.name + ".");
        }
        else
            Console.WriteLine("You have already picked up the " + this.name + ".");
    }
}

///<summary> RoomObjects class</summary>
public class RoomObjects
{
    ///<summary>Execute methods depending on what interface tha item implements</summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var cls in roomObjects)
        {
            if (type == typeof(IInteractive))
            {
                if (cls is IInteractive)
                {
                    IInteractive clas = (IInteractive)cls;
                    clas.Interact();
                }
            }
            else if (type == typeof(IBreakable))
            {
                if (cls is IBreakable)
                {
                    IBreakable clas = (IBreakable)cls;
                    clas.Break();
                }
            }
            else if (type == typeof(ICollectable))
            {
                if (cls is ICollectable)
                {
                    ICollectable clas = (ICollectable) cls;
                    clas.Collect();
                }
            }
        }
    }
}