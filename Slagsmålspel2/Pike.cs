using System;

public class Pike : Weapon
{
    public int minDamage { get; set; } = 15;
    public int maxDamage { get; set; } = 25;


    public Pike()
    {
        name = "pike";
        accuracy = 65;
    }
}