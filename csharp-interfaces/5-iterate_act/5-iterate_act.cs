using System;

/// <summary>
/// An abstract class called 'Base' containing the following.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Public property 'name'.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Override 'ToString()' method to return the following.
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// An interface called IInteractive.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Method void Interact()
    /// </summary>
    void Interact();
}

/// <summary>
/// An interface called IBreakable
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// durability should be an int.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// method void Break().
    /// </summary>
    void Break();
}

/// <summary>
/// An interface called ICollectable.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// isCollected should be a bool/
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Method void Collect()
    /// </summary>
    void Collect();
}

/// <summary>
/// A class called Door that inherits from 'Base' and 'IInteractive'.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// A constructor that sets the value of name.
    /// </summary>
    public Door(string name = "Door")
    {
        // if 'name' isn’t provided, the default value should be Door.
        this.name = name;
    }

    /// <summary>
    /// implement Interact() so that it prints.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// A class called Decoration that inherits from 'Base', 'IInteractive', and 'IBreakable'.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// A public bool isQuestItem.
    /// </summary>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// A public bool durability.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// A constructor that sets the value of name, durability, and isQuestItem.
    /// </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// implement Interact().
    /// </summary>
    public void Interact()
    {

        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }

        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }

        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary>
    /// implement Break() so that it decrements durability by 1.
    /// </summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }

        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }

        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// A class called Key that inherits from 'Base' and 'ICollectable'.
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// The method declaration should use name and isCollected as the parameter names.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// A constructor that sets the value of name and isCollected.
    /// </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// implement Collect().
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
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
/// A class called RoomObjects.
/// </summary>
public class RoomObjects
{
    /// <summary>
    /// A method called IterateAction. This method should take a list of all objects.
    /// </summary>
    /// <param name="roomObjects"></param>
    /// <param name="type"></param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base obj in roomObjects)
        {
            if (type == typeof(IInteractive) && obj is IInteractive interactive)
            {
                interactive.Interact();
            }
            else if (type == typeof(IBreakable) && obj is IBreakable breakable)
            {
                breakable.Break();
            }
            else if (type == typeof(ICollectable) && obj is ICollectable collectable)
            {
                collectable.Collect();
            }
        }
    }
}
