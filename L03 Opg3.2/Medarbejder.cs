namespace L03_APp.Opg3._1;

public abstract class Medarbejder
{
    private String navn, adresse;
    private const int timerPrUge = 37;
    private CprNr cpr;
    private Medarbejdernummer mednr;
    public string Navn
    {
        get => navn;
        set => navn = value;
    }

    public string Adresse
    {
        get => adresse;
        set => adresse = value;
    }
    
    public Medarbejder(Medarbejdernummer mednr, CprNr cpr, string navn, string adresse)
    {
        this.mednr = mednr;
        this.cpr = cpr;
        this.navn = navn;
        this.adresse = adresse;
    }

    public CprNr getCpr
    {
        get => cpr;
        set => cpr = value;
    }

    public Medarbejdernummer getMednr
    {
        get => mednr;
        set => mednr = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int TimerPrUge
    {
        get { return timerPrUge; }
    }

    public abstract double beregnUgeløn();
    public override string ToString()
    {
        return "Navn: " + Navn + "\tCPR-nummer: " + getCpr + "\nAdresse: " + Adresse + "\nMedarbejdernummer: " + getMednr;
    }
}