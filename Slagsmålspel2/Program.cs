Fighter f1 = new Fighter();
Fighter f2 = new Fighter();


f1.hp = 100;
f2.hp = 75;


while (f2.GetAlive() && f1.GetAlive())
{
    Console.Clear();

    Console.WriteLine("Choose a name for your fighter!");

    f1.name = Console.ReadLine();

    Console.WriteLine($"You have chosen {f1.name} as your name. Press any key to continue.");
    Console.ReadLine();
    Console.Clear();

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
            f2.hp = 50;
            Console.WriteLine("Your enemy shall have 50 hp.");
        }
        else if (difficulty == "2")
        {
            f2.hp = 100;
            Console.WriteLine("Your enemy shall have 100 hp.");
        }
        else if (difficulty == "3")
        {
            f2.hp = 150;
            Console.WriteLine("Your enemy shall have 150 hp.");
        }
        else if (difficulty == "4")
        {
            f2.hp = 200;
            Console.WriteLine("Your enemy shall have 200 hp.");
        }
        if (difficulty != "1" && difficulty != "2" && difficulty != "3" && difficulty != "4")
        {
            Console.WriteLine("Please type 1, 2, 3 or 4 and choose a difficulty.");
            difficulty = Console.ReadLine().ToLower();
        }

    }

    Console.WriteLine("Choose your weapon");
    Console.WriteLine("1. Sword");
    Console.WriteLine("2. Pike");
    Console.WriteLine("3. Axe");
    string weaponChoice = "Bruh";
    weaponChoice = Console.ReadLine();

    if (weaponChoice == "1")
    {
        Weapon lmao = new Sword();
        f1.weapon = lmao;
    }

    if (weaponChoice == "2")
    {
        Weapon lmao = new Pike();
        f1.weapon = lmao;
    }

    if (weaponChoice == "3")
    {
        Weapon lmao = new Axe();
        f1.weapon = lmao;
    }
    while (f2.hp > 0)
    {
        Console.WriteLine("Do you wish to attack?");
        if ("yes" == Console.ReadLine())
        {
            if (f2.hp >= f1.weapon.Attack())
            {
                f2.hp -= f1.weapon.Attack();
            }
            else
            {
                f2.hp = 0;
            }
            Console.WriteLine(f2.hp);
        }

        Console.WriteLine(f1.weapon.name);
        f2.Death();
    }
    Console.ReadLine();
}