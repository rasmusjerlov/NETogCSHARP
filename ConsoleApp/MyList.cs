namespace L01;

public class MyList
{
    public List<int> myList = new List<int>();

    public void addNumber(int n)
    {
        myList.Add(n);
    }

    public void printList()
    {
        foreach (var i in myList)
        {
            Console.WriteLine(i);
        }
    }
}