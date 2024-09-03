namespace L04App;
using System;
using System.Collections.Generic;

internal static class IntExt
{
    public static int Fact(this int n)
    {
        return Opg4_3.Factorial(n);
    }

    public static int Power(this int a, int b)
    {
        return Opg4_3.Power(a, b);
    }

}