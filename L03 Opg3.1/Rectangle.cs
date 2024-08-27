namespace L03_APp;

public class Rectangle: Shape
{
    private double width, length;

    public Rectangle(double width, double length, double x, double y):base(x, y)
    {
        this.width = width;
        this.length = length;
    }

    public Rectangle() : this(20, 30, 1, 1)
    {
    }

    public double Width
    {
        get => width;
        set => width = value;
    }

    public double Length
    {
        get => length;
        set => length = value;
    }

    public override double Area()
    {
        return width * length;
    }

    public override string ToString()
    {
        return "This shape is a rectangle. \nWidth: " + width + "\nLength: " + length + "\n" + base.ToString();
    }
}