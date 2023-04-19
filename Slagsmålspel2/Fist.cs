using System;

public class Fists : Weapon
{
    public Fists()  //Ger värdena till weapon om detta är vapnet fighter eller enemy väljer
    {
        Name = "fists";
        MinAccuracy = 7;
        MaxAccuracy = 10;
        Damage = 1;

    }
}