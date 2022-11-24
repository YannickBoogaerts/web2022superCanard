// See https://aka.ms/new-console-template for more information
namespace superCanard
{

    public class Colvert : Canard
    {
        public Colvert() : base(new VolerAvecAiles(), new Coincoin())
        {

        }
        public override void Afficher()
        {
            Console.WriteLine("je suis un canard en plastique");
        }
    }
}