using System;


public class Fighter
{
    public string name = "unchosen";

    public int hp;

    public Weapon weapon;

    private Random generator = new Random();

    public int Agility() // int som bestämmer hur många % av attack damage kommer igenom till hp.
    {
        return generator.Next(1, 10);
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

    public string FighterName(Fighter target)
    {
        while (name == "unchosen" || name == "")
        {
            name = Console.ReadLine();
            if (name == "unchosen" || name == "")
            {
                Console.Clear();
                Console.WriteLine("Please type a valid name.");
            }
        }
        return name;
    }


}
