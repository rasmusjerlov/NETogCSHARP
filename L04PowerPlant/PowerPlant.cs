namespace L04PowerPlant;

public class PowerPlant
{
    public delegate void Warning();
    public Warning warningDelegate;

    private Random rnd = new Random();

    public void setWarning(Warning wa)
    {
        warningDelegate += wa;
    }

    public void heatUp()
    {
        int random = rnd.Next(100);
        Console.WriteLine(random);
        if (random > 50)
        {
            warningDelegate();
        }
    }

}