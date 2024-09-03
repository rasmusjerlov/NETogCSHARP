namespace Opg5._3;

public class SortByAge : IComparer<Person>
{
    private bool ascending = true;

    public SortByAge(bool ascending)
    {
        this.ascending = ascending;
    }

    public int Compare(Person? x, Person? y)
    {
        int res = x.Age - y.Age;

        if (!ascending)
        {
            res = res * -1;
        }

        return res;
    }
}