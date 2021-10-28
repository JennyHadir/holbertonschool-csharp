using System;


///<summary> Player class</summary>
public class Player
{
    ///<summary> Player'spoperties</summary>
    private string name;
    private float maxHp, hp;

    ///<summary>Player's Constructor</summary>
    public Player(string name="Player", float maxHp=100f)
    {
        if (maxHp < 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        hp = this.maxHp = maxHp;
        this.name = name;
    }

    ///<summary> Player's method to print his health</summary>
    public void PrintHealth()
    {
        Console.WriteLine(name + " has " + hp + " / " + maxHp + " health");
    }
}

