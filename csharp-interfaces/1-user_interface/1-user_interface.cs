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
    int durability {  get; set; }

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
/// A class called 'TestObject' that inherits from 'Base' and all three interfaces.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{

    /// <summary>
    /// Property from IBreakable interface.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Property from ICollectable interface.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Method from IInteractive interface.
    /// </summary>
    public void Interact()
    {
        // Method implementation can be left empty
    }

    /// <summary>
    /// Method from IBreakable interface.
    /// </summary>
    public void Break()
    {
        // Method implementation can be left empty
    }

    /// <summary>
    /// Method from ICollectable interface.
    /// </summary>
    public void Collect()
    {
        // Method implementation can be left empty
    }

}
