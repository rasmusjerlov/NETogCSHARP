namespace Opg5._3;

public class SortByScore : IComparer<Person>
{
    private bool ascending = true;
    public int Compare(Person? x, Person? y)
    {
        int res = x.Score - y.Score;

        if (!ascending)
        {
            res = res * -1;
        }

        return res;
    }
}