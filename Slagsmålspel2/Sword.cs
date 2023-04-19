using System;

public class Sword : Weapon
{
    public Sword() //Ger värdena till weapon om detta är vapnet fighter eller enemy väljer
    {
        MinAccuracy = 8;
        MaxAccuracy = 10;
        Name = "sword";
        Damage = 2;
    }

}