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
    public void Choice()
    {
        Console.WriteLine("Choose your weapon");
        Console.WriteLine("1. Sword");
        Console.WriteLine("2. Pike");
        Console.WriteLine("3. Axe");
        private string weaponChoice = "Bruh";
    weaponChoice = Console.ReadLine();

        if (weaponChoice == "1")
        {
            return weaponChoice;
        }

if (weaponChoice == "2")
{
    Weapon weapon = new Pike();

}

if (weaponChoice == "3")
{
    Weapon weapon = new Axe();

}
    }
}
