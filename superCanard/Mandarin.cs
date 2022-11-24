// See https://aka.ms/new-console-template for more information
namespace superCanard
{
    public class Mandarin : Canard
    {
        public Mandarin() : base(new VolerAvecAiles(), new Cancan())
        {

        }
        public override void Afficher()
        {
            Console.WriteLine("je suis un Mandarin");
        }
    }
}