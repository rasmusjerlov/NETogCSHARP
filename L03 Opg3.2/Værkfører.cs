namespace L03_APp.Opg3._1;

public class Værkfører : Mekaniker
{
    private int udnævnelsesår;
    private double tillæg;

    public int Udnævnelsesår
    {
        get => udnævnelsesår;
        set => udnævnelsesår = value;
    }

    public double Tillæg
    {
        get => tillæg;
        set => tillæg = value;
    }

    public Værkfører(Medarbejdernummer mednr, CprNr cpr, string navn, string adresse, int svendeår, double timeløn, int udnævnelsesår, double tillæg) : base(mednr, cpr, navn, adresse, svendeår, timeløn)
    {
        this.udnævnelsesår = udnævnelsesår;
        this.tillæg = tillæg;
    }
    

    public override double beregnUgeløn()
    {
        double basisløn = base.Timeløn;
        double tillæg = this.tillæg;
        double antalTimer = base.TimerPrUge;
        return (basisløn * antalTimer) + (antalTimer * this.tillæg);
    }

    public override string ToString()
    {
        return base.ToString() + "\nAfdeling: Værkfører" + "\nUdnævnelsesår: " + Udnævnelsesår + "\nTillæg: " + Tillæg + "DKK";
    }
}