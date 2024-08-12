using System;
using System.Collections.Generic;
/// <summary>
/// IInteractive: Interface
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interact(): method
    /// </summary>
    void Interact();
}

/// <summary>
/// IBreakable: Interface
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// durability: property
    /// </summary>
    int durability { get; set; }
    /// <summary>
    /// Break(): method
    /// </summary>
    void Break();
}

/// <summary>
/// ICollectable: intefrace
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// isCollected: property
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect(): method
    /// </summary>
    void Collect();
}

/// <summary>
/// Base: Class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// name property: string
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Override string
    /// </summary>
    /// <returns>formated string</returns>
    public override string ToString()
    {
        return $"{name} is a {GetType()}";
    }
}

/// <summary>
/// Door: class that inherits from the "Base" class and the previous "Interactive" interfaces
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="doorName">Default name of the door</param>
    public Door(string doorName = "Door")
    {
        name = doorName;
    }


    /// <summary>
    /// Implement the method of the "Interact" interface
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary> decoration class </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary> field </summary>
    public int _durability;

    /// <summary> constructor </summary>
    /// <param name="name"> </param>
    /// <param name="durability"> </param>
    /// <param name="isQuestItem"> </param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 0)
            throw new System.Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary> durability </summary>
    public int durability
    {
        get { return _durability; }
        set
        {
            _durability = value;
        }
    }

    /// <summary> isQuestItem </summary>
    public bool isQuestItem { get; set; }

    /// <summary> inteact methode </summary>
    public void Interact()
    {
        if (durability <= 0)
            System.Console.WriteLine($"The {name} has been broken.");
        else
        {
            if (isQuestItem)
                System.Console.WriteLine($"You look at the {name}. There's a key inside.");
            else
                System.Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary> break methode </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            System.Console.WriteLine($"You hit the {name}. It cracks.");
        if (durability == 0)
            System.Console.WriteLine($"You smash the {name}. What a mess.");
        if (durability < 0)
            System.Console.WriteLine($"The {name} is already broken.");
    }
}


/// <summary>
/// Class that inherits from the Base class and the ICollectable Interface
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">string</param>
    /// <param name="isCollected">boolean</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// isCollected: boolean parameter
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Implement Collect()
    /// </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}


/// <summary>
/// Class
/// </summary>
public class RoomObjects
{
    /// <summary>
    /// method that takes a list of all objects, iterates through it, and executes methods depending on what interface that item implements. 
    /// </summary>
    /// <param name="roomObjects"></param>
    /// <param name="type"></param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var obj in roomObjects)
        {
            if (obj is IInteractive && type == typeof(IInteractive))
                (obj as IInteractive).Interact();
            if (obj is IBreakable && type == typeof(IBreakable))
                (obj as IBreakable).Break();
            if (obj is ICollectable && type == typeof(ICollectable))
                (obj as ICollectable).Collect();
        }
    }
}
