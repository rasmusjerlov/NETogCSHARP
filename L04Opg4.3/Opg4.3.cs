namespace L04App;

public class Opg4_3
{
    static void Main(String[] args)
    {
        Console.WriteLine(Factorial(5));
        Console.WriteLine(8.Fact());
        Console.WriteLine(4.Power(4));
        
    }

    public static int Factorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
            
        }
    }

    public static int Power(int a, int b)
    {
        switch (a)
        {
            case 0:
                return 0;
                default:
                switch (b)
                {
                    case 0:
                        return 0;
                    default:
                        return a * b;
                }
        }
    }
}