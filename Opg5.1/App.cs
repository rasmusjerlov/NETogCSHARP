// See https://aka.ms/new-console-template for more information
class App
{
    static void Main(String[] args)
    {
        List<int> ints = new List<int>();
        
        ints.Add(3);
        ints.Add(4);
        ints.Add(6);
        ints.Add(7);
        ints.Add(12);
        ints.Add(9);
        ints.Add(16);
        ints.Add(24);
        ints.Add(21);

        Console.WriteLine("List.FindAll()");
        List<int> resultList = ints.FindAll(i => i % 2 == 0);
        foreach (int i in resultList)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("LastInt");
        int lastIntGreaterThan15 = ints.FindLast(i => i > 15);
        Console.WriteLine(lastIntGreaterThan15);

        Console.WriteLine("LastIndex");
        int lastIndexGreaterThan15 = ints.FindLastIndex(i => i > 15);
        Console.WriteLine(lastIndexGreaterThan15);

        Console.WriteLine("IEnumerable");
        IEnumerable<int> result5x2 = ints.Where(i => i % 2 == 0).OrderBy(i => i);
        foreach (int x in result5x2)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine("IEnumerable 2");
        IEnumerable<int> result5x2x2 = ints.Where(i => i.ToString().Length == 2).OrderBy(i => i);
        foreach (int x in result5x2x2)
        {
            Console.WriteLine(x);
        }
    }
}
