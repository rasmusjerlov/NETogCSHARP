using System.Runtime.CompilerServices;

namespace L03_APp.Opg3._1;

public class Synsmand: Mekaniker
{
    private int antalSyn;
    private double ugeløn;

    public Synsmand(Medarbejdernummer mednr, CprNr cpr, string navn, string adresse, int svendeår, double timeløn, int antalSyn, double ugeløn) : base(mednr, cpr, navn, adresse, svendeår, timeløn)
    {
        this.antalSyn = antalSyn;
        this.ugeløn = base.Timeløn * base.TimerPrUge;
    }

    public int AntalSyn
    {
        get => antalSyn;
        set => antalSyn = value;
    }

    public double Ugeløn
    {
        get => ugeløn;
        set => ugeløn = value;
    }

    public override double beregnUgeløn()
    {
        return ugeløn * antalSyn;
    }

    public override string ToString()
    {
        return base.ToString() + "\nAfdeling: Synsmand" + "\nAntalsyn: " + AntalSyn + "\nUgeløn: " + Ugeløn;
    }
}