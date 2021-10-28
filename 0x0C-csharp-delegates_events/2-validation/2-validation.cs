using System;


///<summary> Player class</summary>
public class Player
{
    ///<summary> Player'spoperties</summary>
    private string name;
    private float maxHp;
    private float hp;

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
    }
}