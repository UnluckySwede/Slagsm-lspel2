using System;

public class Enemy : Fighter
{
    public int Weapon { get; set; }
    public Weapon EnemyWeapon { get; set; }

    public void Difficulty() // metod som selectar vilken mängd hp som fienden ges.
    {
        Console.WriteLine("Choose your difficulty.");
        Console.WriteLine("");
        Console.WriteLine("1. Easy");
        Console.WriteLine("2. Normal");
        Console.WriteLine("3. Hard");
        Console.WriteLine("4. Impossible");
        string difficulty = "placeholder";
        while (difficulty == "placeholder")
        {
            difficulty = Console.ReadLine().ToLower();
            if (difficulty == "1")
            {
                hp = 50;
                Console.WriteLine("Your enemy shall have 50 hp.");
            }
            else if (difficulty == "2")
            {
                hp = 100;
                Console.WriteLine("Your enemy shall have 100 hp.");

            }
            else if (difficulty == "3")
            {
                hp = 150;
                Console.WriteLine("Your enemy shall have 150 hp.");
            }
            else if (difficulty == "4")
            {
                hp = 200;
                Console.WriteLine("Your enemy shall have 200 hp.");
            }
            if (difficulty != "1" && difficulty != "2" && difficulty != "3" && difficulty != "4")
            {
                Console.Clear();
                Console.WriteLine("Please type 1, 2, 3 or 4 and choose a difficulty.");
                difficulty = "placeholder";
            }

        }
    }
    // private static int EnemyWeapon()
    // {
    //     return generator.Next(1, 4);
    // }
    public static Weapon EnemyWeaponChoice()
    {
        Random generator = new Random();
        int Weapon = generator.Next(0, 3);
        Weapon EnemyWeapon;
        switch (Weapon)
        {
            case (0):
                EnemyWeapon = new Axe();
                break;
            case (1):
                EnemyWeapon = new Sword();
                break;
            case (2):
                EnemyWeapon = new Fists();
                break;
            case (3):
                EnemyWeapon = new Pike();
                break;
            default:
                EnemyWeapon = new Fists();
                break;
        }
        return EnemyWeapon;
    }
}
