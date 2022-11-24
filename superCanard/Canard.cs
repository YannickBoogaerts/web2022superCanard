// See https://aka.ms/new-console-template for more information
namespace superCanard
{

    public abstract class Canard
    {
        public ComportementVol Vol { get; set; }
        public ComportementCancan Cancan { get; set; }

        public Canard(ComportementVol vol, ComportementCancan cancan)
        {
            Cancan = cancan;
            Vol = vol;
        }


        public abstract void Afficher();

        public void EffectuerVol()
        {
            this.Vol.Voler();
        }

        public void EffectuerCancan()
        {
            Cancan.Cancanner();
        }

        public void nager()
        {
            Console.WriteLine("plouf, plouf");
        }
    }
}