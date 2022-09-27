using System;

public class Weapon
{
    public int minDamage = 20;
    public int maxDamage = 30;
    public string name = "Sword";

    private Random generator = new Random();

    public int Attack()
    {
        return generator.Next(minDamage, maxDamage);
    }
}
