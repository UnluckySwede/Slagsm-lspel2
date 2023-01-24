﻿Fighter f1 = new Fighter();
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
    f1.weapon = Weapon.Choice();
    while (e1.hp > 0)
    {
        Console.Clear();

        Console.WriteLine("Do you wish to attack?");
        if ("y" == Console.ReadLine())
        {
            if (e1.hp >= f1.weapon.AttackDmg())
            {
                e1.hp -= f1.weapon.AttackDmg();
            }
            else
            {
                e1.hp = 0;
            }
            Console.WriteLine(e1.hp);
        }
        Console.Clear();
        // string accuracy = f1.weapon.AttackAcc;
        // int.TryParse(f1.weapon.AttackAcc, out accuracy);
        Console.WriteLine($"Enemy hp remaining:{e1.hp}");
        Console.WriteLine($"Weapon:{f1.weapon.name}");
        Console.WriteLine($"Weapon accuracy:{f1.weapon.AttackAcc()}");
        Console.WriteLine($"Weapon max damage:{f1.weapon.maxDamage}");
        Console.WriteLine($"Weapon min damage:{f1.weapon.minDamage}");
        Console.ReadLine();
        e1.Death();
    }
    Console.ReadLine();
}