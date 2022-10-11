Fighter f1 = new Fighter();
Fighter f2 = new Fighter();
f1.weapon = new Weapon();

f1.hp = 100;
f2.hp = 75;


while (f2.GetAlive() && f1.GetAlive())
{


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