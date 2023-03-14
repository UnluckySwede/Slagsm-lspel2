using System;


public class Fighter
{
    public string name;

    public int hp;

    public Weapon weapon;

    private Random generator = new Random();

    public int Agility() // int som bestämmer hur många % av attack damage kommer igenom till hp.
    {
        return generator.Next(10, 100);
    }

    private bool isAlive = true;

    public bool GetAlive()
    {
        return isAlive;
    }

    public void Death()
    {
        if (hp <= 0)
        {
            isAlive = false;
        }
    }



}
