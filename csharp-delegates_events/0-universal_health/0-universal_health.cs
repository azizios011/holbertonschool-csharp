using System;

/// <summary>
/// A class called 'Player' with the following.
/// </summary>
public class Player
{
    /// <summary>
    /// A Propertie 'name' string.
    /// </summary>
    private string name;

    /// <summary>
    /// A Propertie 'maxHp' float.
    /// </summary>
    private float maxHp;

    /// <summary>
    /// A Propertie 'hp' float.
    /// </summary>
    private float hp;

    /// <summary>
    /// A Constructor.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default..");
        }

        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// A Method.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}