using System;

public class Sword : Weapon
{
    public int minDamage { get; set; } = 10;
    public int maxDamage { get; set; } = 20;

    public Sword()
    {
        accuracy = 85;
        name = "sword";
    }

}