Fighter f1 = new Fighter();
Enemy e1 = new Enemy();
f1.weapon = new Weapon();
f1.hp = 100;
while (e1.GetAlive() && f1.GetAlive())
{
    Console.Clear();
    Console.WriteLine("Choose a name for your fighter!");
    f1.FighterName(f1);
    Console.WriteLine($"You have chosen {f1.name} as your name. Press any key to continue.");
    Console.ReadLine();
    Console.Clear();
    e1.Difficulty();
    Console.Clear();
    f1.weapon = Weapon.Choice();
    while (e1.hp > 0)
    {
        Console.Clear();
        int strike = 0;
        Console.WriteLine("Do you wish to attack? (y/n)");
        if ("y" == Console.ReadLine())
        {
            strike = f1.weapon.AttackDmg(e1);
            if (e1.hp >= strike)
            {
                e1.hp -= strike;
            }
            else
            {
                e1.hp = 0;
            }

        }
        Console.Clear();
        // string accuracy = f1.weapon.AttackAcc;
        // int.TryParse(f1.weapon.AttackAcc, out accuracy);
        Console.WriteLine($"Enemy hp remaining:{e1.hp}");
        Console.WriteLine($"Weapon:{f1.weapon.name}");
        // Console.WriteLine($"Enemy agility:{e1.Agility()}");
        // Console.WriteLine($"Weapon accuracy:{f1.weapon.AttackAcc()}");
        if (strike == 0)
        {
            Console.WriteLine("Attack missed!");
        }
        else
        {
            Console.WriteLine($"Weapon damage:{strike}");
        }
        Console.ReadLine();
        e1.Death();
    }
    Console.ReadLine();
}