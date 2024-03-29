using System;


public class Fighter
{
    public string name = "unchosen";

    public int hp;

    public Weapon weapon;

    private Random generator = new Random();

    public int Agility { get; set; }

    public void RandomizeAgility() // int som bestämmer hur många % av attack damage kommer igenom till hp.
    {
        Agility = generator.Next(1, 10);
    }

    private bool isAlive = true;

    public bool GetAlive() //Returnerar om fighter är vid liv eller inte
    {
        return isAlive;
    }

    public void Death() //Kollar om fighter är vid liv eller inte
    {
        if (hp <= 0)
        {
            isAlive = false;
        }
    }

    public string FighterName(Fighter target) //Ber om ett namn från spelaren som kommer då bli fighters namn
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
