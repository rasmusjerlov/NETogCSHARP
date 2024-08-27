using System.Runtime.Intrinsics.X86;

namespace L03_APp;

public class Circle: Shape
{
    private double radius;

    public Circle(double radius, double x, double y):base(x, y)
    {
        this.radius = radius;
    }

    public Circle():this(10, 1, 1)
    {
        
    }

    public double Radius
    {
        get => radius;
        set => radius = value;
    }

    public override double Area()
    {
        return (radius * radius) * Math.PI;
    }

    public override string ToString()
    {
        return "This shape is a circle. Radius: " + radius + "\n" + base.ToString();
    }
}