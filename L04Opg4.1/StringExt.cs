using System.Runtime.Intrinsics.X86;

namespace L04App;

public static class StringExt
{
    public static void Main(string[] args)
    {
        String s = "Hej";
        String s1 = "hejmeddig";
        Console.WriteLine(Lang(s, 5));
        Console.WriteLine(Lang(s1, 5));
        
        CalculateAndDisplay(3, 4, Add);
        CalculateAndDisplay(3, 4, Multiply);
    }
    public static bool Lang(this String str, int n)
    {
        return str.Length > n;
    }

    delegate int Operation(int a, int b);

    static void CalculateAndDisplay(int a, int b, Operation operation)
    {
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
        int result = operation(a, b);
        Console.WriteLine("Result: " + result);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }
}