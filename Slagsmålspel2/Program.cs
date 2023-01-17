Fighter f1 = new Fighter();
Enemy e1 = new Enemy();
f1.weapon = new Weapon();

f1.hp = 100;


while (e1.GetAlive() && f1.GetAlive())
{
    Console.Clear();

    Console.WriteLine("Choose a name for your fighter!");

    f1.name = Console.ReadLine();

    Console.WriteLine($"You have chosen {f1.name} as your name. Press any key to continue.");
    Console.ReadLine();
    Console.Clear();

    e1.Difficulty();

    f1.weapon.Choice();


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
    while (e1.hp > 0)
    {
        Console.WriteLine("Do you wish to attack?");
        if ("yes" == Console.ReadLine())
        {
            if (e1.hp >= f1.weapon.Attack())
            {
                e1.hp -= f1.weapon.Attack();
            }
            else
            {
                e1.hp = 0;
            }
            Console.WriteLine(e1.hp);
        }

        Console.WriteLine(f1.weapon.name);
        e1.Death();
    }
    Console.ReadLine();
}