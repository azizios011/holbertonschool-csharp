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
    /// A delegate 'CalculateHealth' that takes a float amount.
    /// </summary>
    /// <param name="amount"></param>
    public delegate void CalculateHealth(float amount);

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
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// A Methodto print health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// A Method to take damage.
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }

        Console.WriteLine($"{name} takes {damage} damage!");

        hp = Math.Max(hp - damage, 0);
    }

    /// <summary>
    /// A Method to heal damage.
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }

        Console.WriteLine($"{name} heals {heal} HP!");

        hp = Math.Min(hp + heal, maxHp);
    }
}
