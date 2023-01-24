using System;

public class Weapon
{
    public int minDamage { get; set; }
    public int maxDamage { get; set; }
    public int minAccuracy { get; set; }
    public int maxAccuracy { get; set; }
    public string name { get; set; }
    private Random generator = new Random();

    public int AttackDmg()
    {
        return generator.Next(minDamage, maxDamage);
    }
    public int AttackAcc()
    {
        return generator.Next(minAccuracy, maxAccuracy);
    }
    public static Weapon Choice()
    {
        Console.WriteLine("Choose your weapon");
        Console.WriteLine("1. Sword");
        Console.WriteLine("2. Pike");
        Console.WriteLine("3. Axe");
        Console.WriteLine("4. Fists");
        string weaponChoice;
        Weapon weapon;
        weaponChoice = Console.ReadLine();
        switch (weaponChoice)
        {
            case ("1"):
                weapon = new Sword();
                break;
            case ("2"):
                weapon = new Pike();
                break;
            case ("3"):
                weapon = new Axe();
                break;
            case ("4"):
                weapon = new Fists();
                break;
            default:
                Console.WriteLine("choose 1-4");
                weapon = Choice();
                break;
        }
        return weapon;
    }
}
