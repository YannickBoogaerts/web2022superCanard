namespace chasseur
{
    public class Chasseur
    {
        public void chasser(Animal animal)
        {
            animal.afficher();
            Console.WriteLine("pan pan pan");
            animal.crier();
            animal.courrir();
        }
    }
}