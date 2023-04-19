using System;

public class Pike : Weapon
{
    public Pike()  //Ger värdena till weapon om detta är vapnet fighter eller enemy väljer
    {
        Name = "pike";
        MinAccuracy = 6;
        MaxAccuracy = 10;
        Damage = 2;
    }
}