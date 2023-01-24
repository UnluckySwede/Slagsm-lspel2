using System;

public class Enemy
{
    public string name;

    public int hp;


    public Weapon weapon;

    private bool isAlive = true;

    private Random generator = new Random();

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

    public int agility() // int som bestämmer hur många % av attack damage kommer igenom till hp.
    {
        return generator.Next(10, 100);
    }

    public void Difficulty() // metod som selectar vilken mängd hp som fienden ges.
    {
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
                hp = 50;
                Console.WriteLine("Your enemy shall have 50 hp.");
            }
            else if (difficulty == "2")
            {
                hp = 100;
                Console.WriteLine("Your enemy shall have 100 hp.");
            }
            else if (difficulty == "3")
            {
                hp = 150;
                Console.WriteLine("Your enemy shall have 150 hp.");
            }
            else if (difficulty == "4")
            {
                hp = 200;
                Console.WriteLine("Your enemy shall have 200 hp.");
            }
            if (difficulty != "1" && difficulty != "2" && difficulty != "3" && difficulty != "4")
            {
                Console.WriteLine("Please type 1, 2, 3 or 4 and choose a difficulty.");
                difficulty = Console.ReadLine().ToLower();
            }

        }
    }
}
