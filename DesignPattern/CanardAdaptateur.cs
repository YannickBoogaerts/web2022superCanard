// See https://aka.ms/new-console-template for more information
using chasseur;
using superCanard;

internal class CanardAdaptateur : Animal
{
    private Canard canard;

    public CanardAdaptateur(Canard canard)
    {
        this.canard = canard;
    }

    public void afficher()
    {
        canard.Afficher();
    }

    public void courrir()
    {
        canard.EffectuerVol();
    }

    public void crier()
    {
        canard.EffectuerCancan();
    }
}