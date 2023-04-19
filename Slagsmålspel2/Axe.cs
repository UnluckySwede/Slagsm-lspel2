using System;

public class Axe : Weapon
{
    public Axe()  //Ger värdena till weapon om detta är vapnet fighter eller enemy väljer
    {
        Name = "axe";
        MinAccuracy = 5;
        MaxAccuracy = 10;
        Damage = 3;
    }
}