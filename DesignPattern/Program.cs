// See https://aka.ms/new-console-template for more information
using superCanard;
using chasseur;

Canard[] mare =
{
    new Colvert(),
    new Mandarin(),
    new CanardPlastique(),
    new Leurre()
};

mare[1].Cancan = new Begayer(mare[1].Cancan);

foreach (var canard in mare)
{
    canard.Afficher();
    canard.nager();
    canard.EffectuerVol();
    canard.EffectuerCancan();
    canard.Vol = new VolAReaction();
}
foreach (var canard in mare)
{
    canard.EffectuerVol();
}

mare[0].Cancan = new CriAlternatif(new Cancan(), new Coincoin());
for(int i = 0; i < 5; i++)
{
    mare[0].EffectuerCancan();
}

TestChasseur();

void TestChasseur()
{
    Chasseur leon = new Chasseur();
    Chien medord = new Chien();
    Canard canard = new Mandarin();
    leon.chasser(medord);
    leon.chasser(canard);
}

internal class Chien : Animal
{
    public void afficher()
    {
        Console.WriteLine("je suis un chien");
    }

    public void courrir()
    {
        Console.WriteLine("je cours");
    }

    public void crier()
    {
        Console.WriteLine("wouf");
    }
}