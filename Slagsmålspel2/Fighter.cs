using System;


public class Fighter
{
    public string name = "Kyle";

    public int hp = 1;

    public Weapon weapon;

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
