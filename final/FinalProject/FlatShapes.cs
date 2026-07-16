public abstract class FlatShapes
{
    protected double _perimeter;
    protected double _area;
    protected string _color;

    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
    public virtual string DisplayInfo()
    {
        return $"Shape: A:{_area:F2}, P:{_perimeter:F2}, C:{_color}";
    }
    public virtual string GetSaveString()
    {
        return $"Shape|{_area},{_perimeter},{_color}";
    }
}