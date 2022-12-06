using System;

public class Axe : Weapon
{
    public int minDamage { get; set; } = 20;
    public int maxDamage { get; set; } = 30;

    public Axe()
    {
        name = "axe";
        accuracy = 50;
    }
}