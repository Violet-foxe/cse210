public class Program
{
    public static void Main()
    {
        Console.WriteLine();
        List<Animal> myAnimals = new List<Animal> ();

        myAnimals.Add(new Animal("Liger"));
        myAnimals.Add(new Dog("Zorro"));
        myAnimals.Add(new Cat("Oscar"));
        myAnimals.Add(new Fox("Scarlet"));

        foreach (Animal critter in myAnimals)
        {
            critter.MakeNoise();
        }

        Console.WriteLine();
    }
}
