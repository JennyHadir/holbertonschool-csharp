using System;


///<summary> Player class</summary>
public class Player
{
    ///<summary> Player'spoperties</summary>
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    ///<summary> EventHandler</summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    ///<summary>Player's Constructor</summary>
    public Player(string name="Player", float maxHp=100f)
    {
        this.name = name;
        if (maxHp <= 0f)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
        HPCheck += CheckStatus;
        status = $"{this.name} is ready to go!";
    }

    ///<summary> Player's method to print his health</summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

    ///<summary>TakeDamage delegate method</summary>
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

    ///<summary>TakeDamage delegate method</summary>
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

    ///<summary> CalculateHealth Delegate</summary>
    public delegate void CalculateHealth(float damage);

    ///<summary>ValidateHP method</summary>
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
        HPCheck(this, new CurrentHPArgs(hp));
    }

    ///<summary> ApplyModifier</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if ( modifier == Modifier.Weak)
        {
            return (baseValue / 2);
        }
        else if (modifier == Modifier.Base)
        {
            return (baseValue);
        }
        else
        {
            return (1.5f * baseValue);
        }
    }

    ///<summary>Check status method</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            status = $"{this.name} is in perfect health!";
        }
        else if (e.currentHp < maxHp && e.currentHp >= maxHp / 2)
        {
           status = $"{this.name} is doing well!"; 
        }
        else if (e.currentHp < maxHp / 2 && e.currentHp >= maxHp / 4)
        {
            status = $"{this.name} isn't doing too great..."; 
        }
        else if (e.currentHp > 0 && e.currentHp < maxHp / 4)
        {
            status = $"{this.name} needs help!"; 
        }
        else
        {
            status = $"{this.name} is knocked out!"; 
        }
        Console.WriteLine(status);
    }
}

///<summary>Enum Modifier</summary>
public enum Modifier
{
    /// Weak Modifier
    Weak,
    /// Base Modifier
    Base,
    /// Strong Modifier
    Strong
}

///<summary> CalculateModifier</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary> CurrentHPArgs class that inherits from EventArgs</summary>
public class CurrentHPArgs : EventArgs
{
    /// CurrentHp prop that cannot be modified
    public readonly float currentHp;

    ///<summary> CurrentHPArgs Constructor</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}