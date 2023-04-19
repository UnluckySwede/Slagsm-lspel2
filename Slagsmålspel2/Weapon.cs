using System;

public class Weapon
{
    public int Damage { get; set; }
    public int MinAccuracy { get; set; }
    public int MaxAccuracy { get; set; }
    public string Name { get; set; }
    public int Accuracy { get; set; }

    private Random generator = new Random();

    public int AttackAcc() //Giver en random accuracy som kan bli påverkad beroende på vapnet man valt
    {
        return generator.Next(MinAccuracy, MaxAccuracy);
    }

    public int AttackDmg(Enemy target) //Kalkylerar om fighter attack accuracy är högre än enemys agility och hur mycket skada som kommer igenom
    {
        Accuracy = AttackAcc();
        target.RandomizeAgility();
        int Agility = target.Agility;
        if (Accuracy <= Agility)
        {
            return 0;
        }
        else
        {
            int damage3 = Damage * Accuracy;
            return damage3;
        }
    }
    public int AttackDmg(Fighter target) //Kalkylerar om enemy attack accuracy är högre än fighter agility och hur mycket skada som kommer igenom (Jag har ännu ej gjort så att denna aktiverar)
    {
        Accuracy = AttackAcc();
        target.RandomizeAgility();
        int Agility = target.Agility;
        if (Accuracy <= Agility)
        {
            return 0;
        }
        else
        {
            int damage3 = Damage * Accuracy;
            return damage3;
        }
    }

    public static Weapon Choice() //Använder en switch för att kolla vilket vapen som fighter väljer
    {
        Console.Clear();
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
