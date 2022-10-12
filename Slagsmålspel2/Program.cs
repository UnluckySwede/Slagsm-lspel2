Fighter f1 = new Fighter();
Fighter f2 = new Fighter();
f1.weapon = new Weapon();

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

    int damage = f1.weapon.Attack();

    if (f2.hp >= damage)
    {
        f2.hp -= damage;
    }
    else
    {
        f2.hp = 0;
    }


    Console.WriteLine(f1.weapon.name);
    Console.WriteLine(f2.hp);


    f2.Death();

    Console.ReadLine();

}