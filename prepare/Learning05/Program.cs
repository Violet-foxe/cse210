using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Console.WriteLine("Hello Learning05 World!");

        Square sh1 = new Square("red", 2);
        Rectangle sh2 = new Rectangle("blue", 2, 3);
        Circle sh3 = new Circle("yellow", 1);
        
        List<Shape> shapes = new();
        shapes.Add(sh1);
        shapes.Add(sh2);
        shapes.Add(sh3);

        foreach (Shape sh in shapes)
        {
            Console.WriteLine($"{sh.GetColor()}, a: {sh.GetArea()}");
        }

        Console.WriteLine();
    }
}