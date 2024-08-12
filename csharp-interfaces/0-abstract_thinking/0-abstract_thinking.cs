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
