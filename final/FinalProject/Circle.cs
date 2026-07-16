public class Circle : FlatShapes
{
    protected double _radius;
    public Circle()
    {
        _radius = 1;

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();
        _color = "blank";
    }
    public Circle(double radius, string color)
    {
        _radius = radius;

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();
        _color = color;
    }
    public override double CalculatePerimeter()
    {
        double pi = Math.PI;
        double perimeter = 2 * pi * _radius;
        return perimeter;
    }
    public override double CalculateArea()
    {
        double pi = Math.PI;
        double area = pi * _radius * _radius;
        return area;
    }
    public override string DisplayInfo()
    {
        return $"Circle: A:{_area:F2}, P:{_perimeter:F2}, R:{_radius:F2}, C:{_color} ";
    }
    public override string GetSaveString()
    {
        return $"Circle|{_radius},{_color}";
    }
}