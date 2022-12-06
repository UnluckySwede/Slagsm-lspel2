using System;

public class Weapon
{
    public int minDamage { get; set; }
    public int maxDamage { get; set; }
    public int accuracy { get; set; }
    public string name { get; set; }
    private Random generator = new Random();

    public int Attack()
    {
        return generator.Next(minDamage, maxDamage);
        return generator.Next(accuracy, 100);
    }
}
