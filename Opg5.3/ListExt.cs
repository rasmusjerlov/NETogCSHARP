namespace Opg5._3;

public static class ListExt
{
    public static void SetAccepted(this List<Person> persons, Predicate<Person> pred)
    {
        List<Person> predPersons = persons.FindAll(pred);
        foreach (Person p in predPersons)
        {
            p.Accepted = true;
        }
    }

    public static void Reset(this List<Person> persons)
    {
        foreach (Person p in persons)
        {
            p.Accepted = false;
        }
    }
}