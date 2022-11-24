namespace chasseur
{
    public class Chasseur
    {
        public void chasser(Animal animal)
        {
            Console.WriteLine("pan pan pan");
            animal.crier();
            animal.courrir();
        }
    }
}