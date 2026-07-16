public class Rectangle : Trapezoid
{
    public Rectangle()
    {
        _sideA = 2;
        _sideB = 1;
        _sideC = 2;
        _sideD = 1;

        _height = 1;

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();

        _color = "blank";
    }
    public Rectangle(double length, double width, string color)
    {
        _sideA = length;
        _sideB = width;
        _sideC = length;
        _sideD = width;
        
        _height = width;

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();
        
        _color = color;
    }
    public override string DisplayInfo()
    {
        return $"Rectangle: A:{_area:F2}, P:{_perimeter:F2}, B:{_sideA:F2}, H{_sideB:F2}, C:{_color} ";
    }
    public override string GetSaveString()
    {
        return $"Rectangle|{_sideA},{_sideB},{_color}";
    }
}