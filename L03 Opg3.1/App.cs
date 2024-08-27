namespace L03_APp;

public class App
{
    static void Main(String[] args)
    {
        Circle c = new Circle();
        Circle c1 = new Circle(19, 1 ,1);
        Rectangle r = new Rectangle();
        Rectangle r1 = new Rectangle(30, 40, 1, 1);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(c);
        shapes.Add(c1);
        shapes.Add(r);
        shapes.Add(r1);

        foreach (var obj in shapes)
        {
            if (obj is Shape)
            {
                Console.WriteLine(obj.ToString());
                Console.WriteLine("Area: " + obj.Area());
                Console.WriteLine("-------------------");
            }   
        }

    }
}