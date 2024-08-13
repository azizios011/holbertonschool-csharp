using System;

/// <summary>
/// enum modefier
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak
    /// </summary>
    Weak,
    /// <summary>
    /// Base
    /// </summary>
    Base,
    /// <summary>
    /// Strong
    /// </summary>
    Strong
};
/// <summary>
/// calculate modefier
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// CurrentHPArgs class
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// readonly hp
    /// </summary>
    public readonly float currentHp;
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="newHp"></param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}
/// <summary>
/// class player 
/// </summary>
public class Player
{
    private String name;
    private float maxHp;
    private float hp;
    private String status;
    /// <summary>
    /// hp check event
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;
    /// <summary>
    /// constructor for the player class
    /// </summary>
    /// <param name="name"> the name of the player</param>
    /// <param name="maxHp"> the max hp of the player</param>
    public Player(string name = "Player", float maxHp = 100f)
    {


        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.name = name;
        this.maxHp = maxHp;
        hp = maxHp;
        status = $"{name} is ready to go!";

        HPCheck += CheckStatus;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            status = $"{name} is in perfect health!";
        else if (e.currentHp >= maxHp / 2 && e.currentHp < maxHp)
            status = $"{name} is doing well!";
        else if (e.currentHp >= maxHp / 4 && e.currentHp < maxHp / 2)
            status = $"{name} isn't doing too great...";
        else if (e.currentHp > 0 && e.currentHp < maxHp / 2)
            status = $"{name} needs help!";
        else status = $"{name} is knocked out!";

        Console.WriteLine(status);


    }
    /// <summary>
    /// apply a modefier on the player
    /// </summary>
    /// <param name="baseValue"> basevalue that modefier will be applied on</param>
    /// <param name="modifier">type of modefier</param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier is Modifier.Weak)
        {
            return baseValue / 2;
        }
        if (modifier is Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        return baseValue;

    }
    /// <summary>
    /// display the hp of the playeer
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
    /// <summary>
    ///  apply damage to player hp
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        hp -= damage;
        ValidateHP(hp);
    }
    /// <summary>
    /// heal damage of the player
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        hp += heal;
        ValidateHP(hp);
    }
    /// <summary>
    /// delegate 
    /// </summary>
    /// <param name="damage"></param>
    public delegate void CalculateHealth(float damage);
    /// <summary>
    /// validate hp and set the new value
    /// </summary>
    /// <param name="newHp"> new value of the hp to be set</param>
    public void ValidateHP(float newHp)
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
        HPCheck?.Invoke(this, new CurrentHPArgs(hp));

    }

}