// See https://aka.ms/new-console-template for more information
namespace superCanard
{
    public class Leurre : Canard
    {
        public Leurre() : base(new NePasVoler(), new Muet())
        {

        }
        public override void Afficher()
        {
            Console.WriteLine("je suis un Leurre");
        }
    }
}