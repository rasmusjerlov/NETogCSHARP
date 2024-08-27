namespace L03_APp.Opg3._1;

public class App
{
    static void Main(String[] args)
    {
        Medarbejdernummer mednr1 = new Medarbejdernummer("27");
        Medarbejdernummer mednr2 = new Medarbejdernummer("21");
        Medarbejdernummer mednr3 = new Medarbejdernummer("32");
        Medarbejdernummer mednr4 = new Medarbejdernummer("41");
        CprNr cpr1 = new CprNr("13122000", "3451");
        CprNr cpr2 = new CprNr("15071230", "3813");
        CprNr cpr3 = new CprNr("19862135", "5493");
        CprNr cpr4 = new CprNr("86920581", "1239");
        Mekaniker mk1 = new Mekaniker(mednr1, cpr1,"Rasmus", "Gøteborg Allé", 2016, 180);
        Mekaniker mk2 = new Mekaniker(mednr2, cpr2, "Sebastian", "Skanderborgvej", 2002, 66.5);
        Mekaniker mk3 = new Mekaniker(mednr3, cpr3, "Mikkel", "Silkeborgvej", 2007, 122);
        Mekaniker mk4 = new Mekaniker(mednr4, cpr4, "Mark", "Blegdammen", 2012, 313);
        Værkfører vk1 = new Værkfører(mednr1, mk1.getCpr, mk1.Navn, mk1.Adresse, mk1.Svendeår, mk1.Timeløn, 2018, 38);
        Værkfører vk2 = new Værkfører(mednr2, mk2.getCpr, mk2.Navn, mk2.Adresse, mk2.Svendeår, mk2.Timeløn, 2006, 12);
        Synsmand sy1 = new Synsmand(mednr3, mk3.getCpr, mk3.Navn, mk3.Adresse, mk3.Svendeår, mk3.Timeløn, 28, 0);
        Synsmand sy2 = new Synsmand(mednr4, mk4.getCpr, mk4.Navn, mk4.Adresse, mk4.Svendeår, mk4.Timeløn, 18, 0);
        
        List<Medarbejder> medarbejdere = new List<Medarbejder>();
        medarbejdere.Add(mk1);
        medarbejdere.Add(mk2);
        medarbejdere.Add(vk1);
        medarbejdere.Add(sy1);

        foreach (var obj in medarbejdere)
        {
            Console.WriteLine(obj.ToString());
            Console.WriteLine("---------------");
        }

    }
    
}