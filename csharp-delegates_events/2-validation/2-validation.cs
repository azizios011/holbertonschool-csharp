using System;

/// <summary>
/// A class called 'Player' with the following.
/// </summary>
public class Player
{
    /// <summary>
    /// A Properties 'name' string.
    /// </summary>
    private string name;

    /// <summary>
    /// A Properties 'maxHp' float.
    /// </summary>
    private float maxHp;

    /// <summary>
    /// A Properties 'hp' float.
    /// </summary>
    private float hp;

    /// <summary>
    /// Delegate to handle health calculations.
    /// </summary>
    /// <param name="amount">The amount of damage or healing.</param>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health of the player.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// Prints the current health of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Takes damage and adjusts the player's health.
    /// </summary>
    /// <param name="damage">The amount of damage taken.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }

        Console.WriteLine($"{name} takes {damage} damage!");

        // Calculate new health and validate it
        float newHp = hp - damage;
        ValidateHP(newHp);
    }

    /// <summary>
    /// Heals damage and adjusts the player's health.
    /// </summary>
    /// <param name="heal">The amount of health restored.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }

        Console.WriteLine($"{name} heals {heal} HP!");

        // Calculate new health and validate it
        float newHp = hp + heal;
        ValidateHP(newHp);
    }

    /// <summary>
    /// Validates and sets the player's health.
    /// </summary>
    /// <param name="newHp">The new health value to validate.</param>
    private void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }
}
