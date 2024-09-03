namespace L04PowerPlant;

public class App
{
    static void Main(String[] args)
    {
        PowerPlant pp = new PowerPlant();
        pp.setWarning(warningToConsole);
        for (int i = 0; i < 15; i++)
        {
            pp.heatUp();
        }
        
        pp.setWarning(warningToLog);
        for (int i = 0; i < 15; i++)
        {
            pp.heatUp();
        }

    }

    static void warningToConsole()
    {
        Console.WriteLine("Advarsel!");
    }

    static void warningToLog()
    {
        Console.WriteLine("Temperaturen oversteg 50!");
    }
    
}