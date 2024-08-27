namespace L03_APp;

public abstract class Shape
{
    private double x, y;

    public Shape(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public Shape():this(1, 1)
    {
    }

    public double X
    {
        get => x;
        set => x = value;
    }

    public double Y
    {
        get => y;
        set => y = value;
    }

    public abstract double Area();
    public override string ToString()
    {
        return "X: " + x + "\nY: " + y;
    }
}