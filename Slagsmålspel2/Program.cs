Fighter f1 = new Fighter();
Fighter f2 = new Fighter();
f1.weapon = new Weapon();

f1.hp = 100;
f2.hp = 75;

bool alive = true;

while (alive = true)
{


    int damage = f1.weapon.Attack();

    f2.hp -= damage;


    Console.WriteLine(f1.weapon.name);
    Console.WriteLine(f2.hp);


    Console.ReadLine();

    if (f1.hp <= 0)
    {
        alive = false;
    }

}