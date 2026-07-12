public abstract class FlatShapes
{
    protected double _perimeter;
    protected double _area;
    protected string _color;

    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
    public virtual string DisplayInfo()
    {
        return $"Shape: A:{_area}, P:{_perimeter}, C:{_color}";
    }
    public virtual string ChoseColor()
    {
        Console.Write("choose color: ");
        string color = Console.ReadLine();
        return color;
    }
}