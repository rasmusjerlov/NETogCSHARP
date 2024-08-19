namespace MyLibrary;

public class Animal : IAnimal
{
    private string species;
    public Animal(string species)
    {
        this.species = species;
    }

    public bool isDog()
    {
        return species.Equals("dog");
    }
}