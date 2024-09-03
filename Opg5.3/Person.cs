namespace Opg5._3;

public class Person
{
    private String name;
    private int age, weight, score;
    private bool accepted;

    public Person(string name, int age, int weight, int score, bool accepted)
    {
        this.name = name;
        this.age = age;
        this.weight = weight;
        this.score = score;
        this.accepted = accepted;
    }
    public Person(string data) {
// Name, Age, Weight, Score
        var L = data.Split(';');
        Name = L[0];
        Age = int.Parse(L[1]);
        Weight = int.Parse(L[2]);
        Score = int.Parse(L[3]);
        Accepted = false; //denne parameter bliver ikke indlæst, men skal bruges senere.
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public int Weight
    {
        get => weight;
        set => weight = value;
    }

    public int Score
    {
        get => score;
        set => score = value;
    }

    public bool Accepted
    {
        get => accepted;
        set => accepted = value;
    }
    
    public static List<Person> ReadCSVFile(string filename) {
        List<Person> list = new List<Person>();
        using (var file = new StreamReader(filename)) {
            string line;
            while ((line = file.ReadLine()) != null) {
                var p = new Person(line);
                list.Add(p);
//Console.WriteLine(p);
            }
        }
        return list;
    }

    public override string ToString()
    {
        return "\nName: " + Name
            + "\nAge: " + Age
            + "\nWeight: " + Weight
            + "\nScore: " + Score
            + "\nAccepted: " + Accepted
            + "\n---------------";
    }
}