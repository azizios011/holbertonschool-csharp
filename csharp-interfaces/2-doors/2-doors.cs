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
