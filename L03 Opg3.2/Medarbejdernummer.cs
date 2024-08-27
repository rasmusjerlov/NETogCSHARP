namespace L03_APp.Opg3._1;

public class Medarbejdernummer
{
    private String nummer;

    public Medarbejdernummer(string nummer)
    {
        this.nummer = nummer;
    }

    public string Nummer
    {
        get => nummer;
        set => nummer = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return nummer;
    }
}