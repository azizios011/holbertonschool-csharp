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
    /// Delegate for health calculations.
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
    /// Applies damage to the player.
    /// </summary>
    /// <param name="damage">The amount of damage to apply.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }

        Console.WriteLine($"{name} takes {damage} damage!");
        float newHp = hp - damage;
        ValidateHP(newHp);
    }

    /// <summary>
    /// Heals the player.
    /// </summary>
    /// <param name="heal">The amount of healing to apply.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }

        Console.WriteLine($"{name} heals {heal} HP!");
        float newHp = hp + heal;
        ValidateHP(newHp);
    }

    /// <summary>
    /// Validates and sets the player's health.
    /// </summary>
    /// <param name="newHp">The new health value to set.</param>
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

    /// <summary>
    /// Applies a modifier to a base value.
    /// </summary>
    /// <param name="baseValue">The base value to modify.</param>
    /// <param name="modifier">The type of modifier to apply.</param>
    /// <returns>The modified value.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue / 2;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                throw new ArgumentOutOfRangeException(nameof(modifier), modifier, null);
        }
    }
}

/// <summary>
/// Defines different types of modifiers.
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak modifier.
    /// </summary>
    Weak,

    /// <summary>
    /// Base modifier.
    /// </summary>
    Base,

    /// <summary>
    /// Strong modifier.
    /// </summary>
    Strong
}

/// <summary>
/// A a delegate CalculateModifier.
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
