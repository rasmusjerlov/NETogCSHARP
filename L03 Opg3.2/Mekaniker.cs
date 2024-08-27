namespace L03_APp.Opg3._1;

public class Mekaniker: Medarbejder
{
    private int svendeår;
    private double timeløn;

    public int Svendeår
    {
        get => svendeår;
        set => svendeår = value;
    }

    public double Timeløn
    {
        get => timeløn;
        set => timeløn = value;
    }

    public Mekaniker(Medarbejdernummer mednr, CprNr cpr, string navn, string adresse, int svendeår, double timeløn) : base(mednr, cpr, navn, adresse)
    {
        this.svendeår = svendeår;
        this.timeløn = timeløn;
    }
    

    public override double beregnUgeløn()
    {
        int antalTimer = base.TimerPrUge;
        return timeløn * antalTimer;
    }

    public override string ToString()
    {
        return base.ToString() + "\nStilling: Mekaniker \nTimeløn: " + Timeløn + "DKK" + "\nSvendeår: " + Svendeår;
    }
}