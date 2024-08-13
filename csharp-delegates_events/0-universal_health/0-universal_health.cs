using System;

/// <summary>
/// A class called 'Player' with the following.
/// </summary>
public class Player
{
    /// <summary>
    /// A Properties 'name' string.
    /// </summary>
    string name;

    /// <summary>
    /// A Properties 'maxHp' float.
    /// </summary>
    float maxHp;

    /// <summary>
    /// A Properties 'hp' float.
    /// </summary>
    float hp;

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
