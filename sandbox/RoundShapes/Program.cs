
public class Program
{
    public static void Main()
    {
        Console.WriteLine();

        List<RoundShape> myShapes = new List<RoundShape>();

        // myShapes.Add( new RoundShape());
        myShapes.Add(new Circle(1.0));
        myShapes.Add(new Cylindar(1.0, 1.0));
        myShapes.Add(new Sphere(1.0));

        foreach (RoundShape shape in myShapes)
        {
            Console.WriteLine(shape.ToString() + " Area: " + shape.Area().ToString());
        }
        Console.WriteLine();
    }
}