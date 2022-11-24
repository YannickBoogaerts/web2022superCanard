// See https://aka.ms/new-console-template for more information
namespace superCanard
{
    public class CanardPlastique : Canard
    {
        public CanardPlastique() : base(new NePasVoler(), new Coincoin())
        {

        }
        public override void Afficher()
        {
            Console.WriteLine("je suis un canard en plastique");
        }
    }
}