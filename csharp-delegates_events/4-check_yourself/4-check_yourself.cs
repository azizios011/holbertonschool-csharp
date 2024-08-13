using System;

/// <summary>
/// Player class contains player's informations.
/// </summary>
public class Player
{
    /// Player's name.
    private string name;
    /// Player's maximum health points.
    private float maxHp;
    /// Player's current health points.
    private float hp;
    /// Player's status.
    private string status;

    /// <summary>
    /// Player's class constructor.
    /// </summary>
    /// <param name="name">Player's name</param>
    /// <param name="maxHp">Player's maximum health points.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        hp = this.maxHp;
        status = $"{this.name}  is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Print's player's current health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// CalculateHealth delegate.
    /// </summary>
    /// <param name="amount">Amout of heal or damage to be used.</param>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Prints a message when player takes damage.
    /// </summary>
    /// <param name="damage">Damage amount.</param>
    public void TakeDamage(float damage)
    {
        float newHp;

        newHp = hp;

        if (damage >= 0)
        {
            Console.WriteLine($"{name} takes {damage} damage!");
            newHp -= damage;
        }
        else
            Console.WriteLine($"{name} takes 0 damage!");
        ValidateHP(newHp);
    }

    /// <summary>
    /// Prints a message when player heals damage.
    /// </summary>
    /// <param name="heal">Heal amount.</param>
    public void HealDamage(float heal)
    {
        float newHp;

        newHp = hp;

        if (heal >= 0)
        {
            Console.WriteLine($"{name} heals {heal} HP!");
            newHp += heal;
        }
        else
            Console.WriteLine($"{name} heals 0 HP!");
        ValidateHP(newHp);
    }

    /// <summary>
    /// Sets the new value of the Player’s hp
    /// </summary>
    /// <param name="newHp">The new health points amount.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            newHp = 0;

        if (newHp > maxHp)
            newHp = maxHp;

        hp = newHp;
        OnCheckStatus(new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Applies a modifier to a value.
    /// </summary>
    /// <param name="baseValue"></param>
    /// <param name="modifier"></param>
    /// <returns>The value after being multiplied by a modifier.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return default(float);
        }
    }

    /// <summary>
    /// Event Handler.
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// CheckStatus method.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">List of arguments.</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            status = $"{name} is in perfect health!";
        else if (e.currentHp >= maxHp / 2f)
            status = $"{name} is doing well!";
        else if (e.currentHp >= maxHp / 4f)
            status = $"{name} isn't doing too great...";
        else if (e.currentHp > 0)
            status = $"{name} needs help!";
        else
            status = $"{name} is knocked out!";
        Console.WriteLine(status);
    }

    /// <summary>
    /// HPValueWarning method that prints a message when hp is low or zero.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">List of arguments.</param>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Health is low!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    /// <summary>
    /// Check if hp is low.
    /// </summary>
    /// <param name="e">List of arguments.</param>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp / 4f)
            HPCheck += HPValueWarning;
        HPCheck(this, e);
    }
}

/// <summary>
/// Heal or damage modifier.
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak modifier (0.5).
    /// </summary>
    Weak,
    /// <summary>
    /// Base modifier (1).
    /// </summary>
    Base,
    /// <summary>
    /// Strong modifier (1.5).
    /// </summary>
    Strong
}

/// <summary>
/// CalculateModifier delegate.
/// </summary>
/// <param name="baseValue">Amount of damage or heal.</param>
/// <param name="modifier">Damage or heal modifier.</param>
/// <returns>Value after being multiplied by the modifier.</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// CurrentHPArgs class derived from EventArgs.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Player's current health points.
    /// </summary>
    public readonly float currentHp;

    /// <summary>
    /// CurrentHPArgs constructor.
    /// </summary>
    /// <param name="newHp">The new value of health points.</param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}