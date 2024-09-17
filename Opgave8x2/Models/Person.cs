namespace Opgave8x2.Models;

public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return "Name: " + Name + "\nAge: " + Age;
    }
}